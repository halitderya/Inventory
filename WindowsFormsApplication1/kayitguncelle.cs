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
    public partial class kayitguncelle : Form

    {
        string resimPath;

        public kayitguncelle()
        {
            InitializeComponent();


        }
        



        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string kayit = "insert into ENVTABLO ([ÜRÜN TİPİ],MARKA,[MODEL / SÜRÜM],[SERİ NO],İŞLEMCİ,RAM,HDD,HDD2,MONİTÖR,[İŞLETİM SİSTEMİ],OFFİCE,[ürün giriş tarihi],Tutar,fatura_no) VALUES ('" + turuntipi.Text + "','" + tmarka.Text + "','" + tmodel.Text + "','" + tseri.Text + "','" + tislemci.Text + "','" + tram.Text + "','" + thdd.Text + "','" + thdd1.Text + "','" + tmonitor.Text + "','" + tisletim.Text + "','" + toffice.Text + "','" + dateTimePicker1.Text + "','" + ttutar.Text + "','" + tfaturaseri.Text + "')";
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
               // MessageBox.Show(" Veritabanına kayıt yapıldı.");
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


        private void kayitguncelle_Load(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection("Data Source=IT-HALITDERYA3\\SQLEXPRESS;Initial Catalog=ENVANTER;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT BARKOD from ENVTABLO", conn);

            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
            {
                comboBox2.Items.Add(dr["BARKOD"]);
            }
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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string baglancumlesi = "Data Source=IT-HALITDERYA3\\SQLEXPRESS;Initial Catalog=ENVANTER;Integrated Security=True;";
            SqlConnection baglan = new SqlConnection(baglancumlesi);
            SqlConnection baglan2 = new SqlConnection(baglancumlesi);
            SqlCommand k_tumu = new SqlCommand("select *from envtablo where barkod=('" + comboBox2.Text + "')", baglan);
            SqlCommand resimbul = new SqlCommand("select resim from ENVTABLO WHERE barkod=('" + comboBox2.Text + "')", baglan);

            try
            {
                baglan.Open();

                using (SqlDataReader read = k_tumu.ExecuteReader())
                {
                    if (baglan.State == ConnectionState.Closed)
                    {
                        baglan.Open();
                    }
                    
                    
                    while (read.Read())
                    {
                       

                            turuntipi.Text = (read["Ürün Tipi"].ToString());
                            tmarka.Text = (read["Monitör"].ToString());
                            tmodel.Text = (read["Model / Sürüm"].ToString());
                            tmarka.Text = (read["Marka"].ToString());
                            tseri.Text = (read["Seri No"].ToString());
                            tram.Text = (read["Ram"].ToString());
                            thdd.Text = (read["Hdd"].ToString());
                            thdd1.Text = (read["hdd2"].ToString());
                            tislemci.Text = (read["İşlemci"].ToString());
                            tmonitor.Text = (read["Monitör"].ToString());
                            tisletim.Text = (read["İşletim Sistemi"].ToString());
                            toffice.Text = (read["Office"].ToString());
                            dateTimePicker1.Text = (read["Ürün Giriş Tarihi"].ToString());
                            tfaturaseri.Text = (read["Fatura_no"].ToString());
                            ttutar.Text = (read["Tutar"].ToString());

                    }
                        
                        if (baglan.State == ConnectionState.Open)
                        {
                            baglan.Close();
                        }

                        
                        else if (pictureBox1.Image != null)
                        {
                            pictureBox1.Image.Dispose();
                            pictureBox1.Image = null;
                        
                       }

                        if (baglan2.State == ConnectionState.Closed)
                        {
                            baglan2.Open();
                        }
                       
                        
                            resimbul.Parameters.AddWithValue("@BARKOD", comboBox2.Text);
                            DataSet DS = new DataSet();
                            SqlDataAdapter adapter = new SqlDataAdapter(resimbul);
                            adapter.Fill(DS, "resim");

                            var imagesTable = DS.Tables["resim"];
                            var imagesRows = imagesTable.Rows;
                            var count = imagesRows.Count;

                            if (count <= 0)
                                return;
                            var imageColumnValue =
                                imagesRows[count - 1]["resim"];
                            if (imageColumnValue == DBNull.Value)
                                return;

                            var data = (Byte[])imageColumnValue;
                            using (var stream = new System.IO.MemoryStream(data))
                            {
                                pictureBox1.Image = Image.FromStream(stream);
                                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                            }
                        
                    
                    //
                    
                    
                    
                }
            }
            finally
            {
                baglan2.Close();
            }





        }

        private void button4_Click_1(object sender, EventArgs e)
        {


        }
       
        }

}


