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
        private string _arguments;
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

        private void btnSynchroProg_Click(object sender, EventArgs e)
        {
            _arguments = textBox1.Text;
            if (_arguments != "")
            {
                Process.Start("SynchroProgCsharp.exe", _arguments);
                label2.Text = "Running...";
            }
            else label2.Text = "No Arguments Entered!";
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }


    }
}
