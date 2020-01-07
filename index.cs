using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Infrarizer
{
    public partial class frmIndex : Form
    {
        public frmIndex()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void BtnRede_Click(object sender, EventArgs e)
        {
            frmCfgRede frmrede = new frmCfgRede();
            frmrede.Show();
            this.Visible = false;

        }

        private void btnInstaller_Click(object sender, EventArgs e)
        {

        }
    }
}
