using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommonInterface
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnThreadProg_Click(object sender, EventArgs e)
        {
            Process.Start("ThreadProgCsharp.exe");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


    }
}
