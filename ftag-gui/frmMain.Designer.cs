namespace ftag_gui
{
    partial class frmMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.bFolder = new System.Windows.Forms.Button();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tvTags = new System.Windows.Forms.TreeView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.상위폴더열기OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.상위폴더열기PToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bOpen = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lvRelation = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label7 = new System.Windows.Forms.Label();
            this.lvRank = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvTags = new System.Windows.Forms.ListView();
            this.label6 = new System.Windows.Forms.Label();
            this.bSave = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTags = new System.Windows.Forms.TextBox();
            this.tbFullPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.bGrouping = new System.Windows.Forms.Button();
            this.tbStagingTags = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lvGroupList = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbGroupName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lbStagingTags = new System.Windows.Forms.ListBox();
            this.bGroupLeft = new System.Windows.Forms.Button();
            this.bGroupRight = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.lbGroupPossible = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bDeleteTag = new System.Windows.Forms.Button();
            this.tbDeleteTag = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bRenameTag = new System.Windows.Forms.Button();
            this.tbRenameNewTag = new System.Windows.Forms.TextBox();
            this.tbRenameOldTag = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.bExtraction = new System.Windows.Forms.Button();
            this.tbExtractionSubFolder = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bFolderMerge = new System.Windows.Forms.Button();
            this.tbFolderMergeSubFolder = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lvSearch = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbSearch = new System.Windows.Forms.ComboBox();
            this.bSearch = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.lvMove = new System.Windows.Forms.ListView();
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bMove = new System.Windows.Forms.Button();
            this.tbMove = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage9.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bFolder
            // 
            this.bFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bFolder.Location = new System.Drawing.Point(1277, 13);
            this.bFolder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bFolder.Name = "bFolder";
            this.bFolder.Size = new System.Drawing.Size(110, 24);
            this.bFolder.TabIndex = 13;
            this.bFolder.Text = "Folder";
            this.bFolder.UseVisualStyleBackColor = true;
            this.bFolder.Click += new System.EventHandler(this.bFolder_Click);
            // 
            // tbPath
            // 
            this.tbPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPath.Location = new System.Drawing.Point(127, 14);
            this.tbPath.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(1144, 23);
            this.tbPath.TabIndex = 12;
            this.tbPath.Text = "F:\\Game\\Skyrim\\Mods\\Pakage\\Pack1\\Tmp";
            // 
            // tvTags
            // 
            this.tvTags.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tvTags.ContextMenuStrip = this.contextMenuStrip1;
            this.tvTags.FullRowSelect = true;
            this.tvTags.Location = new System.Drawing.Point(12, 45);
            this.tvTags.Name = "tvTags";
            this.tvTags.Size = new System.Drawing.Size(352, 406);
            this.tvTags.TabIndex = 14;
            this.tvTags.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvTags_AfterSelect);
            this.tvTags.DoubleClick += new System.EventHandler(this.tvTags_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.상위폴더열기OToolStripMenuItem,
            this.상위폴더열기PToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(170, 48);
            // 
            // 상위폴더열기OToolStripMenuItem
            // 
            this.상위폴더열기OToolStripMenuItem.Name = "상위폴더열기OToolStripMenuItem";
            this.상위폴더열기OToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.상위폴더열기OToolStripMenuItem.Text = "열기(&O)";
            this.상위폴더열기OToolStripMenuItem.Click += new System.EventHandler(this.열기OToolStripMenuItem_Click);
            // 
            // 상위폴더열기PToolStripMenuItem
            // 
            this.상위폴더열기PToolStripMenuItem.Name = "상위폴더열기PToolStripMenuItem";
            this.상위폴더열기PToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.상위폴더열기PToolStripMenuItem.Text = "상위 폴더 열기(&P)";
            this.상위폴더열기PToolStripMenuItem.Click += new System.EventHandler(this.상위폴더열기PToolStripMenuItem_Click);
            // 
            // bOpen
            // 
            this.bOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bOpen.Location = new System.Drawing.Point(1393, 13);
            this.bOpen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bOpen.Name = "bOpen";
            this.bOpen.Size = new System.Drawing.Size(110, 24);
            this.bOpen.TabIndex = 15;
            this.bOpen.Text = "Open";
            this.bOpen.UseVisualStyleBackColor = true;
            this.bOpen.Click += new System.EventHandler(this.bOpen_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(370, 45);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1133, 406);
            this.tabControl1.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lvRelation);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.lvRank);
            this.tabPage1.Controls.Add(this.lvTags);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.bSave);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.tbTags);
            this.tabPage1.Controls.Add(this.tbFullPath);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1125, 378);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "View";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lvRelation
            // 
            this.lvRelation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvRelation.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5});
            this.lvRelation.FullRowSelect = true;
            this.lvRelation.GridLines = true;
            this.lvRelation.Location = new System.Drawing.Point(481, 93);
            this.lvRelation.MultiSelect = false;
            this.lvRelation.Name = "lvRelation";
            this.lvRelation.Size = new System.Drawing.Size(638, 279);
            this.lvRelation.TabIndex = 11;
            this.lvRelation.UseCompatibleStateImageBehavior = false;
            this.lvRelation.View = System.Windows.Forms.View.Details;
            this.lvRelation.DoubleClick += new System.EventHandler(this.lvRelation_DoubleClick);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Name";
            this.columnHeader4.Width = 287;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Tags";
            this.columnHeader5.Width = 319;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(478, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Tags Relation:";
            // 
            // lvRank
            // 
            this.lvRank.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lvRank.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvRank.FullRowSelect = true;
            this.lvRank.GridLines = true;
            this.lvRank.Location = new System.Drawing.Point(233, 93);
            this.lvRank.Name = "lvRank";
            this.lvRank.Size = new System.Drawing.Size(241, 279);
            this.lvRank.TabIndex = 9;
            this.lvRank.UseCompatibleStateImageBehavior = false;
            this.lvRank.View = System.Windows.Forms.View.Details;
            this.lvRank.SelectedIndexChanged += new System.EventHandler(this.lvRank_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Rank";
            this.columnHeader1.Width = 48;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tag";
            this.columnHeader2.Width = 115;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Count";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader3.Width = 53;
            // 
            // lvTags
            // 
            this.lvTags.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lvTags.Location = new System.Drawing.Point(82, 75);
            this.lvTags.Name = "lvTags";
            this.lvTags.Size = new System.Drawing.Size(145, 297);
            this.lvTags.TabIndex = 8;
            this.lvTags.UseCompatibleStateImageBehavior = false;
            this.lvTags.View = System.Windows.Forms.View.Tile;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(230, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Tags Rank:";
            // 
            // bSave
            // 
            this.bSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bSave.Enabled = false;
            this.bSave.Location = new System.Drawing.Point(972, 41);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(136, 23);
            this.bSave.TabIndex = 6;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tags List: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tags: ";
            // 
            // tbTags
            // 
            this.tbTags.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTags.Location = new System.Drawing.Point(82, 41);
            this.tbTags.Name = "tbTags";
            this.tbTags.Size = new System.Drawing.Size(884, 23);
            this.tbTags.TabIndex = 2;
            this.tbTags.TextChanged += new System.EventHandler(this.tbTags_TextChanged);
            this.tbTags.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbTags_KeyDown);
            // 
            // tbFullPath
            // 
            this.tbFullPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFullPath.Location = new System.Drawing.Point(82, 12);
            this.tbFullPath.Name = "tbFullPath";
            this.tbFullPath.ReadOnly = true;
            this.tbFullPath.Size = new System.Drawing.Size(1026, 23);
            this.tbFullPath.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "FullPath: ";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.tabControl2);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1125, 378);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Manage";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Controls.Add(this.tabPage7);
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Controls.Add(this.tabPage9);
            this.tabControl2.Controls.Add(this.tabPage6);
            this.tabControl2.Location = new System.Drawing.Point(6, 6);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1116, 366);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.bGrouping);
            this.tabPage5.Controls.Add(this.tbStagingTags);
            this.tabPage5.Controls.Add(this.label12);
            this.tabPage5.Controls.Add(this.label11);
            this.tabPage5.Controls.Add(this.lvGroupList);
            this.tabPage5.Controls.Add(this.tbGroupName);
            this.tabPage5.Controls.Add(this.label10);
            this.tabPage5.Controls.Add(this.lbStagingTags);
            this.tabPage5.Controls.Add(this.bGroupLeft);
            this.tabPage5.Controls.Add(this.bGroupRight);
            this.tabPage5.Controls.Add(this.label9);
            this.tabPage5.Controls.Add(this.lbGroupPossible);
            this.tabPage5.Controls.Add(this.label8);
            this.tabPage5.Location = new System.Drawing.Point(4, 24);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1108, 338);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Group";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // bGrouping
            // 
            this.bGrouping.Enabled = false;
            this.bGrouping.Location = new System.Drawing.Point(639, 89);
            this.bGrouping.Name = "bGrouping";
            this.bGrouping.Size = new System.Drawing.Size(118, 31);
            this.bGrouping.TabIndex = 25;
            this.bGrouping.Text = "New or Modify";
            this.bGrouping.UseVisualStyleBackColor = true;
            this.bGrouping.Click += new System.EventHandler(this.bGrouping_Click);
            // 
            // tbStagingTags
            // 
            this.tbStagingTags.Location = new System.Drawing.Point(429, 60);
            this.tbStagingTags.Name = "tbStagingTags";
            this.tbStagingTags.ReadOnly = true;
            this.tbStagingTags.Size = new System.Drawing.Size(325, 23);
            this.tbStagingTags.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(340, 63);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 15);
            this.label12.TabIndex = 23;
            this.label12.Text = "Staging Tags: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(760, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 15);
            this.label11.TabIndex = 22;
            this.label11.Text = "Group List: ";
            // 
            // lvGroupList
            // 
            this.lvGroupList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvGroupList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7});
            this.lvGroupList.FullRowSelect = true;
            this.lvGroupList.GridLines = true;
            this.lvGroupList.Location = new System.Drawing.Point(763, 33);
            this.lvGroupList.Name = "lvGroupList";
            this.lvGroupList.Size = new System.Drawing.Size(324, 303);
            this.lvGroupList.TabIndex = 21;
            this.lvGroupList.UseCompatibleStateImageBehavior = false;
            this.lvGroupList.View = System.Windows.Forms.View.Details;
            this.lvGroupList.DoubleClick += new System.EventHandler(this.lvGroupList_DoubleClick);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Group Name";
            this.columnHeader6.Width = 90;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Tags";
            this.columnHeader7.Width = 198;
            // 
            // tbGroupName
            // 
            this.tbGroupName.Enabled = false;
            this.tbGroupName.Location = new System.Drawing.Point(429, 33);
            this.tbGroupName.Name = "tbGroupName";
            this.tbGroupName.Size = new System.Drawing.Size(325, 23);
            this.tbGroupName.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(340, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 15);
            this.label10.TabIndex = 19;
            this.label10.Text = "Group Name: ";
            // 
            // lbStagingTags
            // 
            this.lbStagingTags.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbStagingTags.FormattingEnabled = true;
            this.lbStagingTags.ItemHeight = 15;
            this.lbStagingTags.Location = new System.Drawing.Point(200, 33);
            this.lbStagingTags.Name = "lbStagingTags";
            this.lbStagingTags.Size = new System.Drawing.Size(124, 289);
            this.lbStagingTags.TabIndex = 18;
            this.lbStagingTags.SelectedIndexChanged += new System.EventHandler(this.lbStagingTags_SelectedIndexChanged);
            // 
            // bGroupLeft
            // 
            this.bGroupLeft.Enabled = false;
            this.bGroupLeft.Location = new System.Drawing.Point(154, 166);
            this.bGroupLeft.Name = "bGroupLeft";
            this.bGroupLeft.Size = new System.Drawing.Size(40, 29);
            this.bGroupLeft.TabIndex = 17;
            this.bGroupLeft.Text = "<-";
            this.bGroupLeft.UseVisualStyleBackColor = true;
            this.bGroupLeft.Click += new System.EventHandler(this.bGroupLeft_Click);
            // 
            // bGroupRight
            // 
            this.bGroupRight.Enabled = false;
            this.bGroupRight.Location = new System.Drawing.Point(154, 131);
            this.bGroupRight.Name = "bGroupRight";
            this.bGroupRight.Size = new System.Drawing.Size(40, 29);
            this.bGroupRight.TabIndex = 16;
            this.bGroupRight.Text = "->";
            this.bGroupRight.UseVisualStyleBackColor = true;
            this.bGroupRight.Click += new System.EventHandler(this.bGroupRight_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(197, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 15);
            this.label9.TabIndex = 15;
            this.label9.Text = "Staging Tags:";
            // 
            // lbGroupPossible
            // 
            this.lbGroupPossible.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbGroupPossible.FormattingEnabled = true;
            this.lbGroupPossible.ItemHeight = 15;
            this.lbGroupPossible.Location = new System.Drawing.Point(24, 33);
            this.lbGroupPossible.Name = "lbGroupPossible";
            this.lbGroupPossible.Size = new System.Drawing.Size(124, 289);
            this.lbGroupPossible.TabIndex = 14;
            this.lbGroupPossible.SelectedIndexChanged += new System.EventHandler(this.lbGroupPossible_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 15);
            this.label8.TabIndex = 13;
            this.label8.Text = "Grouping Possible:";
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.label17);
            this.tabPage7.Controls.Add(this.groupBox2);
            this.tabPage7.Controls.Add(this.groupBox1);
            this.tabPage7.Location = new System.Drawing.Point(4, 24);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(1108, 338);
            this.tabPage7.TabIndex = 5;
            this.tabPage7.Text = "Tag";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label17.ForeColor = System.Drawing.Color.Red;
            this.label17.Location = new System.Drawing.Point(380, 46);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(278, 20);
            this.label17.TabIndex = 2;
            this.label17.Text = "Danger! Backup \'.ftag\' file before run.";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bDeleteTag);
            this.groupBox2.Controls.Add(this.tbDeleteTag);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Location = new System.Drawing.Point(543, 130);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(432, 114);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Delete Tag";
            // 
            // bDeleteTag
            // 
            this.bDeleteTag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bDeleteTag.Location = new System.Drawing.Point(305, 48);
            this.bDeleteTag.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bDeleteTag.Name = "bDeleteTag";
            this.bDeleteTag.Size = new System.Drawing.Size(110, 23);
            this.bDeleteTag.TabIndex = 15;
            this.bDeleteTag.Text = "Delete";
            this.bDeleteTag.UseVisualStyleBackColor = true;
            this.bDeleteTag.Click += new System.EventHandler(this.bDeleteTag_Click);
            // 
            // tbDeleteTag
            // 
            this.tbDeleteTag.Location = new System.Drawing.Point(99, 48);
            this.tbDeleteTag.Name = "tbDeleteTag";
            this.tbDeleteTag.Size = new System.Drawing.Size(200, 23);
            this.tbDeleteTag.TabIndex = 4;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(60, 51);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(33, 15);
            this.label16.TabIndex = 3;
            this.label16.Text = "Tag: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bRenameTag);
            this.groupBox1.Controls.Add(this.tbRenameNewTag);
            this.groupBox1.Controls.Add(this.tbRenameOldTag);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Location = new System.Drawing.Point(89, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(432, 114);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rename Tag";
            // 
            // bRenameTag
            // 
            this.bRenameTag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bRenameTag.Location = new System.Drawing.Point(305, 36);
            this.bRenameTag.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bRenameTag.Name = "bRenameTag";
            this.bRenameTag.Size = new System.Drawing.Size(110, 59);
            this.bRenameTag.TabIndex = 14;
            this.bRenameTag.Text = "Rename";
            this.bRenameTag.UseVisualStyleBackColor = true;
            this.bRenameTag.Click += new System.EventHandler(this.bRenameTag_Click);
            // 
            // tbRenameNewTag
            // 
            this.tbRenameNewTag.Location = new System.Drawing.Point(99, 72);
            this.tbRenameNewTag.Name = "tbRenameNewTag";
            this.tbRenameNewTag.Size = new System.Drawing.Size(200, 23);
            this.tbRenameNewTag.TabIndex = 3;
            // 
            // tbRenameOldTag
            // 
            this.tbRenameOldTag.Location = new System.Drawing.Point(99, 36);
            this.tbRenameOldTag.Name = "tbRenameOldTag";
            this.tbRenameOldTag.Size = new System.Drawing.Size(200, 23);
            this.tbRenameOldTag.TabIndex = 2;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(36, 75);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 15);
            this.label15.TabIndex = 1;
            this.label15.Text = "NewTag: ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(41, 39);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 15);
            this.label14.TabIndex = 0;
            this.label14.Text = "OldTag: ";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1108, 338);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "Folder";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.bExtraction);
            this.groupBox4.Controls.Add(this.tbExtractionSubFolder);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Location = new System.Drawing.Point(73, 168);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(601, 114);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Extraction";
            // 
            // bExtraction
            // 
            this.bExtraction.Location = new System.Drawing.Point(484, 52);
            this.bExtraction.Name = "bExtraction";
            this.bExtraction.Size = new System.Drawing.Size(90, 23);
            this.bExtraction.TabIndex = 2;
            this.bExtraction.Text = "Extract";
            this.bExtraction.UseVisualStyleBackColor = true;
            this.bExtraction.Click += new System.EventHandler(this.bExtraction_Click);
            // 
            // tbExtractionSubFolder
            // 
            this.tbExtractionSubFolder.Location = new System.Drawing.Point(117, 52);
            this.tbExtractionSubFolder.Name = "tbExtractionSubFolder";
            this.tbExtractionSubFolder.Size = new System.Drawing.Size(361, 23);
            this.tbExtractionSubFolder.TabIndex = 1;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(39, 56);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(72, 15);
            this.label20.TabIndex = 0;
            this.label20.Text = "Sub Folder: ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bFolderMerge);
            this.groupBox3.Controls.Add(this.tbFolderMergeSubFolder);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Location = new System.Drawing.Point(73, 48);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(601, 114);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Folder Merge";
            // 
            // bFolderMerge
            // 
            this.bFolderMerge.Location = new System.Drawing.Point(484, 51);
            this.bFolderMerge.Name = "bFolderMerge";
            this.bFolderMerge.Size = new System.Drawing.Size(90, 23);
            this.bFolderMerge.TabIndex = 5;
            this.bFolderMerge.Text = "Merge";
            this.bFolderMerge.UseVisualStyleBackColor = true;
            this.bFolderMerge.Click += new System.EventHandler(this.bFolderMerge_Click);
            // 
            // tbFolderMergeSubFolder
            // 
            this.tbFolderMergeSubFolder.Location = new System.Drawing.Point(117, 51);
            this.tbFolderMergeSubFolder.Name = "tbFolderMergeSubFolder";
            this.tbFolderMergeSubFolder.Size = new System.Drawing.Size(361, 23);
            this.tbFolderMergeSubFolder.TabIndex = 4;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(39, 54);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(72, 15);
            this.label21.TabIndex = 3;
            this.label21.Text = "Sub Folder: ";
            // 
            // tabPage9
            // 
            this.tabPage9.Controls.Add(this.label19);
            this.tabPage9.Controls.Add(this.label18);
            this.tabPage9.Controls.Add(this.lvSearch);
            this.tabPage9.Controls.Add(this.cbSearch);
            this.tabPage9.Controls.Add(this.bSearch);
            this.tabPage9.Controls.Add(this.tbSearch);
            this.tabPage9.Location = new System.Drawing.Point(4, 24);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage9.Size = new System.Drawing.Size(1108, 338);
            this.tabPage9.TabIndex = 3;
            this.tabPage9.Text = "Search";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(204, 42);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(93, 15);
            this.label19.TabIndex = 12;
            this.label19.Text = "-<tag>: Exclude";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(115, 42);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(89, 15);
            this.label18.TabIndex = 11;
            this.label18.Text = "<tag>: Include,";
            // 
            // lvSearch
            // 
            this.lvSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvSearch.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.lvSearch.FullRowSelect = true;
            this.lvSearch.GridLines = true;
            this.lvSearch.Location = new System.Drawing.Point(118, 60);
            this.lvSearch.Name = "lvSearch";
            this.lvSearch.Size = new System.Drawing.Size(822, 276);
            this.lvSearch.TabIndex = 10;
            this.lvSearch.UseCompatibleStateImageBehavior = false;
            this.lvSearch.View = System.Windows.Forms.View.Details;
            this.lvSearch.DoubleClick += new System.EventHandler(this.lvSearch_DoubleClick);
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Index";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Subpath";
            this.columnHeader9.Width = 345;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Tags";
            this.columnHeader10.Width = 376;
            // 
            // cbSearch
            // 
            this.cbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearch.FormattingEnabled = true;
            this.cbSearch.Items.AddRange(new object[] {
            "And",
            "Or"});
            this.cbSearch.Location = new System.Drawing.Point(23, 16);
            this.cbSearch.Name = "cbSearch";
            this.cbSearch.Size = new System.Drawing.Size(89, 23);
            this.cbSearch.TabIndex = 8;
            // 
            // bSearch
            // 
            this.bSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bSearch.Enabled = false;
            this.bSearch.Location = new System.Drawing.Point(946, 16);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(136, 23);
            this.bSearch.TabIndex = 7;
            this.bSearch.Text = "Search";
            this.bSearch.UseVisualStyleBackColor = true;
            this.bSearch.Click += new System.EventHandler(this.bSearch_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearch.Enabled = false;
            this.tbSearch.Location = new System.Drawing.Point(118, 16);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(822, 23);
            this.tbSearch.TabIndex = 0;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            this.tbSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSearch_KeyDown);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.lvMove);
            this.tabPage6.Controls.Add(this.bMove);
            this.tabPage6.Controls.Add(this.tbMove);
            this.tabPage6.Location = new System.Drawing.Point(4, 24);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(1108, 338);
            this.tabPage6.TabIndex = 2;
            this.tabPage6.Text = "Move";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // lvMove
            // 
            this.lvMove.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvMove.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13});
            this.lvMove.FullRowSelect = true;
            this.lvMove.GridLines = true;
            this.lvMove.Location = new System.Drawing.Point(118, 16);
            this.lvMove.Name = "lvMove";
            this.lvMove.Size = new System.Drawing.Size(822, 291);
            this.lvMove.TabIndex = 11;
            this.lvMove.UseCompatibleStateImageBehavior = false;
            this.lvMove.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Index";
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Subpath";
            this.columnHeader12.Width = 345;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Tags";
            this.columnHeader13.Width = 376;
            // 
            // bMove
            // 
            this.bMove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bMove.Enabled = false;
            this.bMove.Location = new System.Drawing.Point(810, 309);
            this.bMove.Name = "bMove";
            this.bMove.Size = new System.Drawing.Size(130, 23);
            this.bMove.TabIndex = 1;
            this.bMove.Text = "Move";
            this.bMove.UseVisualStyleBackColor = true;
            this.bMove.Click += new System.EventHandler(this.bMove_Click);
            // 
            // tbMove
            // 
            this.tbMove.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMove.Enabled = false;
            this.tbMove.Location = new System.Drawing.Point(118, 309);
            this.tbMove.Name = "tbMove";
            this.tbMove.Size = new System.Drawing.Size(686, 23);
            this.tbMove.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.pictureBox1);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1125, 378);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Info";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ftag_gui.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(220, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(404, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 11.25F);
            this.label2.Location = new System.Drawing.Point(216, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(316, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Copyright (c) 2018. rollrat. All rights reserved.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 11.25F);
            this.label1.Location = new System.Drawing.Point(216, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "RollRat Software FTag Gui for Windows";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(109, 15);
            this.label13.TabIndex = 17;
            this.label13.Text = "Folder to manage: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(840, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 41);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1515, 463);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.bOpen);
            this.Controls.Add(this.tvTags);
            this.Controls.Add(this.bFolder);
            this.Controls.Add(this.tbPath);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1531, 502);
            this.Name = "frmMain";
            this.Text = "FTag Gui";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage9.ResumeLayout(false);
            this.tabPage9.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bFolder;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TreeView tvTags;
        private System.Windows.Forms.Button bOpen;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbFullPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTags;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 상위폴더열기OToolStripMenuItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView lvTags;
        private System.Windows.Forms.ListView lvRank;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem 상위폴더열기PToolStripMenuItem;
        private System.Windows.Forms.ListView lvRelation;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button bSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.ComboBox cbSearch;
        private System.Windows.Forms.ListView lvSearch;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button bGrouping;
        private System.Windows.Forms.TextBox tbStagingTags;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListView lvGroupList;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.TextBox tbGroupName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox lbStagingTags;
        private System.Windows.Forms.Button bGroupLeft;
        private System.Windows.Forms.Button bGroupRight;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox lbGroupPossible;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button bMove;
        private System.Windows.Forms.TextBox tbMove;
        private System.Windows.Forms.ListView lvMove;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button bDeleteTag;
        private System.Windows.Forms.TextBox tbDeleteTag;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button bRenameTag;
        private System.Windows.Forms.TextBox tbRenameNewTag;
        private System.Windows.Forms.TextBox tbRenameOldTag;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bExtraction;
        private System.Windows.Forms.TextBox tbExtractionSubFolder;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button bFolderMerge;
        private System.Windows.Forms.TextBox tbFolderMergeSubFolder;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button button1;
    }
}

