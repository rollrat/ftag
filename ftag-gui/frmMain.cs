/***

   Copyright (C) 2017. rollrat. All Rights Reserved.

   02-28-2017:   HyunJun Jeong, Creation

***/

using ccgg;
using Etier.IconHelper;
using ftag;
using ftag_new;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ftag_gui
{
    public partial class frmMain : Form
    {
        FileIndexor fx;
        FTagStream stream;
        ImageList smallImageList = new ImageList();
        ImageList largeImageList = new ImageList();
        IconListManager iconListManager;

        public frmMain()
        {
            InitializeComponent();

            smallImageList.ColorDepth = ColorDepth.Depth32Bit;
            largeImageList.ColorDepth = ColorDepth.Depth32Bit;

            smallImageList.ImageSize = new System.Drawing.Size(16, 16);
            largeImageList.ImageSize = new System.Drawing.Size(32, 32);

            smallImageList.Images.Add(FileIcon.FolderIcon.GetFolderIcon(
                FileIcon.FolderIcon.IconSize.Small, 
                FileIcon.FolderIcon.FolderType.Closed));

            iconListManager = new IconListManager(smallImageList, largeImageList);

            tvTags.ImageList = smallImageList;
        }

        private void frmMain_Load(object sender, System.EventArgs e)
        {
            cbSearch.Text = "And";
            Text += " " + FTagVersion.Text;
        }

        #region [--- Folder Open ---]
        private void bFolder_Click(object sender, System.EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                tbPath.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void bOpen_Click(object sender, EventArgs e)
        {
            bFolder.Enabled = false;
            bOpen.Enabled = false;
            bSave.Enabled = true;
            tbPath.Enabled = false;

            stream = new FTagStream(tbPath.Text);

            UpdateTreeview();
        }

        private void UpdateTreeview()
        {
            tvTags.Nodes.Clear();
            callback b = new callback(cb);
            IAsyncResult ar = b.BeginInvoke(tbPath.Text, new AsyncCallback(async_end), null);
        }

        private delegate void callback(string path);
        private void cb(string path)
        {
            fx = new FileIndexor(path);
        }
        private void async_end(IAsyncResult ar)
        {
            this.BeginInvoke((Action)delegate ()
            {
                FileIndexorNode node = fx.GetPathNode(tbPath.Text);
                foreach (FileIndexorNode n in node.Nodes) {
                    make_node(tvTags.Nodes, Path.GetFileName(n.Path.Remove(n.Path.Length - 1)));
                    make_tree(n, tvTags.Nodes[tvTags.Nodes.Count-1]);
                }
                foreach (FileInfo f in new DirectoryInfo(node.Path).GetFiles())
                    make_node(tvTags.Nodes, f.Name);
                color_node(tvTags.Nodes);
                UpdateTagsRank();
                UpdateManage();
                EnableControl();
            });
        }
        private void make_tree(FileIndexorNode fn, TreeNode tn)
        {
            foreach (FileIndexorNode n in fn.Nodes) {
                make_node(tn.Nodes, Path.GetFileName(n.Path.Remove(n.Path.Length - 1)));
                make_tree(n, tn.Nodes[tn.Nodes.Count-1]);
            }
            foreach (FileInfo f in new DirectoryInfo(fn.Path).GetFiles())
                make_node(tn.Nodes, f.Name);
        }
        private void color_node(TreeNodeCollection tnc)
        {
            foreach (TreeNode tn in tnc) {
                string path = tn.FullPath.Replace('\\', '/');
                if (stream.Contains(path)) tn.ForeColor = Color.Green;
                else tn.ForeColor = Color.Red;
                if (tn.Nodes != null && tn.Nodes.Count > 0)
                    color_node(tn.Nodes);
            }
        }
        private void make_node(TreeNodeCollection tnc, string path)
        {
            TreeNode tn = new TreeNode(path);
            tnc.Add(tn);
            string fullpath = Path.Combine(tbPath.Text, tn.FullPath);
            if (File.Exists(fullpath)) {
                int index = iconListManager.AddFileIcon(fullpath);
                tn.ImageIndex = index;
                tn.SelectedImageIndex = index;
            } else {
                tn.ImageIndex = 0;
            }
        }

        private void EnableControl()
        {
            Control[] control = {
                bGrouping, tbGroupName,
                tbSearch, bSearch,
                tbMove, bMove
            };
            foreach (Control obj in control)
                obj.Enabled = true;
        }
        #endregion

        #region [--- View Tab ---]
        private void tvTags_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (tvTags.SelectedNode != null)
            {
                string path = tvTags.SelectedNode.FullPath.Replace('\\', '/');
                tbFolderMergeSubFolder.Text = path;
                tbExtractionSubFolder.Text = path;
                tbFullPath.Text = Path.Combine(tbPath.Text, tvTags.SelectedNode.FullPath);
                tbTags.Text = "";
                if (stream.Contains(path)) {
                    List<string> tags = stream[path];
                    for (int i = 0; i < tags.Count; i++) {
                        tbTags.AppendText(tags[i]);
                        if (i != tags.Count - 1)
                            tbTags.AppendText(", ");
                    }
                    UpdateRelation(tags);
                }
            }
        }

        private void tbTags_TextChanged(object sender, EventArgs e)
        {
            lvTags.Items.Clear();
            foreach (string str in FTagTool.GetTagList(tbTags.Text))
            {
                lvTags.Items.Add(new ListViewItem(str.Trim()));
            }
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            if (tbFullPath.Text == "") return;
            List<string> tags = new List<String>();
            foreach (ListViewItem str in lvTags.Items)
            {
                if (str.Text == "") continue;
                tags.Add(str.Text);
            }
            stream[tvTags.SelectedNode.FullPath.Replace('\\', '/')] = tags;
            if (tags.Count != 0)
                tvTags.SelectedNode.ForeColor = Color.Green;
            else
                tvTags.SelectedNode.ForeColor = Color.Red;
            UpdateTagsRank();
            UpdateManage();
        }

        private void tbTags_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                bSave.PerformClick();
        }

        private void tvTags_DoubleClick(object sender, EventArgs e)
        {
            if (tvTags.SelectedNode != null && tvTags.SelectedNode.Nodes.Count == 0)
            {
                string path = tvTags.SelectedNode.FullPath.Replace('\\', '/');
                Process.Start(Path.Combine(tbPath.Text, tvTags.SelectedNode.FullPath));
            }
        }

        private void 열기OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tvTags.SelectedNode != null)
            {
                string path = tvTags.SelectedNode.FullPath.Replace('\\', '/');
                Process.Start(Path.Combine(tbPath.Text, tvTags.SelectedNode.FullPath));
            }
        }

        private void 상위폴더열기PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tvTags.SelectedNode != null)
            {
                string path = tvTags.SelectedNode.FullPath.Replace('\\', '/');
                Process.Start(Directory.GetParent(Path.Combine(tbPath.Text, tvTags.SelectedNode.FullPath)).FullName);
            }
        }

        private void UpdateTagsRank()
        {
            lvRank.Items.Clear();
            Dictionary<string, int> rank = new Dictionary<string, int>();
            foreach (var tag in stream.GetObjectList())
            {
                foreach (string key in tag.Tags)
                {
                    if (!rank.ContainsKey(key))
                        rank.Add(key, 1);
                    else
                        rank[key] += 1;
                }
            }
            var list = rank.ToList();
            list.Sort((pair1, pair2) => pair2.Value.CompareTo(pair1.Value));
            int index = 1;
            foreach (var pair in list)
            {
                lvRank.Items.Add(new ListViewItem(new string[] { index.ToString(),
                    pair.Key, pair.Value.ToString()}));
                index += 1;
            }
        }

        private void lvRank_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvRank.SelectedItems != null)
            {
                List<string> tags = new List<string>();
                foreach (ListViewItem item in lvRank.SelectedItems)
                    tags.Add(item.SubItems[1].Text);
                UpdateRelation(tags, true);
            }
        }

        List<FTagObject> relation_tag = new List<FTagObject>();
        bool select_stay = false;
        private void UpdateRelation(List<string> tags, bool subset = false)
        {
            if (select_stay) { select_stay = false; return; }
            lvRelation.Items.Clear();
            relation_tag.Clear();
            List<ListViewItem> lvil = new List<ListViewItem>();
            List<FTagObject> tag_list = stream.GetObjectList();
            for (int i = tag_list.Count-1; i >= 0; i--)
            {
                if ((subset == false && tag_list[i].Intersection(tags)) ||
                    (subset == true && tag_list[i].Subset(tags)))
                {
                    relation_tag.Add(tag_list[i]);
                    StringBuilder builder = new StringBuilder();
                    for (int j = 0; j < tag_list[i].Tags.Count; j++) {
                        builder.Append(tag_list[i].Tags[j]);
                        if (j != tag_list[i].Tags.Count - 1)
                            builder.Append(", ");
                    }
                    lvil.Add(new ListViewItem(new string[] {
                        Path.GetFileName(tag_list[i].SubPath),
                        builder.ToString()
                    }));
                }
            }
            lvRelation.Items.AddRange(lvil.ToArray());
        }

        private void lvRelation_DoubleClick(object sender, EventArgs e)
        {
            if (lvRelation.SelectedItems != null)
            {
                TagsViewFromSubPath(relation_tag[lvRelation.Items
                    .IndexOf(lvRelation.SelectedItems[0])].SubPath);
            }
        }

        private void TagsViewFromSubPath(string subpath)
        {
            string[] path = subpath.Split('/');
            TreeNode node = null;
            foreach (TreeNode tn in tvTags.Nodes)
                if (path[0] == tn.Text)
                    node = tn;
            for (int i = 1; i < path.Length; i++)
                foreach (TreeNode tn in node.Nodes)
                    if (path[i] == tn.Text)
                        node = tn;
            tvTags.Focus();
            select_stay = true;
            tvTags.SelectedNode = node;
        }
        #endregion

        #region [--- Manage ---]

        private void UpdateManage()
        {
            UpdateGroup();
        }

        #region [--- Group ---]
        private void UpdateGroup()
        {
            lbGroupPossible.Items.Clear();
            lbStagingTags.Items.Clear();
            lvGroupList.Items.Clear();
            foreach(FTagGroup group in stream.GetGroupList()) {
                StringBuilder builder = new StringBuilder();
                for (int j = 0; j < group.Tags.Count; j++)
                {
                    builder.Append(group.Tags[j]);
                    if (j != group.Tags.Count - 1)
                        builder.Append(", ");
                }
                lvGroupList.Items.Add(new ListViewItem(new string[] {
                        Path.GetFileName(group.Name),
                        builder.ToString()
                    }));
            }
            foreach(string obj in stream.GetTagList()) {
                lbGroupPossible.Items.Add(obj);
            }
            lbGroupPossible.Sorted = true;
        }

        private void bGrouping_Click(object sender, EventArgs e)
        {
            if (tbGroupName.Text == "") return;
            if (stream.ExistGroup(tbGroupName.Text) && !tbGroupName.ReadOnly)
            {
                MessageBox.Show("Already exist group name!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<string> tags = new List<String>();
            foreach (string str in lbStagingTags.Items)
            {
                if (str == "") continue;
                tags.Add(str);
            }

            stream.SetGroup(tbGroupName.Text, tags);
            lbStagingTags.Items.Clear();
            tbStagingTags.Clear();
            tbGroupName.Clear();
            tbGroupName.ReadOnly = false;
            UpdateGroup();
        }

        private void UpdateStaging()
        {
            tbStagingTags.Clear();
            for (int i = 0; i < lbStagingTags.Items.Count; i++)
            {
                tbStagingTags.AppendText((string)lbStagingTags.Items[i]);
                if (i != lbStagingTags.Items.Count - 1)
                    tbStagingTags.AppendText(", ");
            }
        }

        private void lbGroupPossible_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbGroupPossible.SelectedItem != null)
            {
                bGroupRight.Enabled = true;
            }
        }

        private void bGroupRight_Click(object sender, EventArgs e)
        {
            if (lbGroupPossible.SelectedItem != null)
            {
                lbStagingTags.Items.Add((string)lbGroupPossible.SelectedItem);
                lbGroupPossible.Items.Remove(lbGroupPossible.SelectedItem);
                UpdateStaging();
            }
            bGroupRight.Enabled = false;
        }

        private void lbStagingTags_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbStagingTags.SelectedItem != null)
            {
                bGroupLeft.Enabled = true;
            }
        }

        private void bGroupLeft_Click(object sender, EventArgs e)
        {
            if (lbStagingTags.SelectedItem != null)
            {
                lbGroupPossible.Items.Add((string)lbStagingTags.SelectedItem);
                lbStagingTags.Items.Remove(lbStagingTags.SelectedItem);
                UpdateStaging();
            }
            bGroupLeft.Enabled = false;
        }
        
        private void lvGroupList_DoubleClick(object sender, EventArgs e)
        {
            if (lvGroupList.SelectedItems.Count > 0)
            {
                if (lbStagingTags.Items.Count > 0) {
                    MessageBox.Show("Already exist staging member!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (stream.ExistGroup(lvGroupList.SelectedItems[0].Text))
                {
                    foreach (string tag in stream.GetGroup(lvGroupList.SelectedItems[0].Text).Tags) { 
                        lbStagingTags.Items.Add(tag);
                        lbGroupPossible.Items.Remove(tag);
                    }
                    
                    tbGroupName.Text = lvGroupList.SelectedItems[0].Text;
                    tbGroupName.ReadOnly = true;
                    UpdateStaging();
                }
            }
        }
        #endregion

        #region [--- Tag ---]
        private void bRenameTag_Click(object sender, EventArgs e)
        {
            stream.RenameTag(tbRenameOldTag.Text, tbRenameNewTag.Text);
            UpdateTreeview();
        }
        
        private void bDeleteTag_Click(object sender, EventArgs e)
        {
            stream.DeleteTag(tbDeleteTag.Text);
            UpdateTreeview();
        }
        #endregion

        #region [--- Folder ---]
        private void bFolderMerge_Click(object sender, EventArgs e)
        {
            string folder = tbPath.Text;
            if (!folder.EndsWith("\\")) folder += "\\";
            FTagStream target = new FTagStream(folder + tbFolderMergeSubFolder.Text);
            if (!stream.GetVerifier().VerifyMerge(target.GetVerifier()))
            {
                MessageBox.Show("Cannot proceed because some tags of files and groups are not exist in 'SubFolder' fags list. " +
                    "Please edit the tags in 'SubFolder' to continue.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            stream.Merge(target);
            UpdateTreeview();
        }

        private void bExtraction_Click(object sender, EventArgs e)
        {
            stream.Extract(tbExtractionSubFolder.Text);
        }
        #endregion

        #region [--- Search ---]
        private void UpdateSearch()
        {
            List<string> andTags = new List<string>();
            List<string> orTags = new List<string>();
            List<string> notTags = new List<string>();
            
            List<string> tags = stream.GetTagList();

            List<string> nonnot = new List<string>();
            List<string> not = new List<string>();
            foreach (string str in tbSearch.Text.Split(' '))
                if (str != "")
                    if (str[0] == '-')
                        not.Add(str.Substring(1));
                    else
                        nonnot.Add(str);

            foreach (string tag in nonnot)
                if (tags.Contains(tag))
                    if (cbSearch.Text == "And")
                        andTags.Add(tag);
                    else if (cbSearch.Text == "Or")
                        orTags.Add(tag);

            foreach (string tag in not)
                if (tags.Contains(tag))
                    notTags.Add(tag);
            
            int count = 1;
            List<ListViewItem> lvil = new List<ListViewItem>();
            List<ListViewItem> lvil2 = new List<ListViewItem>();
            foreach (FTagObject obj in stream.SearchTag(andTags, orTags, notTags)) {
                StringBuilder builder = new StringBuilder();
                for (int j = 0; j < obj.Tags.Count; j++) {
                    builder.Append(obj.Tags[j]);
                    if (j != obj.Tags.Count - 1)
                        builder.Append(", ");
                }
                lvil.Add(new ListViewItem(new string[] {
                        count.ToString(),
                        obj.SubPath,
                        builder.ToString()
                    }));
                lvil2.Add(new ListViewItem(new string[] {
                        count.ToString(),
                        obj.SubPath,
                        builder.ToString()
                    }));
                count++;
            }
            lvSearch.Items.Clear();
            lvSearch.Items.AddRange(lvil.ToArray());
            lvMove.Items.Clear();
            lvMove.Items.AddRange(lvil2.ToArray());
        }

        private void tbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                bSearch.PerformClick();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            UpdateSearch();
        }

        private void bSearch_Click(object sender, EventArgs e)
        {
            UpdateSearch();
        }

        private void lvSearch_DoubleClick(object sender, EventArgs e)
        {
            if (lvSearch.SelectedItems != null)
            {
                TagsViewFromSubPath(lvSearch.SelectedItems[0].SubItems[1].Text);
            }
        }
        #endregion

        #region [--- Move ---]
        private void bMove_Click(object sender, EventArgs e)
        {
            List<FTagObject> src = stream.GetObjectList();
            List<FTagObject> objs = new List<FTagObject>();
            foreach (ListViewItem lvi in lvSearch.Items)
            {
                foreach (FTagObject obj in src)
                    if (obj.SubPath == lvi.SubItems[1].Text)
                    {
                        objs.Add(obj);
                        break;
                    }
            }
            if (!stream.GetVerifier().VerifyMove(objs, tbMove.Text))
            {
                MessageBox.Show("Verify error! Please check target directory!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            stream.Move(objs, tbMove.Text);
            UpdateTreeview();
            UpdateSearch();
        }
        #endregion

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            // ftag to .json tagfile.
            TagData tag_data = new TagData(@"C:\rollrat\");
            TagStruct tmp = new TagStruct();
            foreach (FTagObject obj in stream.GetObjectList())
            {
                string path = obj.SubPath;
                if (path.EndsWith("/")) continue;
                tmp.Folder[path.Remove(path.LastIndexOf('/'))][path.Substring(path.LastIndexOf('/')+1)].Tags = obj.Tags;
            }
            tag_data.SetTag(tmp);
            tag_data.Save();
        }
    }
}
