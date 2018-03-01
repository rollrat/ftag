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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.contextMenuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl3.SuspendLayout();
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
            this.tbPath.Location = new System.Drawing.Point(12, 14);
            this.tbPath.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tbPath.Name = "tbPath";
            this.tbPath.ReadOnly = true;
            this.tbPath.Size = new System.Drawing.Size(1259, 23);
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
            // tabPage3
            // 
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
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Controls.Add(this.tabPage6);
            this.tabControl2.Location = new System.Drawing.Point(6, 6);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1116, 366);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tabControl3);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1108, 338);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "Merge";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 24);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1108, 338);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "Verify";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 24);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(1108, 338);
            this.tabPage6.TabIndex = 2;
            this.tabPage6.Text = "Move";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabControl3
            // 
            this.tabControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl3.Controls.Add(this.tabPage7);
            this.tabControl3.Controls.Add(this.tabPage8);
            this.tabControl3.Location = new System.Drawing.Point(6, 6);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(1096, 326);
            this.tabControl3.TabIndex = 0;
            // 
            // tabPage7
            // 
            this.tabPage7.Location = new System.Drawing.Point(4, 24);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(1088, 298);
            this.tabPage7.TabIndex = 0;
            this.tabPage7.Text = "Folder Merge";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // tabPage8
            // 
            this.tabPage8.Location = new System.Drawing.Point(4, 24);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(1088, 298);
            this.tabPage8.TabIndex = 1;
            this.tabPage8.Text = "Tag Group";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1515, 463);
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
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabControl3.ResumeLayout(false);
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
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage tabPage8;
    }
}

