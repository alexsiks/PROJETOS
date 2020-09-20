using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class FRM_1 : Form
    {
        public FRM_1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LB_1_Click(object sender, EventArgs e)
        {

        }

        private void BT_1_Click(object sender, EventArgs e)
        {
            LB_1.Text = TXB_1.Text;
        }

        private void TXB_1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
