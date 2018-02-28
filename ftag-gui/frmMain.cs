/***

   Copyright (C) 2017. rollrat. All Rights Reserved.

   02-28-2017:   HyunJun Jeong, Creation

***/

using ftag;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ftag_gui
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, System.EventArgs e)
        {
            FTagStream stream = new FTagStream("C:\\rollrat");
            List<string> kkk = new List<string>();
        }
    }
}
