using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using HaloBlobViewer.source.helpers;
using HaloBlobViewer;

namespace HaloBlobViewer.source.formats
{
    class TagExtract
    {

        public void ParseTag(string tagFile)
        {
            byte[] pattern = { 0x42, 0x4C, 0x41, 0x4D, 0x74, 0x61, 0x67, 0x21 };
            int patternLength = pattern.Length;
            int fileCounter = 0;
            const int bytesToDisregard = 0x3C;
            const int zeroBytesThreshold = 0xFFFF;

            string tagPath = Path.GetDirectoryName(Globals.tagPath);
            Directory.CreateDirectory(Path.Combine(tagPath, tagFile + "_dump"));
            string outputFolder = Path.Combine(tagPath, tagFile + "_dump");

            byte[] fileBytes = File.ReadAllBytes(Globals.tagPath);

            for (int i = 0; i < fileBytes.Length - patternLength; i++)
            {
                if (IsPatternMatch(fileBytes, i, pattern))
                {
                    int extensionStartIndex = i - 12;
                    if (extensionStartIndex + 4 > fileBytes.Length)
                        break;

                    string fileExtension = Encoding.ASCII.GetString(fileBytes, extensionStartIndex, 4).Trim('\0');

                    fileExtension = MakeValidFileName(fileExtension);

                    int dataStartIndex = i - 0x30;
                    if (dataStartIndex < 0)
                        dataStartIndex = 0;

                    int nextPatternIndex = FindNextPatternIndex(fileBytes, i + patternLength, pattern);
                    if (nextPatternIndex == -1)
                        nextPatternIndex = fileBytes.Length;

                    int dataLength = nextPatternIndex - dataStartIndex;

                    if (dataLength > bytesToDisregard)
                    {
                        dataLength -= bytesToDisregard;
                    }
                    else
                    {
                        continue;
                    }

                    int zeroBytesCount = CountTrailingZeroBytes(fileBytes, dataStartIndex, dataLength);
                    if (zeroBytesCount >= zeroBytesThreshold)
                    {
                        dataLength -= zeroBytesCount;
                    }

                    byte[] dataToWrite = new byte[dataLength];
                    Array.Copy(fileBytes, dataStartIndex, dataToWrite, 0, dataLength);

                    string outputFileName = Path.Combine(outputFolder, $"{fileCounter}.{fileExtension}");
                    File.WriteAllBytes(outputFileName, dataToWrite);

                    fileCounter++;
                    i = nextPatternIndex - 1;
                }
            }

            MessageBox.Show($"Extracted: {fileCounter} tags!", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private static string GetProgramRoot()
        {
            return AppDomain.CurrentDomain.BaseDirectory;
        }

        static bool IsPatternMatch(byte[] fileBytes, int index, byte[] pattern)
        {
            for (int i = 0; i < pattern.Length; i++)
            {
                if (fileBytes[index + i] != pattern[i])
                    return false;
            }
            return true;
        }

        static int FindNextPatternIndex(byte[] fileBytes, int startIndex, byte[] pattern)
        {
            for (int i = startIndex; i < fileBytes.Length - pattern.Length; i++)
            {
                if (IsPatternMatch(fileBytes, i, pattern))
                    return i;
            }
            return -1;
        }

        static int CountTrailingZeroBytes(byte[] fileBytes, int startIndex, int dataLength)
        {
            int zeroBytesCount = 0;
            for (int i = dataLength - 1; i >= 0; i--)
            {
                if (fileBytes[startIndex + i] == 0x00)
                    zeroBytesCount++;
                else
                    break;
            }
            return zeroBytesCount;
        }

        static string MakeValidFileName(string fileName)
        {
            var invalidChars = Path.GetInvalidFileNameChars();
            foreach (var invalidChar in invalidChars)
            {
                fileName = fileName.Replace(invalidChar, '_');
            }
            return string.IsNullOrWhiteSpace(fileName) ? "default" : fileName;
        }

    }
}