using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STAJ1ÖDEVİ
{
    public partial class frmYeni : Form
    {
        public frmYeni()
        {
            InitializeComponent();
        }

        //private void label1_Click(object sender, EventArgs e)
        //{
            
            
        //}

        private void frmYeni_Load(object sender, EventArgs e)
        {

        }

        //private void InitializeComponent()
        //{
        //    this.SuspendLayout();

        //    frmYeni


        //    this.ClientSize = new System.Drawing.Size(284, 261);
        //    this.Name = "frmYeni";
        //    this.Load += new System.EventHandler(this.frmYeni_Load_1);
        //    this.ResumeLayout(false);

        //}

        private void frmYeni_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Form1 satis = new Form1();
            satis.Show();
            this.Hide();
        }

        private void frmYeni_Load_2(object sender, EventArgs e)
        {

        }
    }
}
