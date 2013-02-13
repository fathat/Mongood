namespace MongoAdmin
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.toolStripContainer2 = new System.Windows.Forms.ToolStripContainer();
            this._PropertyGrid = new System.Windows.Forms.PropertyGrid();
            this.ServerBrowser = new System.Windows.Forms.TreeView();
            this.databaseViewContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newQueryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dropToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dbExplorerIcons = new System.Windows.Forms.ImageList(this.components);
            this._dbToolstrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.addServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._RefreshBtn = new System.Windows.Forms.ToolStripButton();
            this._queryTabControl = new System.Windows.Forms.TabControl();
            this.tabContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllButThisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainToolStrip = new System.Windows.Forms.ToolStrip();
            this._newQueryBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStripContainer2.ContentPanel.SuspendLayout();
            this.toolStripContainer2.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer2.SuspendLayout();
            this.databaseViewContextMenu.SuspendLayout();
            this._dbToolstrip.SuspendLayout();
            this.tabContextMenu.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.mainToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.splitContainer1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(795, 660);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(795, 709);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuStrip);
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.mainToolStrip);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.toolStripContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this._queryTabControl);
            this.splitContainer1.Size = new System.Drawing.Size(795, 660);
            this.splitContainer1.SplitterDistance = 265;
            this.splitContainer1.TabIndex = 0;
            // 
            // toolStripContainer2
            // 
            // 
            // toolStripContainer2.ContentPanel
            // 
            this.toolStripContainer2.ContentPanel.Controls.Add(this._PropertyGrid);
            this.toolStripContainer2.ContentPanel.Controls.Add(this.ServerBrowser);
            this.toolStripContainer2.ContentPanel.Size = new System.Drawing.Size(265, 635);
            this.toolStripContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer2.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer2.Name = "toolStripContainer2";
            this.toolStripContainer2.Size = new System.Drawing.Size(265, 660);
            this.toolStripContainer2.TabIndex = 1;
            this.toolStripContainer2.Text = "toolStripContainer2";
            // 
            // toolStripContainer2.TopToolStripPanel
            // 
            this.toolStripContainer2.TopToolStripPanel.Controls.Add(this._dbToolstrip);
            // 
            // _PropertyGrid
            // 
            this._PropertyGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._PropertyGrid.HelpVisible = false;
            this._PropertyGrid.Location = new System.Drawing.Point(0, 385);
            this._PropertyGrid.Name = "_PropertyGrid";
            this._PropertyGrid.PropertySort = System.Windows.Forms.PropertySort.Alphabetical;
            this._PropertyGrid.Size = new System.Drawing.Size(265, 250);
            this._PropertyGrid.TabIndex = 1;
            this._PropertyGrid.ToolbarVisible = false;
            // 
            // ServerBrowser
            // 
            this.ServerBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ServerBrowser.ContextMenuStrip = this.databaseViewContextMenu;
            this.ServerBrowser.ImageIndex = 0;
            this.ServerBrowser.ImageList = this.dbExplorerIcons;
            this.ServerBrowser.Location = new System.Drawing.Point(0, 0);
            this.ServerBrowser.Name = "ServerBrowser";
            this.ServerBrowser.SelectedImageIndex = 0;
            this.ServerBrowser.Size = new System.Drawing.Size(265, 379);
            this.ServerBrowser.TabIndex = 0;
            this.ServerBrowser.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.OnDatabaseTreeAfterSelect);
            this.ServerBrowser.DoubleClick += new System.EventHandler(this.ServerBrowser_DoubleClick);
            this.ServerBrowser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ServerBrowser_KeyPress);
            this.ServerBrowser.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ServerBrowser_KeyUp);
            // 
            // databaseViewContextMenu
            // 
            this.databaseViewContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newQueryToolStripMenuItem,
            this.disconnectToolStripMenuItem,
            this.dropToolStripMenuItem});
            this.databaseViewContextMenu.Name = "databaseViewContextMenu";
            this.databaseViewContextMenu.Size = new System.Drawing.Size(134, 70);
            // 
            // newQueryToolStripMenuItem
            // 
            this.newQueryToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newQueryToolStripMenuItem.Image")));
            this.newQueryToolStripMenuItem.Name = "newQueryToolStripMenuItem";
            this.newQueryToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.newQueryToolStripMenuItem.Text = "New Query";
            this.newQueryToolStripMenuItem.Click += new System.EventHandler(this.newQueryToolStripMenuItem_Click);
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("disconnectToolStripMenuItem.Image")));
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.disconnectToolStripMenuItem.Text = "Disconnect";
            this.disconnectToolStripMenuItem.Click += new System.EventHandler(this.disconnectToolStripMenuItem_Click);
            // 
            // dropToolStripMenuItem
            // 
            this.dropToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("dropToolStripMenuItem.Image")));
            this.dropToolStripMenuItem.Name = "dropToolStripMenuItem";
            this.dropToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.dropToolStripMenuItem.Text = "Drop";
            this.dropToolStripMenuItem.Click += new System.EventHandler(this.OnDropSelected);
            // 
            // dbExplorerIcons
            // 
            this.dbExplorerIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("dbExplorerIcons.ImageStream")));
            this.dbExplorerIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.dbExplorerIcons.Images.SetKeyName(0, "nfs_unmount.png");
            this.dbExplorerIcons.Images.SetKeyName(1, "database.png");
            this.dbExplorerIcons.Images.SetKeyName(2, "folder_blue.png");
            this.dbExplorerIcons.Images.SetKeyName(3, "folder_open.png");
            // 
            // _dbToolstrip
            // 
            this._dbToolstrip.Dock = System.Windows.Forms.DockStyle.None;
            this._dbToolstrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this._RefreshBtn});
            this._dbToolstrip.Location = new System.Drawing.Point(0, 0);
            this._dbToolstrip.Name = "_dbToolstrip";
            this._dbToolstrip.Size = new System.Drawing.Size(265, 25);
            this._dbToolstrip.Stretch = true;
            this._dbToolstrip.TabIndex = 0;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addServerToolStripMenuItem});
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(81, 22);
            this.toolStripButton1.Text = "Connect";
            // 
            // addServerToolStripMenuItem
            // 
            this.addServerToolStripMenuItem.Name = "addServerToolStripMenuItem";
            this.addServerToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.addServerToolStripMenuItem.Text = "Add Server...";
            this.addServerToolStripMenuItem.Click += new System.EventHandler(this.OnAddServer);
            // 
            // _RefreshBtn
            // 
            this._RefreshBtn.Image = ((System.Drawing.Image)(resources.GetObject("_RefreshBtn.Image")));
            this._RefreshBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._RefreshBtn.Name = "_RefreshBtn";
            this._RefreshBtn.Size = new System.Drawing.Size(66, 22);
            this._RefreshBtn.Text = "Refresh";
            this._RefreshBtn.Click += new System.EventHandler(this.OnRefreshDBClick);
            // 
            // _queryTabControl
            // 
            this._queryTabControl.ContextMenuStrip = this.tabContextMenu;
            this._queryTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this._queryTabControl.Location = new System.Drawing.Point(0, 0);
            this._queryTabControl.Name = "_queryTabControl";
            this._queryTabControl.SelectedIndex = 0;
            this._queryTabControl.Size = new System.Drawing.Size(526, 660);
            this._queryTabControl.TabIndex = 0;
            // 
            // tabContextMenu
            // 
            this.tabContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem,
            this.closeAllButThisToolStripMenuItem,
            this.closeAllToolStripMenuItem});
            this.tabContextMenu.Name = "tabContextMenu";
            this.tabContextMenu.Size = new System.Drawing.Size(167, 70);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.closeToolStripMenuItem.Text = "Close This";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // closeAllButThisToolStripMenuItem
            // 
            this.closeAllButThisToolStripMenuItem.Name = "closeAllButThisToolStripMenuItem";
            this.closeAllButThisToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.closeAllButThisToolStripMenuItem.Text = "Close All But This";
            // 
            // closeAllToolStripMenuItem
            // 
            this.closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
            this.closeAllToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.closeAllToolStripMenuItem.Text = "Close All";
            // 
            // menuStrip
            // 
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(795, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mainToolStrip
            // 
            this.mainToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.mainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._newQueryBtn,
            this.toolStripButton2});
            this.mainToolStrip.Location = new System.Drawing.Point(0, 24);
            this.mainToolStrip.Name = "mainToolStrip";
            this.mainToolStrip.Size = new System.Drawing.Size(795, 25);
            this.mainToolStrip.Stretch = true;
            this.mainToolStrip.TabIndex = 1;
            // 
            // _newQueryBtn
            // 
            this._newQueryBtn.Enabled = false;
            this._newQueryBtn.Image = ((System.Drawing.Image)(resources.GetObject("_newQueryBtn.Image")));
            this._newQueryBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._newQueryBtn.Name = "_newQueryBtn";
            this._newQueryBtn.Size = new System.Drawing.Size(86, 22);
            this._newQueryBtn.Text = "New Query";
            this._newQueryBtn.Click += new System.EventHandler(this.OnNewQuery);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(74, 22);
            this.toolStripButton2.Text = "Dinosaur";
            this.toolStripButton2.Click += new System.EventHandler(this.OnDinosaur);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 709);
            this.Controls.Add(this.toolStripContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "Mongood";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.toolStripContainer2.ContentPanel.ResumeLayout(false);
            this.toolStripContainer2.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer2.TopToolStripPanel.PerformLayout();
            this.toolStripContainer2.ResumeLayout(false);
            this.toolStripContainer2.PerformLayout();
            this.databaseViewContextMenu.ResumeLayout(false);
            this._dbToolstrip.ResumeLayout(false);
            this._dbToolstrip.PerformLayout();
            this.tabContextMenu.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.mainToolStrip.ResumeLayout(false);
            this.mainToolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripContainer toolStripContainer2;
        private System.Windows.Forms.TreeView ServerBrowser;
        private System.Windows.Forms.ToolStrip _dbToolstrip;
        private System.Windows.Forms.ToolStripButton _RefreshBtn;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStrip mainToolStrip;
        private System.Windows.Forms.TabControl _queryTabControl;
        private System.Windows.Forms.ToolStripButton _newQueryBtn;
        private System.Windows.Forms.ImageList dbExplorerIcons;
        private System.Windows.Forms.ContextMenuStrip tabContextMenu;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllButThisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem addServerToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip databaseViewContextMenu;
        private System.Windows.Forms.ToolStripMenuItem newQueryToolStripMenuItem;
        private System.Windows.Forms.PropertyGrid _PropertyGrid;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dropToolStripMenuItem;
    }
}

