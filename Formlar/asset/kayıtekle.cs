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
using System.IO;
using System.Configuration;

namespace WindowsFormsApplication1
{
    public partial class kayıtekle : Form

    {
        private string ekl;
        public string passvalue
        {
            get { return ekl; }
            set {ekl = value; }
        }
                
        
        string resimPath;

        public kayıtekle()
        {
            InitializeComponent();


        }

        private void kayıtekle_Load(object sender, EventArgs e)
        {
            this.AcceptButton = butonekle;
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ToString());
            SqlCommand cmd = new SqlCommand("SELECT DISTINCT [ÜRÜN TİPİ] from ENVTABLO", conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
                comboBox1.Items.Add(dr["ÜRÜN TİPİ"]);
            conn.Close();
        }
        private void tumkayit()
        {
            string kayit = "insert into ENVTABLO ([ÜRÜN TİPİ],Marka,[Model / Sürüm],[Seri No],[İşlemci],RAM,HDD,HDD2,[Monitör],[İşletim Sistemi],[Office],[Ürün Giriş Tarihi],Tutar,[Fatura_no],aciklama) VALUES ('" + comboBox1.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + textBox10.Text + "','" + textBox11.Text + "','" + textBox12.Text + "','" + dateTimePicker1.Text + "','" + textBox2.Text + "','" + textBox1.Text + "','" + textBox13.Text + "')";
            SqlConnection baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ToString());
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            baglanti.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            da.Fill(dt);
            SqlConnection baglanti2 = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ToString());
            baglanti2.Open();
            DataTable bigdt = new DataTable();
            SqlDataAdapter bigda = new SqlDataAdapter("select MAX(BARKOD) FROM ENVTABLO;", baglanti2);
            bigda.Fill(bigdt);
            FileStream fs = new FileStream(resimPath, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            byte[] resim = br.ReadBytes((int)fs.Length);
            SqlCommand komutresim = new SqlCommand("update ENVTABLO set resim=@image where BARKOD='" + bigdt.Rows[0][0].ToString() + "'", baglanti2);
            komutresim.Parameters.Add("@image", SqlDbType.Image, resim.Length).Value = resim;
            try
            {
                komutresim.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

            finally
            {

            }

            if (MessageBox.Show(bigdt.Rows[0][0].ToString() + " Nolu Barkod Atanmıştır, Görüntüleme / Yazdırma Yapmak İster Misiniz?", "Başarılı", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                qrcode2 qr2 = new qrcode2();
                qr2.passvalue = bigdt.Rows[0][0].ToString();
                qr2.ShowDialog();
            }

            else
            {

                kayıtekle ke = new kayıtekle();
                ke.Show();
                this.Close();
            }

        }
        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }
        private void gereklialanlar()
        {
            MessageBox.Show("Gerekli Alanları Doldurunuz", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //(pictureBox1.Image !=null &
        }
        private void resimsiz()
        {
            string kayit = "insert into ENVTABLO ([ÜRÜN TİPİ],Marka,[Model / Sürüm],[Seri No],[İşlemci],RAM,HDD,HDD2,[Monitör],[İşletim Sistemi],[Office],[Ürün Giriş Tarihi],Tutar,[Fatura_no],aciklama) VALUES ('" + comboBox1.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + textBox10.Text + "','" + textBox11.Text + "','" + textBox12.Text + "','" + dateTimePicker1.Text + "','" + textBox2.Text + "','" + textBox1.Text + "','" + textBox13.Text + "')";
            SqlConnection baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ToString());
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            baglanti.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            da.Fill(dt);
            SqlConnection baglanti2 = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ToString());
            baglanti2.Open();
            DataTable bigdt = new DataTable();
            SqlDataAdapter bigda = new SqlDataAdapter("select MAX(BARKOD) FROM ENVTABLO;", baglanti2);
            bigda.Fill(bigdt);

            if (MessageBox.Show(bigdt.Rows[0][0].ToString() + " Nolu Barkod Atanmıştır, Görüntüleme / Yazdırma Yapmak İster Misiniz?", "Başarılı", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {

                qrcode2 qr2 = new qrcode2();
                qr2.passvalue = bigdt.Rows[0][0].ToString();
                qr2.ShowDialog();


            }

            else
            {


                kayıtekle ke = new kayıtekle();
                ke.Show();
                this.Close();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1 & textBox3.Text.Trim().Length > 0 & textBox4.Text.Trim().Length > 0)
            {
                if (pictureBox1.Image != null)
                {tumkayit();}
                else if (pictureBox1.Image == null)
                { resimsiz(); }

                else
                { gereklialanlar(); }

               
            }

  
            else
            {

                gereklialanlar();


            }
            
               
        }


        private void button2_Click(object sender, EventArgs e)
        {

            this.Hide();
        }



        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Resim Aç";
            openFileDialog1.Filter = "Jpeg Dosyası (*.jpg)|*.jpg|Gif Dosyası (*.gif)|*.gif|Png Dosyası (*.png)|*.png|Tif Dosyası (*.tif)|*.tif";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                resimPath = openFileDialog1.FileName.ToString();
            }






        }


        private void button4_Click(object sender, EventArgs e)
        {
           


        }

        private void butondiger_Click(object sender, EventArgs e)
        {

            MessageBox.Show("butondiger");
            string kayit = "insert into ENVTABLO ([ÜRÜN TİPİ],Marka,[Model / Sürüm],[Seri No],İşlemci,RAM,HDD,HDD2,MONİTÖR,[İŞLETİM SİSTEMİ],OFFİCE,[ürün giriş tarihi],Tutar,fatura_no,aciklama) VALUES ('" + comboBox1.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + textBox10.Text + "','" + textBox11.Text + "','" + textBox12.Text + "','" + dateTimePicker1.Text + "','" + textBox2.Text + "','" + textBox1.Text + "','" + textBox13.Text + "')";
            SqlConnection baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ToString());
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            baglanti.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            da.Fill(dt);
            MessageBox.Show("Kayıt Eklendi.");





        }

        private void butontest_Click(object sender, EventArgs e)
        {
            //yukarıdaki komut


            MessageBox.Show("butondiger");
            string kayit = "insert into ENVTABLO ([ÜRÜN TİPİ],Marka,[Model / Sürüm],[Seri No],İşlemci,RAM,HDD,HDD2,MONİTÖR,[İŞLETİM SİSTEMİ],OFFİCE,[ürün giriş tarihi],Tutar,fatura_no,aciklama) VALUES ('" + comboBox1.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + textBox10.Text + "','" + textBox11.Text + "','" + textBox12.Text + "','" + dateTimePicker1.Text + "','" + textBox2.Text + "','" + textBox1.Text + "','" + textBox13.Text + "')";
            SqlConnection baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ToString());
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            baglanti.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            da.Fill(dt);
            MessageBox.Show("Kayıt Eklendi.");


            //yukarıdaki komut bitti
            
            // test butonu sadece resim kaydeder

            MessageBox.Show("sadece resim");
            SqlConnection baglanti2 = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ToString());
            baglanti2.Open();
            //en yüksek barkodu getir
          //  SqlCommand big = new SqlCommand("SELECT MAX(BARKOD) FROM ENVTABLO;", baglanti2);
            DataTable bigdt = new DataTable();
            SqlDataAdapter bigda = new SqlDataAdapter("select MAX(BARKOD) FROM ENVTABLO;", baglanti2);
            bigda.Fill(bigdt);
            MessageBox.Show(bigdt.Rows[0][0].ToString()+" NOLU BARKOD OLUŞTURULDU");
            FileStream fs = new FileStream(resimPath, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            byte[] resim = br.ReadBytes((int)fs.Length);
            SqlCommand komutresim = new SqlCommand("update ENVTABLO set resim=@image where BARKOD='" + bigdt.Rows[0][0].ToString() + "'", baglanti2);
            komutresim.Parameters.Add("@image", SqlDbType.Image, resim.Length).Value = resim;
            try
            {
                komutresim.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

            finally
            {

            }

            // test butonu bitti


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            pictureBox1.Height = 400;
            pictureBox1.Width = 650;
            pictureBox1.Location = new Point(20, 20);
            pictureBox1.BringToFront();

            pictureBox1.MouseLeave += (s, a) =>
            {
                pictureBox1.Width = 100;
                pictureBox1.Height = 120;
                pictureBox1.Location = new Point(570, 125);


            };





        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }

}


