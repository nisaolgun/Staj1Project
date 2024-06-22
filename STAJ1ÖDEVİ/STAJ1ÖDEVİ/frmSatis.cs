using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace STAJ1ÖDEVİ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); frmYeni yeni = new frmYeni();
            yeni.Hide();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=NISANUR;Initial Catalog=Stok_Takip;Integrated Security=True");
        DataSet daset = new DataSet();

        private void sepetlistele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from sepet ", baglanti);
            adtr.Fill(daset, "sepet");
            dataGridView1.DataSource = daset.Tables["sepet"];
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            baglanti.Close();

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnMüşteriEkleme_Click(object sender, EventArgs e)
        {
            frmMüşteriEkle ekle = new frmMüşteriEkle();
            ekle.Show();
        }

        private void btnMüşteriListeleme_Click(object sender, EventArgs e)
        {
            frmMüşteriListele listele = new frmMüşteriListele();
            listele.Show();

        }

        private void btnÜrünEkleme_Click(object sender, EventArgs e)
        {
            frmÜrünEkle ekle = new frmÜrünEkle();
            ekle.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sepetlistele();
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmKategori kategori = new frmKategori();
            kategori.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmMarka marka = new frmMarka();
            marka.Show();

        }
        private void hesapla()
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select sum(toplamfiyati) from sepet",baglanti);
                

            }
            catch(Exception)
            {

            }
        }

        private void btnÜrünListeleme_Click(object sender, EventArgs e)
        {
            frmÜrünListele listele = new frmÜrünListele();
            listele.Show();

        }

        private void txtTc_TextChanged(object sender, EventArgs e)
        {
//            foreach(Control ctrl in panel1.Controls)
//{
//                if (ctrl is txtTc)
//                {
//                    if ((ctrl as txtTc).Text == "")
//                    {
//                        MessageBox.Show("Lütfen tüm alanları doldurunuz.!.");
//                        break;
//                    }
//                }
//            }
            if (txtTc.Text == "")
            {
                txtAdSoyad.Text = "";
                txtTelefon.Text = "";


            }


            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from satis where tc like '" + txtTc.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtAdSoyad.Text = read["adsoyad"].ToString();
                txtTelefon.Text = read["telefon"].ToString();


            }
            baglanti.Close();


        }

        private void txtBarkodNo_TextChanged(object sender, EventArgs e)
        {
            Temizle();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from satis where barkodno like '" + txtBarkodNo.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtÜrünAdı.Text = read["urunadi"].ToString();
                txtSatışFiyatı.Text = read["satisfiyati"].ToString();
            }
            baglanti.Close();

        }
    
        private void Temizle()
        {
            if (txtBarkodNo.Text == "")
            {
                foreach (Control item in groupBox2.Controls)
                {

                    if (item is TextBox)
                    {


                        if (item != txtMiktari)
                        {
                            item.Text = "";

                        }
                    }
                }
            }
        }
        bool durum;
        private void barkodkontrol()
        {
            durum = true;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from sepet", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while(read.Read())
            {
                if(txtBarkodNo.Text == read["barkodno"].ToString())
                {
                    durum = false;
                }

            }
            baglanti.Close();

        }
        private void btnEkle_Click(object sender, EventArgs e)
        {

            barkodkontrol();
            if(durum==true)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into sepet(tc,adsoyad,telefon,barkodno,urunadi,miktari,satisfiyati,toplamfiyati,tarih) values(@tc,@adsoyad,@telefon,@barkodno,@urunadi,@miktari,@satisfiyati,@toplamfiyati,@tarih)", baglanti);
                komut.Parameters.AddWithValue("@tc", txtTc.Text);
                komut.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
                komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
                komut.Parameters.AddWithValue("@barkodno", txtBarkodNo.Text);
                komut.Parameters.AddWithValue("@urunadi", txtÜrünAdı.Text);
                komut.Parameters.AddWithValue("@miktari", int.Parse(txtMiktari.Text));
                komut.Parameters.AddWithValue("@satisfiyati", double.Parse(txtSatışFiyatı.Text));
                komut.Parameters.AddWithValue("@toplamfiyati", double.Parse(txtToplamFiyatı.Text));
                komut.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
                komut.ExecuteNonQuery();
                baglanti.Close();
            }
            else
            {
                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("update seper miktari=miktari+'"+int.Parse(txtMiktari.Text)+ "'where barkodno='" + txtBarkodNo.Text+"'", baglanti);
                komut2.ExecuteNonQuery();

                SqlCommand komut3 = new SqlCommand("update seper toplamfiyat=miktari*satisfiyati where barkodno='"+txtBarkodNo.Text+"'", baglanti);
                komut3.ExecuteNonQuery();

                baglanti.Close();
            }
           
            txtMiktari.Text = "1";
            daset.Tables["sepet"].Clear();
            sepetlistele();
            Temizle();


        }

        private void txtMiktari_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtToplamFiyatı.Text = (double.Parse(txtMiktari.Text ) * double.Parse(txtSatışFiyatı.Text)).ToString();
            }
            catch(Exception)
            {
                ;
            }
        }

        private void txtSatışFiyatı_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtToplamFiyatı.Text =(double.Parse(txtMiktari.Text) * double.Parse(txtSatışFiyatı.Text)).ToString();
            }
            catch (Exception)
            {
                ;
            }
        }

        private void btnSatışlarıListeleme_Click(object sender, EventArgs e)
        {
            frmSatışListele listele = new frmSatışListele();
            listele.Show();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from sepet where barkodno='"+dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString()+"'",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürün sepetten çıkarıldı");
            daset.Tables["sepet"].Clear();
            sepetlistele();




        }

        private void btnSatışİptali_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from sepet ", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürünler sepetten çıkarıldı");
            daset.Tables["sepet"].Clear();
            sepetlistele();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtTelefon_TextChanged(object sender, EventArgs e)
        {
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
    }
}
