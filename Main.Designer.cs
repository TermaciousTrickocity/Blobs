
using System.Runtime.InteropServices;
using System;

namespace HaloBlobViewer
{
    partial class mainform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        
       
        ////////////////////////////////////////////////////////////////////// Force Dark Window too
      
        [DllImport("DwmApi")] //System.Runtime.InteropServices
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, int[] attrValue, int attrSize);

        protected override void OnHandleCreated(EventArgs e)
        {
            if (DwmSetWindowAttribute(Handle, 19, new[] { 1 }, 4) != 0)
                DwmSetWindowAttribute(Handle, 20, new[] { 1 }, 4);
        }
        ////////////////////////////////////////////////////////////////////// Lord Save my Eyes
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainform));
            this.maintoolstrip = new System.Windows.Forms.ToolStrip();
            this.toolstripfile = new System.Windows.Forms.ToolStripDropDownButton();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.tag_cache_folder_browser = new System.Windows.Forms.FolderBrowserDialog();
            this.debug_output = new System.Windows.Forms.TextBox();
            this.loaded_cache_string = new System.Windows.Forms.TextBox();
            this.shitfix = new System.Windows.Forms.TextBox();
            this.tag_tree = new System.Windows.Forms.TreeView();
            this.tag_tree_image_list = new System.Windows.Forms.ImageList(this.components);
            this.CacheLoadPBar = new System.Windows.Forms.ProgressBar();
            this.TagViewToolStrip = new System.Windows.Forms.ToolStrip();
            this.TagViewPanel = new System.Windows.Forms.Panel();
            this.tagStatus = new System.Windows.Forms.Label();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.TagViewTSLoadedTag = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.maintoolstrip.SuspendLayout();
            this.TagViewPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // maintoolstrip
            // 
            this.maintoolstrip.BackColor = System.Drawing.Color.DarkOrange;
            this.maintoolstrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.maintoolstrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolstripfile,
            this.toolStripButton1,
            this.toolStripButton2});
            this.maintoolstrip.Location = new System.Drawing.Point(0, 0);
            this.maintoolstrip.Name = "maintoolstrip";
            this.maintoolstrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.maintoolstrip.Size = new System.Drawing.Size(1449, 25);
            this.maintoolstrip.TabIndex = 0;
            this.maintoolstrip.Text = "toolStrip1";
            this.maintoolstrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.maintoolstrip_ItemClicked);
            // 
            // toolstripfile
            // 
            this.toolstripfile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolstripfile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.toolstripfile.Image = ((System.Drawing.Image)(resources.GetObject("toolstripfile.Image")));
            this.toolstripfile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolstripfile.Name = "toolstripfile";
            this.toolstripfile.Size = new System.Drawing.Size(38, 22);
            this.toolstripfile.Text = "File";
            this.toolstripfile.Click += new System.EventHandler(this.toolstripfile_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.BackColor = System.Drawing.Color.DarkOrange;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(92, 22);
            this.toolStripButton1.Text = "Renderdoc CSV";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(71, 22);
            this.toolStripButton2.Text = "Export Tags";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // tag_cache_folder_browser
            // 
            this.tag_cache_folder_browser.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.tag_cache_folder_browser.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // debug_output
            // 
            this.debug_output.AcceptsReturn = true;
            this.debug_output.AcceptsTab = true;
            this.debug_output.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.debug_output.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.debug_output.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debug_output.ForeColor = System.Drawing.Color.LightGray;
            this.debug_output.Location = new System.Drawing.Point(323, 590);
            this.debug_output.Multiline = true;
            this.debug_output.Name = "debug_output";
            this.debug_output.ReadOnly = true;
            this.debug_output.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.debug_output.Size = new System.Drawing.Size(1123, 128);
            this.debug_output.TabIndex = 1;
            this.debug_output.TextChanged += new System.EventHandler(this.debug_output_TextChanged);
            // 
            // loaded_cache_string
            // 
            this.loaded_cache_string.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.loaded_cache_string.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.loaded_cache_string.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loaded_cache_string.ForeColor = System.Drawing.Color.LightGray;
            this.loaded_cache_string.Location = new System.Drawing.Point(323, 569);
            this.loaded_cache_string.Name = "loaded_cache_string";
            this.loaded_cache_string.ReadOnly = true;
            this.loaded_cache_string.Size = new System.Drawing.Size(750, 21);
            this.loaded_cache_string.TabIndex = 2;
            this.loaded_cache_string.Text = "No Tag Cache Currently Loaded";
            this.loaded_cache_string.WordWrap = false;
            this.loaded_cache_string.TextChanged += new System.EventHandler(this.loaded_cache_string_TextChanged);
            // 
            // shitfix
            // 
            this.shitfix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.shitfix.Enabled = false;
            this.shitfix.Location = new System.Drawing.Point(-200, 0);
            this.shitfix.Name = "shitfix";
            this.shitfix.ReadOnly = true;
            this.shitfix.Size = new System.Drawing.Size(100, 20);
            this.shitfix.TabIndex = 4;
            this.shitfix.TabStop = false;
            this.shitfix.Visible = false;
            // 
            // tag_tree
            // 
            this.tag_tree.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tag_tree.Dock = System.Windows.Forms.DockStyle.Left;
            this.tag_tree.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tag_tree.ForeColor = System.Drawing.Color.LightGray;
            this.tag_tree.FullRowSelect = true;
            this.tag_tree.HideSelection = false;
            this.tag_tree.ImageIndex = 0;
            this.tag_tree.ImageList = this.tag_tree_image_list;
            this.tag_tree.Location = new System.Drawing.Point(0, 25);
            this.tag_tree.Name = "tag_tree";
            this.tag_tree.SelectedImageIndex = 1;
            this.tag_tree.Size = new System.Drawing.Size(317, 688);
            this.tag_tree.TabIndex = 5;
            this.tag_tree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tag_tree_AfterSelect);
            // 
            // tag_tree_image_list
            // 
            this.tag_tree_image_list.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("tag_tree_image_list.ImageStream")));
            this.tag_tree_image_list.TransparentColor = System.Drawing.Color.Transparent;
            this.tag_tree_image_list.Images.SetKeyName(0, "sapien_203.ico");
            this.tag_tree_image_list.Images.SetKeyName(1, "sapien_201.ico");
            this.tag_tree_image_list.Images.SetKeyName(2, "sapien_202.ico");
            this.tag_tree_image_list.Images.SetKeyName(3, "sapien_234.ico");
            this.tag_tree_image_list.Images.SetKeyName(4, "sapien_248.ico");
            // 
            // CacheLoadPBar
            // 
            this.CacheLoadPBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CacheLoadPBar.Location = new System.Drawing.Point(1268, 574);
            this.CacheLoadPBar.Name = "CacheLoadPBar";
            this.CacheLoadPBar.Size = new System.Drawing.Size(190, 13);
            this.CacheLoadPBar.TabIndex = 6;
            this.CacheLoadPBar.Click += new System.EventHandler(this.CacheLoadPBar_Click);
            // 
            // TagViewToolStrip
            // 
            this.TagViewToolStrip.BackColor = System.Drawing.SystemColors.ControlDark;
            this.TagViewToolStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TagViewToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.TagViewToolStrip.Location = new System.Drawing.Point(0, 0);
            this.TagViewToolStrip.Name = "TagViewToolStrip";
            this.TagViewToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.TagViewToolStrip.Size = new System.Drawing.Size(1122, 25);
            this.TagViewToolStrip.TabIndex = 0;
            this.TagViewToolStrip.Text = "TagViewToolStrip";
            this.TagViewToolStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.TagViewToolStrip_ItemClicked);
            // 
            // TagViewPanel
            // 
            this.TagViewPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TagViewPanel.AutoScroll = true;
            this.TagViewPanel.AutoSize = true;
            this.TagViewPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TagViewPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TagViewPanel.Controls.Add(this.comboBox1);
            this.TagViewPanel.Controls.Add(this.TagViewTSLoadedTag);
            this.TagViewPanel.Controls.Add(this.TagViewToolStrip);
            this.TagViewPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TagViewPanel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.TagViewPanel.Location = new System.Drawing.Point(323, 25);
            this.TagViewPanel.Margin = new System.Windows.Forms.Padding(0);
            this.TagViewPanel.Name = "TagViewPanel";
            this.TagViewPanel.Size = new System.Drawing.Size(1126, 540);
            this.TagViewPanel.TabIndex = 7;
            this.TagViewPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.TagViewPanel_Paint);
            // 
            // tagStatus
            // 
            this.tagStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tagStatus.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.tagStatus.Location = new System.Drawing.Point(1147, 574);
            this.tagStatus.Name = "tagStatus";
            this.tagStatus.Size = new System.Drawing.Size(115, 13);
            this.tagStatus.TabIndex = 8;
            this.tagStatus.Text = "0/0";
            this.tagStatus.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.tagStatus.Click += new System.EventHandler(this.tagStatus_Click);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(13, 22);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // TagViewTSLoadedTag
            // 
            this.TagViewTSLoadedTag.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TagViewTSLoadedTag.ForeColor = System.Drawing.Color.LightGray;
            this.TagViewTSLoadedTag.Location = new System.Drawing.Point(0, 0);
            this.TagViewTSLoadedTag.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TagViewTSLoadedTag.Name = "TagViewTSLoadedTag";
            this.TagViewTSLoadedTag.ReadOnly = true;
            this.TagViewTSLoadedTag.Size = new System.Drawing.Size(219, 21);
            this.TagViewTSLoadedTag.TabIndex = 1;
            this.TagViewTSLoadedTag.Text = "No Tag Loaded\r\n";
            this.TagViewTSLoadedTag.TextChanged += new System.EventHandler(this.TagViewTSLoadedTag_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.comboBox1.ForeColor = System.Drawing.Color.LightGray;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Meta Viewer",
            "Raw Viewer",
            "Hex Viewer"});
            this.comboBox1.Location = new System.Drawing.Point(234, -2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Text = "Meta Viewer";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // mainform
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1449, 713);
            this.Controls.Add(this.tagStatus);
            this.Controls.Add(this.TagViewPanel);
            this.Controls.Add(this.CacheLoadPBar);
            this.Controls.Add(this.tag_tree);
            this.Controls.Add(this.shitfix);
            this.Controls.Add(this.loaded_cache_string);
            this.Controls.Add(this.debug_output);
            this.Controls.Add(this.maintoolstrip);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainform";
            this.Text = "Blob Viewer";
            this.Load += new System.EventHandler(this.mainform_Load);
            this.maintoolstrip.ResumeLayout(false);
            this.maintoolstrip.PerformLayout();
            this.TagViewPanel.ResumeLayout(false);
            this.TagViewPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip maintoolstrip;
        private System.Windows.Forms.ToolStripDropDownButton toolstripfile;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog tag_cache_folder_browser;
        public System.Windows.Forms.TextBox debug_output;
        public System.Windows.Forms.TextBox loaded_cache_string;
        public System.Windows.Forms.TextBox shitfix;
        public System.Windows.Forms.TreeView tag_tree;
        public System.Windows.Forms.ImageList tag_tree_image_list;
        private System.Windows.Forms.ToolStrip TagViewToolStrip;
        private System.Windows.Forms.Panel TagViewPanel;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        public System.Windows.Forms.ProgressBar CacheLoadPBar;
        public System.Windows.Forms.Label tagStatus;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox TagViewTSLoadedTag;
    }
}

