using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace STAJ1ÖDEVİ
{
    public partial class frmMüşteriEkle : Form
    {
        public frmMüşteriEkle()
        {
            InitializeComponent();
        }
        //private void txtEmail_Leave(object sender, EventArgs e)
        //{
        //    string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z]*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
        //    if (Regex.IsMatch(txtEmail.Text, pattern))
        //    {

        //        errorProvider1.Clear();
        //    }

        //    else
        //    {
        //        errorProvider1.SetError(this.txtEmail, "");
        //        return;
        //    }

        //}
        SqlConnection baglanti = new SqlConnection("Data Source=NISANUR;Initial Catalog=Stok_Takip;Integrated Security=True");


        private void frmMüşteriEkle_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            int tcuzunluk = txtTc.TextLength;
            isvalid_email(txtEmail.Text);
            if (tcuzunluk == 11)
            {
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("insert into müşteri(tc,adsoyad,telefon,adres,email) values(@tc,@adsoyad,@telefon,@adres,@email)", baglanti);
                    komut.Parameters.AddWithValue("@tc", txtTc.Text);
                    komut.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
                    komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
                    komut.Parameters.AddWithValue("@adres", txtAdres.Text);
                    komut.Parameters.AddWithValue("@email", txtEmail.Text);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Müşteri kaydı eklendi");
                    foreach (Control item in this.Controls)
                    {
                        if (item is TextBox)
                        {
                            item.Text = "";
                        }
                    }
                }

            }
            else
            {
                MessageBox.Show("tc doğru değil");
                txtTc.Clear();
            }
        }

        private void txtTc_TextChanged(object sender, EventArgs e)
        {

        }
        public bool isvalid_email(string email)
        {

            Regex check = new Regex(@"^\w+[\w-\.]+\@\w{5}\.[a-z]{2,3}$");
            bool valid = false;
            valid = check.IsMatch(email);
            if (valid == true)
                return true;
            else
            {
                MessageBox.Show("geçerli bir email girin");
                return false;
            }

       
    }

        private void txtTelefon_TextChanged(object sender, EventArgs e)
       {
            //string telefon = txtTelefon.Text;
            //if (telefon.Length == 11)
            //{
            //    double.telefon = double.Parse(telefon);
            //    txtTelefon.Text = string.Format("{0:(###)#######}", telefon).ToString();

            //}
            //if (txtTelefon.Text.Length > 1)
            //{
            //    txtTelefon.SelectionStart = txtTelefon.Text.Length;
            //    txtTelefon.SelectionLength = 0;

            //}
            string s = txtTelefon.Text;
            if (s.Length == 10)
            {
                double sAsD = double.Parse(s);
                txtTelefon.Text = string.Format("{0:(###)###-####}", sAsD).ToString();
            }
            if (txtTelefon.Text.Length > 1)
            {
                txtTelefon.SelectionStart = txtTelefon.Text.Length;
                txtTelefon.SelectionLength = 0;
            }
        }

        //private void txtTelefon_TextChanged_1(object sender, EventArgs e)
        //{

        //}
        //}
        //private void txtEmail_Leave(object sender, EventArgs e)
        //{


        //}



        //private void txtTc_TextChanged_1(object sender, EventArgs e)
        //{
        //    string tckimlik;
        //    try
        //    {
        //        tckimlik = txtTc.Text;
        //        int index = 0;
        //        int toplam = 0;
        //        foreach (char n in tckimlik)
        //        {
        //            if (index < 10)
        //            {
        //                toplam += Convert.ToInt32(char.ToString(n));
        //            }

        //            index++;


        //        }
        //        if (toplam % 10 == Convert.ToInt32(tckimlik[10].ToString()))
        //        {
        //            MessageBox.Show("geçerli tc kimlik numarası");
        //        }
        //        else
        //        {
        //            MessageBox.Show("geçersiz tc kimlik numarası");
        //        }
        //    }
        //    catch
        //    {
        //        //MessageBox.Show("girdiğiniz tc kimlik numarası 11 haneli değil");
        //    }
        //}
        //}
        //public bool TcDogruMu()
        //{
        //    string kimlikno = txtTc.Text;
        //    kimlikno = kimlikno.Trim();
        //    if (kimlikno.Length != 11)
        //    {
        //        MessageBox.Show("TC Kimlik Numaranızı eksik girdiniz!\nLütfen tekrar deneyin.");
        //        txtTc.Clear();
        //        txtTc.Focus();
        //        return false;
        //    }
        //    int[] sayilar = new int[11];
        //    for (int i = 0; i < kimlikno.Length; i++)
        //    {
        //        sayilar[i] = Int32.Parse(kimlikno[i].ToString());
        //    }
        //    int toplam = 0;
        //    for (int i = 0; i < kimlikno.Length - 1; i++)
        //    {
        //        toplam += sayilar[i];
        //    }
        //    if (toplam.ToString()[1].ToString() == sayilar[10].ToString() & sayilar[10] % 2 == 0)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        MessageBox.Show("Girilen Tc Kimlik No yanlıştır!\nLütfen kontrol ediniz.");
        //        txtTc.Focus();
        //        return false;
        //    }
        //}


    }
    }


