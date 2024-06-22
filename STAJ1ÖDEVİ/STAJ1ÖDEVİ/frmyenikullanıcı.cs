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
    public partial class frmyenikullanıcı : Form
    {
        public frmyenikullanıcı()
        {
            InitializeComponent();
        }

        private void frmyenikullanıcı_Load(object sender, EventArgs e)
        {

        }
        Kullanıcı_Formu k = new Kullanıcı_Formu();

        private void btnEkle_Click(object sender, EventArgs e)
        {
           
            if (AdSoyadtxt.Text != null && AdSoyadtxt.Text != "" && KullanıcıAdıtxt.Text != null && KullanıcıAdıtxt.Text != "" && Şifretxt.Text != null && Şifretxt.Text != "" 
                && ŞifreTekrartxt.Text != null && ŞifreTekrartxt.Text != "" && Sorutxt.Text != null && Sorutxt.Text != "" && Cevaptxt.Text != null && Cevaptxt.Text != "")
            {
               k.yenikullanıcı(AdSoyadtxt, KullanıcıAdıtxt, Şifretxt, ŞifreTekrartxt, Sorutxt, Cevaptxt, groupBox2);
            }
            else
            {
                MessageBox.Show("Bilgileri Doldurunuz !", "yenikullanıcı");
            }
        }
    }
}
