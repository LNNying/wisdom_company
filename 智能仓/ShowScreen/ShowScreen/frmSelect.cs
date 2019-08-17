using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ShowScreen
{
    public partial class frmSelect : Form
    {
        public frmSelect()
        {
            InitializeComponent();
        }

        public string ScreenIndex
        {
            get;set;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.ScreenIndex = "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.ScreenIndex = "2";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.ScreenIndex = "";
            this.Close();
        }
    }
}
