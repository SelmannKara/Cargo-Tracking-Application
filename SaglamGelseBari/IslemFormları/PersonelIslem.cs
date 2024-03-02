using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace SaglamGelseBari.IslemFormları
{
    public partial class PersonelIslem : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=KargoUygulamasi;Integrated Security=SSPI");
        SqlCommand komut;
        SqlDataReader dr;
        public PersonelIslem()
        {
            InitializeComponent();
        }

        private void GbxAlici_Enter(object sender, EventArgs e)
        {

        }

     

        private void PersonelIslem_Load(object sender, EventArgs e)
        {

            comboBoxSehir.Items.Clear();
            baglanti.Open();
            komut = new SqlCommand("SELECT sehir_title FROM sehir", baglanti); 
            dr = komut.ExecuteReader();

            while (dr.Read())
            {
                comboBoxSehir.Items.Add(dr["sehir_title"].ToString());
                comboBoxşehir2.Items.Add(dr["sehir_title"].ToString());
                
            }
           
            baglanti.Close();

         
           

            
        

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxilce.Items.Clear();

            string secilenSehir = comboBoxSehir.SelectedItem.ToString();   
            baglanti.Open();
            SqlCommand sehirKeyKomut = new SqlCommand("SELECT sehir_key FROM sehir WHERE sehir_title = @secilenSehir", baglanti);
            sehirKeyKomut.Parameters.AddWithValue("@secilenSehir", secilenSehir);
            SqlDataReader sehirKeyDr = sehirKeyKomut.ExecuteReader();

            int secilenSehirKey = 0;

            if (sehirKeyDr.Read())
            {
                secilenSehirKey = Convert.ToInt32(sehirKeyDr["sehir_key"]);
            }
            sehirKeyDr.Close();
            SqlCommand ilceKomut = new SqlCommand("SELECT ilce_title FROM ilce WHERE ilce_sehirkey = @secilenSehirKey", baglanti);
            ilceKomut.Parameters.AddWithValue("@secilenSehirKey", secilenSehirKey);
            SqlDataReader ilceDr = ilceKomut.ExecuteReader();

            while (ilceDr.Read())
            {
                comboBoxilce.Items.Add(ilceDr["ilce_title"].ToString()); 
            }

            baglanti.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxMahalle.Items.Clear();
            string secilenIlce=comboBoxilce.SelectedItem.ToString();
            baglanti.Open();
            SqlCommand ilceKeyKomut = new SqlCommand("select ilce_key from ilce WHERE ilce_title= @secilenIlce", baglanti);
            ilceKeyKomut.Parameters.AddWithValue("@secilenIlce", secilenIlce);
            SqlDataReader ilceKeyDr=ilceKeyKomut.ExecuteReader();
            int secilenIlceKey = 0;
            if(ilceKeyDr.Read())
            {
                secilenIlceKey = Convert.ToInt32(ilceKeyDr["ilce_key"]);
            }
            ilceKeyDr.Close();
            SqlCommand mahalleKomut = new SqlCommand("Select mahalle_title FROM mahalle where mahalle_ilcekey=@secilenIlceKey", baglanti);
            mahalleKomut.Parameters.AddWithValue("@secilenIlceKey", secilenIlceKey);// declare işlemi
            SqlDataReader mahalleDr=mahalleKomut.ExecuteReader();
            while (mahalleDr.Read())
            {
                comboBoxMahalle.Items.Add(mahalleDr["mahalle_title"].ToString());
            }
            baglanti.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
          
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            string email = textBoxmail.Text.Trim();
            string regexkodu = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.([a-zA-Z].{2,2})+$";

            if (Regex.IsMatch(email, regexkodu))
            {
                errorProvider1.SetError(textBoxmail, ""); 
            }
            else
            {
                errorProvider1.SetError(textBoxmail, "Geçersiz e-mail formatı");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            baglanti.Open();
            if (radioBireysel.Checked == true)
            {
                if (textBoxName.Text == "" || textBoxSurname.Text == "" || textBoxTc.Text == "")
                {
                    MessageBox.Show("Bireysel Gönderici Bölümünde Boş Bırakılmış Alanlar var");
                    baglanti.Close();
                }
                else
                {
                    SqlCommand cmd4 = new SqlCommand(@"insert into BGonderici(Ad,Soyad,Tc) values (@p1,@p2,@p3) ", baglanti);
                    cmd4.Parameters.AddWithValue("@p1", textBoxName.Text);
                    cmd4.Parameters.AddWithValue("@p2", textBoxSurname.Text);
                    cmd4.Parameters.AddWithValue("@p3", textBoxTc.Text);
                    int a = cmd4.ExecuteNonQuery();
                    if (a > 0)
                    {
                        MessageBox.Show("Bireysel Gönderici Veriler Başarıyla Kaydedilmiştir");
                    }
                    else
                    {
                        MessageBox.Show("Üzgünüz Bir Hata Olutu Tekrar Deneyiniz");
                    }
                }

                baglanti.Close();
            }

            if (radioKurumsal.Checked == true)
            {
                if (textBoxKurumAd.Text == "" || textBoxMersis.Text == "")
                {
                    MessageBox.Show("Kurumsal Gönderici Bölümünde Boş Bırakılmış Alanlar var");
                    baglanti.Close();
                }
                else
                {
                    SqlCommand cmd3 = new SqlCommand(@"insert into KGonderici (KurumAd,MersisNo) values (@p1,@p2) ", baglanti);
                    cmd3.Parameters.AddWithValue("@p1", textBoxKurumAd.Text);
                    cmd3.Parameters.AddWithValue("@p2", textBoxMersis.Text);
                    int a = cmd3.ExecuteNonQuery();
                    if (a > 0)
                    {
                        MessageBox.Show("Kurumsal Gönderici Veriler Başarıyla Kaydedilmiştir");
                    }
                    else
                    {
                        MessageBox.Show("Üzgünüz Bir Hata Olutu Tekrar Deneyiniz");
                    }
                }
                baglanti.Close();
            }
            baglanti.Open();
            if (comboBoxSehir.Text == "" || comboBoxilce.Text == "" || comboBoxMahalle.Text == "" || textBoxAdres.Text == "" || TextBoxtel.Text == "" || textBoxmail.Text == "")
            {
                MessageBox.Show("Gönderici Bölümünde Boş Bırakılmış Alanlar var");
                baglanti.Close();
            }
            else
            {
                SqlCommand cmd2 = new SqlCommand(@"insert into Gondericiler (IndirimOrani,Sehir,Ilce,Mahalle,Adres,Telefon,Mail,AnlasmaKodu) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8) ", baglanti);

                cmd2.Parameters.AddWithValue("@p1", textBoxindirimoranı.Text);
                cmd2.Parameters.AddWithValue("@p2", comboBoxSehir.Text);
                cmd2.Parameters.AddWithValue("@p3", comboBoxilce.Text);
                cmd2.Parameters.AddWithValue("@p4", comboBoxMahalle.Text);
                cmd2.Parameters.AddWithValue("@p5", textBoxAdres.Text);
                cmd2.Parameters.AddWithValue("@p6", TextBoxtel.Text);
                cmd2.Parameters.AddWithValue("@p7", textBoxmail.Text);
                cmd2.Parameters.AddWithValue("@p8", textBoxanlaşmakodu.Text);
                int a = cmd2.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Gönderici Veriler Başarıyla Kaydedilmiştir");
                }
                else
                {
                    MessageBox.Show("Üzgünüz Bir Hata Olutu Tekrar Deneyiniz");
                }

                baglanti.Close();
            }
            baglanti.Open();
            if (textBoxalıcıname.Text == "" || textBoxalıcıadres.Text == "" || comboBoxşehir2.Text == "" || comboBoxmahalle2.Text == "" || comboBoxilce2.Text == ""
                || textBoxalıcıname.Text == "" || textBoxalıcısurname.Text == "" || textBoxMail2.Text == "" || TextBoxtel.Text == "")
            {
                MessageBox.Show("Alıcı Bölümünde Boş Bırakılmış Alanlar Var");
                baglanti.Close();

            }
            else
            {
                SqlCommand cmd1 = new SqlCommand(@"insert into Alici(Ad, Soyad, Sehir, Ilce, Mahalle, Adres, Mail, Telefon, Tc) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9) ", baglanti);
                cmd1.Parameters.AddWithValue("@p1", textBoxalıcıname.Text);
                cmd1.Parameters.AddWithValue("@p2", textBoxalıcısurname.Text);
                cmd1.Parameters.AddWithValue("@p3", comboBoxşehir2.Text);
                cmd1.Parameters.AddWithValue("@p4", comboBoxilce2.Text);
                cmd1.Parameters.AddWithValue("@p5", comboBoxmahalle2.Text);
                cmd1.Parameters.AddWithValue("@p6", textBoxalıcıadres.Text);
                cmd1.Parameters.AddWithValue("@p7", textBoxMail2.Text);
                cmd1.Parameters.AddWithValue("@p8", textBoxalıcıtel.Text);
                cmd1.Parameters.AddWithValue("@p9", textBoxalıcıtc.Text);
                int a = cmd1.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Alıcı Veriler Başarıyla Kaydedilmiştir");
                }
                else
                {
                    MessageBox.Show("Üzgünüz Bir Hata Olutu Tekrar Deneyiniz");
                }
                baglanti.Close();
            }
            baglanti.Open();
            SqlCommand cmd = new SqlCommand(@"insert into Kargo(Fiyat,GonderimSekli,OdemeTuru,SigortaDurumu,Sinifi) values (@p1,@p2,@p3,@p4,@p5)", baglanti);

            if (ÖdemeTürüAlıcı.Checked == true)
            {
                cmd.Parameters.AddWithValue("@p3", ÖdemeTürüAlıcı.Text);
            }
            else
            {
                cmd.Parameters.AddWithValue("@p3", ÖdemeTürüGönderici.Text);
            }
            if (Sigortalı.Checked == true)
            {
                cmd.Parameters.AddWithValue("@p4", Sigortalı.Text);
            }
            else
            {
                cmd.Parameters.AddWithValue("@p4", Sigortasız.Text);
            }
            if (SınıfKutu.Checked == true)
            {
                cmd.Parameters.AddWithValue("@p5", SınıfKutu.Text);
            }
            else
            {
                cmd.Parameters.AddWithValue("@p5", SınıfZarf.Text);
            }
            
            if (GönderimŞekliExpress.Checked == true)
            {
                cmd.Parameters.AddWithValue("@p2", GönderimŞekliExpress.Text);
            }
            else if (GönderimŞekliHızlı.Checked == true)
            {
                cmd.Parameters.AddWithValue("@p2", GönderimŞekliHızlı.Text);
            }
            else
            {
                cmd.Parameters.AddWithValue("@p2", GönderimŞekliNormal.Text);
            }

            double en = Convert.ToDouble(textBoxen.Text);
            double Boy = Convert.ToDouble(textBoxboy.Text);
            double Yükseklik = Convert.ToDouble(textBoxyükseklik.Text);
            double agırlık = Convert.ToDouble(textBoxağırlık.Text);
            double desifiyat = ((en * Boy * Yükseklik) / 3000) * 32;
            double agırlıkfiyat = agırlık * 26;
            if (desifiyat > agırlıkfiyat)
            {
                if (Sigortalı.Checked == true)
                {
                    desifiyat = desifiyat + ((desifiyat * 30) / 100);
                }
                if (GönderimŞekliExpress.Checked == true)
                {
                    desifiyat = desifiyat + 40;
                }
                else if (GönderimŞekliHızlı.Checked == true)
                {
                    desifiyat = desifiyat + 27;
                }
                if (textBoxindirimoranı.Text != "0")
                {
                    double indirim = Convert.ToDouble(textBoxindirimoranı.Text);
                    desifiyat = desifiyat - ((desifiyat * indirim) / 100);
                }
                if (textBoxanlaşmakodu.Text != "Boş")
                {
                    desifiyat = desifiyat - Convert.ToDouble(textBoxanlaşmakodu.Text);
                }
                Fiyat.Text = desifiyat.ToString();
                cmd.Parameters.AddWithValue("@p1", Convert.ToDouble(Fiyat.Text));
            }
            else
            {
                if (Sigortalı.Checked == true)
                {
                    agırlıkfiyat = agırlıkfiyat + ((agırlıkfiyat * 30) / 100);
                }
                if (GönderimŞekliExpress.Checked == true)
                {
                    agırlıkfiyat = agırlıkfiyat + 40;
                }
                else if (GönderimŞekliHızlı.Checked == true)
                {
                    agırlıkfiyat = agırlıkfiyat + 27;
                }
                if (textBoxindirimoranı.Text != "0")
                {
                    double indirim = Convert.ToDouble(textBoxindirimoranı.Text);
                    agırlıkfiyat = agırlıkfiyat - ((agırlıkfiyat * indirim) / 100);
                }
                if (textBoxanlaşmakodu.Text != "Boş")
                {
                    agırlıkfiyat = agırlıkfiyat - Convert.ToDouble(textBoxanlaşmakodu.Text);
                }
                Fiyat.Text = agırlıkfiyat.ToString();
                cmd.Parameters.AddWithValue("@p1", Convert.ToDouble(Fiyat.Text));
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Kargo Veriler Başarıyla Kaydedilmiştir");
                }
                else
                {
                    MessageBox.Show("Üzgünüz Bir Hata Olutu Tekrar Deneyiniz");
                }

            }
            baglanti.Close();

        }

    

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxilce2.Items.Clear();

           // string secilenSehir = comboBox6.SelectedItem.ToString();
            baglanti.Open();
            SqlCommand sehirKeyKomut = new SqlCommand("SELECT sehir_key FROM sehir WHERE sehir_title = @secilenSehir", baglanti);
            sehirKeyKomut.Parameters.AddWithValue("@secilenSehir", comboBoxşehir2.Text);
            SqlDataReader sehirKeyDr = sehirKeyKomut.ExecuteReader();

           int secilenSehirKey = 0;

            if (sehirKeyDr.Read())
            {
                secilenSehirKey = Convert.ToInt32(sehirKeyDr["sehir_key"]);
            }
            sehirKeyDr.Close();
            SqlCommand ilceKomut = new SqlCommand("SELECT ilce_title FROM ilce WHERE ilce_sehirkey = @secilenSehirKey", baglanti);
            ilceKomut.Parameters.AddWithValue("@secilenSehirKey", secilenSehirKey);
            SqlDataReader ilceDr = ilceKomut.ExecuteReader();

            while (ilceDr.Read())
            {
                comboBoxilce2.Items.Add(ilceDr["ilce_title"].ToString());
            }
          
            baglanti.Close();
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxmahalle2.Items.Clear();
           // string secilenIlce = comboBox5.SelectedItem.ToString();
            baglanti.Open();
            SqlCommand ilceKeyKomut = new SqlCommand("select ilce_key from ilce WHERE ilce_title= @secilenIlce", baglanti);
            ilceKeyKomut.Parameters.AddWithValue("@secilenIlce", comboBoxilce2.Text);
            SqlDataReader ilceKeyDr = ilceKeyKomut.ExecuteReader();
            
            int secilenIlceKey = 0;
            if (ilceKeyDr.Read())
            {
                secilenIlceKey = Convert.ToInt32(ilceKeyDr["ilce_key"]);
            }
            ilceKeyDr.Close();
            SqlCommand mahalleKomut = new SqlCommand("Select mahalle_title FROM mahalle where mahalle_ilcekey=@secilenIlceKey", baglanti);
            mahalleKomut.Parameters.AddWithValue("@secilenIlceKey", secilenIlceKey);// declare işlemi
            SqlDataReader mahalleDr = mahalleKomut.ExecuteReader();
            while (mahalleDr.Read())
            {
                comboBoxmahalle2.Items.Add(mahalleDr["mahalle_title"].ToString());
            }
           
            baglanti.Close();
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioBireysel.Checked == true)
            {
                textBoxKurumAd.Visible = false;
                textBoxMersis.Visible = false;
                label34.Visible = false;
                label35.Visible = false;
                textBoxName.Visible = true; 
                textBoxSurname.Visible = true; 
                textBoxTc.Visible = true;
                label2.Visible = true;
                label3.Visible = true; 
                label4.Visible = true;
            }
            else
            {
                textBoxName.Visible = false;
                textBoxSurname.Visible=false;
                textBoxTc.Visible=false;
                label2.Visible=false;
                label3.Visible=false;
                label4.Visible=false;
                textBoxKurumAd.Visible = true;
                textBoxMersis.Visible = true;
                label34.Visible = true; 
                label35.Visible = true;
            }

        }

        private void textBoxanlasmakodu_TextChanged(object sender, EventArgs e)
        {

        }

        private void fiyat_Click(object sender, EventArgs e)
        {

        }
    }
}
