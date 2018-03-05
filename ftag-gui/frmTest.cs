/***

   Copyright (C) 2017. rollrat. All Rights Reserved.

   03-05-2017:   HyunJun Jeong, Creation

***/

using ftag_new;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ftag_gui
{
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();
        }

        private void frmTest_Load(object sender, EventArgs e)
        {
            TagData x = new TagData(@"C:\rollrat");
            x.GetFolderInfo("asdf");
            //x.SetFolderInfo("mgcpp", new List<string>(new string[] { "asdf", "asd" }));
            x.SetFolderInfo("mgcpp", new List<string>(new string[] { "asdf", "zxcv" }));
            x.GetFolderInfo("mgcpp");
            x.Save();
        }
    }
}
