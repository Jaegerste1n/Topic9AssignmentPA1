using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Topic9AssignmentPA1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGood_Click(object sender, EventArgs e)
        {
            btnBad.Enabled = false;
            btnGood.Enabled = false;
            btnBad.Visible = false;
            BackColor = Color.DarkGreen;
        }

        private void btnBad_Click(object sender, EventArgs e)
        {
            btnGood.Enabled = false;
            btnBad.Enabled = false;
            btnGood.Visible = false;
            BackColor = Color.DarkRed;
        }
    }
}
