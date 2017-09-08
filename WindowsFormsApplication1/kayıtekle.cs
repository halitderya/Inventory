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

namespace WindowsFormsApplication1
{
    public partial class kayıtekle : Form

    {
        string resimPath;

        public kayıtekle()
        {
            InitializeComponent();


        }
        



        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string kayit = "insert into ENVTABLO ([ÜRÜN TİPİ],MARKA,[MODEL / SÜRÜM],[SERİ NO],İŞLEMCİ,RAM,HDD,HDD2,MONİTÖR,[İŞLETİM SİSTEMİ],OFFİCE,[ürün giriş tarihi],Tutar,fatura_no) VALUES ('" + comboBox1.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + textBox10.Text + "','" + textBox11.Text + "','" + textBox12.Text + "','" + dateTimePicker1.Text + "','" + textBox2.Text + "','" + textBox1.Text + "')";
            SqlConnection baglanti = new SqlConnection("Data Source=IT-HALITDERYA3\\SQLEXPRESS;Initial Catalog=ENVANTER;Integrated Security=True");
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            baglanti.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            da.Fill(dt);
            MessageBox.Show("Kayıt Eklendi.");
            // Resim Kaydetme
            FileStream fs = new FileStream(resimPath, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            byte[] resim = br.ReadBytes((int)fs.Length);
            br.Close();
            fs.Close();
            SqlCommand komutresim = new SqlCommand("insert into ENVTABLO(resim) Values (@image) ", baglanti);
            komutresim.Parameters.Add("@image", SqlDbType.Image, resim.Length).Value = resim;
            try
            {

                komutresim.ExecuteNonQuery();
                MessageBox.Show(" Veritabanına kayıt yapıldı.");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

            finally
            {
                baglanti.Close();
            }

            }


        private void kayıtekle_Load(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection("Data Source=IT-HALITDERYA3\\SQLEXPRESS;Initial Catalog=ENVANTER;Integrated Security=True;MultipleActiveResultSets=True");
            SqlCommand cmd = new SqlCommand("SELECT DISTINCT [ÜRÜN TİPİ] from ENVTABLO", conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
                comboBox1.Items.Add(dr["ÜRÜN TİPİ"]);
            conn.Close();
            }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            anasayfa frm4 = new anasayfa();

            frm4.Show();
            this.Hide();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Resim Aç";
            openFileDialog1.Filter = "Jpeg Dosyası (*.jpg)|*.jpg|Gif Dosyası (*.gif)|*.gif|Png Dosyası (*.png)|*.png|Tif Dosyası (*.tif)|*.tif";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                resimPath = openFileDialog1.FileName.ToString();
            }




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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
                    
        }
       
        }

}


