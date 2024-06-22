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
    public partial class frmkullanıcıgirişi : Form
    {
        public frmkullanıcıgirişi()
        {
            InitializeComponent();
            

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmŞifre şifre = new frmŞifre();
            şifre.Show();

        }
        Kullanıcı_Formu k = new Kullanıcı_Formu();
        
        private void button1_Click(object sender, EventArgs e)
        {
            
            k.kullanıcı(txtKullanıcıAdı, txtŞifre);
            //k.kullanıcı.bool
            //if (k.kullanıcı.bool=true)
            //{
            //    this.Hide();
            //}


            //if (txtKullanıcıAdı.Text == "" || txtŞifre.Text == "")
            //MessageBox.Show("boş alan bırakamazsın !");
            
            //frmYeni yeni = new frmYeni();
            //yeni.Show();
            //MessageBox.Show("Hoşgeldiniz");
            
        }





    //}

    //private void btnEkle_Click(object sender, EventArgs e)
    //{
    //    //k.yenikullanıcı(AdSoyadtxt, KullanıcıAdıtxt, Şifretxt, ŞifreTekrartxt, Sorutxt, Cevaptxt, groupBox2);
    //}

    //private void groupBox2_Enter(object sender, EventArgs e)
    //{

    //}

    //private void frmkullanıcıgirişi_Load(object sender, EventArgs e)
    //{

    //}

    //private void AdSoyadtxt_TextChanged(object sender, EventArgs e)
    //{

    //}

    //private void KullanıcıAdıtxt_TextChanged(object sender, EventArgs e)
    //{

    //}

    //private void label3_Click(object sender, EventArgs e)
    //{

    //}

        private void button2_Click(object sender, EventArgs e)
        {
            frmyenikullanıcı yenikullanıcı = new frmyenikullanıcı();
            yenikullanıcı.Show();
        }

        private void groupBox2_Enter_1(object sender, EventArgs e)
        {

        }

        private void txtKullanıcıAdı_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmkullanıcıgirişi_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
    }
