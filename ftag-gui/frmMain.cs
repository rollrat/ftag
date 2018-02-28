/***

   Copyright (C) 2017. rollrat. All Rights Reserved.

   02-28-2017:   HyunJun Jeong, Creation

***/

using ccgg;
using Etier.IconHelper;
using ftag;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
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
        }

        private void bFolder_Click(object sender, System.EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                tbPath.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void bOpen_Click(object sender, EventArgs e)
        {
            stream = new FTagStream(tbPath.Text);

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
                    //tvTags.Nodes.Add(Path.GetFileName(n.Path.Remove(n.Path.Length-1)));
                    make_tree(n, tvTags.Nodes[tvTags.Nodes.Count-1]);
                }
                foreach (FileInfo f in new DirectoryInfo(node.Path).GetFiles())
                    make_node(tvTags.Nodes, f.Name);
                    //tvTags.Nodes.Add(f.Name);
                color_node(tvTags.Nodes);
                UpdateTagsRank();
            });
        }
        private void make_tree(FileIndexorNode fn, TreeNode tn)
        {
            foreach (FileIndexorNode n in fn.Nodes) {
                make_node(tn.Nodes, Path.GetFileName(n.Path.Remove(n.Path.Length - 1)));
                //tn.Nodes.Add(Path.GetFileName(n.Path.Remove(n.Path.Length-1)));
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

        private void tvTags_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (tvTags.SelectedNode != null)
            {
                string path = tvTags.SelectedNode.FullPath.Replace('\\', '/');
                tbFullPath.Text = Path.Combine(tbPath.Text, tvTags.SelectedNode.FullPath);
                tbTags.Text = "";
                if (stream.Contains(path)) {
                    List<string> tags = stream[path];
                    for (int i = 0; i < tags.Count; i++) {
                        tbTags.AppendText(tags[i]);
                        if (i != tags.Count - 1)
                            tbTags.AppendText(", ");
                    }
                }
            }
        }

        private void tbTags_TextChanged(object sender, EventArgs e)
        {
            lvTags.Items.Clear();
            foreach (string str in tbTags.Text.Split(new string[] { "," },
                StringSplitOptions.None))
            {
                lvTags.Items.Add(new ListViewItem(str.Trim()));
            }
        }

        private void bSave_Click(object sender, EventArgs e)
        {
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
        }

        private void tbTags_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                bSave.PerformClick();
        }

        private void tvTags_DoubleClick(object sender, EventArgs e)
        {
            if (tvTags.SelectedNode != null)
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
                Process.Start( Path.Combine(tbPath.Text, tvTags.SelectedNode.FullPath));
            }
        }

        private void UpdateTagsRank()
        {
            Dictionary<string, int> rank = new Dictionary<string, int>();
            foreach (var tag in stream.GetTagList())
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

    }
}
