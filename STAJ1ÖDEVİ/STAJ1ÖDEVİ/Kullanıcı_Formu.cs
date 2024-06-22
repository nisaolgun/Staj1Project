using System.Data.SqlClient;
using System.Windows.Forms;

namespace STAJ1ÖDEVİ
{
    class Kullanıcı_Formu
    {
        SqlConnection baglanti = new SqlConnection("Data Source = NISANUR; Initial Catalog = Stok_Takip; Integrated Security = True");

        SqlCommand komut;
        SqlDataReader read;

        //bool giris;

        frmYeni yeni = new frmYeni();
        //private object txtadsoyad;
        //private object txtkullanıcıadı;
        //private object txtsifre;
        //private object txtsifretekrar;
        //private object txtsoru;
        //private object txtcevap;

        //private object kullanıcıadı;

        public SqlDataReader kullanıcı(System.Windows.Forms.TextBox kullanıcıadı, System.Windows.Forms.TextBox şifre)
        {
            baglanti.Open();
            komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = "select *from kullanici where kullanıcıadı='"+kullanıcıadı.Text+"'";
            read = komut.ExecuteReader();
            if(read.Read()==true && kullanıcıadı != null && kullanıcıadı.Text !="")
            {
                if(şifre.Text==read["sifre"].ToString() )
                {
                    MessageBox.Show("Giriş başarılı");

                    
                    yeni.Show();
                    

                }
                else
                {
                    MessageBox.Show("Şifrenizi kontrol ediniz", "şifre");
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı adı ve şifreyi giriniz", "şifre");
            }
            
           
            baglanti.Close();
            return read;
         
        }
        public void yenikullanıcı(System.Windows.Forms.TextBox adsoyad, System.Windows.Forms.TextBox kullanıcıadı, System.Windows.Forms.TextBox şifre, System.Windows.Forms.TextBox şifretekrar, System.Windows.Forms.TextBox soru, System.Windows.Forms.TextBox cevap, GroupBox grup)
        {
            if(şifre.Text==şifretekrar.Text)
            {
                baglanti.Open();
                //komut = new SqlCommand();
                //komut.Connection = baglanti;
                //komut.CommandText = "insert into tbl_kullanici values('"+adsoyad.Text+"','"+kullanıcıadı.Text+"','"+şifre.Text+"','"+şifretekrar.Text+"','"+soru.Text+"','"+cevap.Text+"')";
                SqlCommand komut = new SqlCommand("insert into kullanici(adsoyad,kullanıcıadı,sifre,sifretekrar,soru,cevap) values(@adsoyad,@kullanıcıadı,@sifre,@sifretekrar,@soru,@cevap)", baglanti);
                komut.Parameters.AddWithValue("@adsoyad",adsoyad.Text);
                komut.Parameters.AddWithValue("@kullanıcıadı",kullanıcıadı.Text);
                komut.Parameters.AddWithValue("@sifre", şifre.Text);
                komut.Parameters.AddWithValue("@sifretekrar",şifretekrar.Text);
                komut.Parameters.AddWithValue("@soru", soru.Text);
                komut.Parameters.AddWithValue("@cevap", cevap.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Üye eklendi");
                foreach (Control item in grup.Controls) if (item is System.Windows.Forms.TextBox) item.Text = "";

            }
            else
            {
                MessageBox.Show("Şifreler uyuşmuyor", "Hata");
            }
        }


        public void şifre(System.Windows.Forms.TextBox adsoyad, System.Windows.Forms.TextBox kullanıcıadı, System.Windows.Forms.TextBox şifre, System.Windows.Forms.TextBox şifretekrar, System.Windows.Forms.TextBox soru, System.Windows.Forms.TextBox cevap,GroupBox grup)
        {
            if (şifre.Text==şifretekrar.Text)
            {
                baglanti.Open();
                komut = new SqlCommand("select *from tbl_kullanici where kullanıcıadı='" + kullanıcıadı.Text + "'", baglanti);
                read = komut.ExecuteReader();
                if (read.Read() == true)
                {
                    if (soru.Text == read["soru"].ToString() && cevap.Text == read["cevap"].ToString())
                    {
                        baglanti.Close();
                        baglanti.Open();
                        komut = new SqlCommand("update tbl_kullanıcı set adsoyad='" + adsoyad.Text+"',sifre='{şifre.Text}' where kullanıcıadı='{kullanıcıadı}'", baglanti);
                        komut.ExecuteNonQuery();
                        baglanti.Close();
                        MessageBox.Show("İşlem Başarılı");
                        foreach (Control item in grup.Controls) if (item is System.Windows.Forms.TextBox) item.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı adı hariç diğer bilgilerinizi kontrol ediniz.", "Hata1");
                    }
                }
                else
                {
                    MessageBox.Show("Bilgilerinizi kontrol ediniz.", "Hata2");
                }
                baglanti.Close();
            }
            

            else
            {
                MessageBox.Show("Şifreler aynı değil.", "Hata3");
            }
        }
    }
}
