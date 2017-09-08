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
using System.Drawing.Imaging;
using System.Configuration;

namespace WindowsFormsApplication1
{
    public partial class kayitguncelle : Form
    {
        //public kayitguncelle otherform = new kayitguncelle();

        string resimPath;

        public kayitguncelle()
        {
            InitializeComponent();


        }
        private string brk;
        public string passvalue
        {
            get { return brk; }
            set { brk = value; }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
         if (resimPath !=null )
            {


                string kayit = "update ENVTABLO set [ÜRÜN TİPİ]=('" + turuntipi.Text + "'), [Marka]=('" + tMarka.Text + "'),[Model / Sürüm]=('" + tmodel.Text + "'),[Seri No]=('" + tseri.Text + "'),[İşlemci]=('" + tislemci.Text + "'),RAM=('" + tislemci.Text + "'),HDD=('" + thdd.Text + "'),HDD2=('" + thdd1.Text + "'),[Monitör]=('" + tmonitor.Text + "'),[İşletim Sistemi]=('" + tisletim.Text + "'),[Office]=('" + toffice.Text + "'),[Ürün Giriş Tarihi]=('" + dateTimePicker1.Text + "'),Tutar=('" + ttutar.Text + "'),fatura_no=('" + tfaturaseri.Text + "'),aciklama=('" + textBox13.Text + "') where barkod=('" + comboBox2.Text + "')";
          SqlConnection baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ToString());
          SqlCommand komut = new SqlCommand(kayit, baglanti);
          baglanti.Open();
          DataTable dt = new DataTable();
          SqlDataAdapter da = new SqlDataAdapter(komut);
          da.Fill(dt);
          SqlConnection baglanti2 = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ToString());
          SqlCommand komutresim = new SqlCommand("update ENVTABLO set resim=@image where BARKOD=('" + comboBox2.Text + "')", baglanti2);
          baglanti2.Open();
          DataTable bigdt = new DataTable();
          SqlDataAdapter bigda = new SqlDataAdapter("select MAX(BARKOD) FROM ENVTABLO;", baglanti2);
          bigda.Fill(bigdt);
          FileStream fs = new FileStream(resimPath, FileMode.Open, FileAccess.Read);
          BinaryReader br = new BinaryReader(fs);
          byte[] resim = br.ReadBytes((int)fs.Length);
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

          if (MessageBox.Show(comboBox2.Text + " Nolu Barkod Düzenlenmiştir. Görüntüleme / Yazdırma Yapmak İster Misiniz?", "Envanter Düzenleme Başarılı", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
          {
              qrcode2 qr2 = new qrcode2();
              qr2.passvalue = comboBox2.Text;
              qr2.ShowDialog();


          }

          else
          {

              kayitguncelle kg = new kayitguncelle();
              kg.Show();
              this.Close();
          }


















            }

            else if (resimPath==null)
            {

                string kayit = "update ENVTABLO set [ÜRÜN TİPİ]=('" + turuntipi.Text + "'), [Marka]=('" + tMarka.Text + "'),[Model / Sürüm]=('" + tmodel.Text + "'),[Seri No]=('" + tseri.Text + "'),İşlemci=('" + tislemci.Text + "'),RAM=('" + tislemci.Text + "'),HDD=('" + thdd.Text + "'),HDD2=('" + thdd1.Text + "'),[Monitör]=('" + tmonitor.Text + "'),[İşletim Sistemi]=('" + tisletim.Text + "'),[Office]=('" + toffice.Text + "'),[ürün giriş tarihi]=('" + dateTimePicker1.Text + "'),Tutar=('" + ttutar.Text + "'),fatura_no=('" + tfaturaseri.Text + "'),aciklama=('" + textBox13.Text + "') WHERE [BARKOD]=('" + comboBox2.Text + "') ";

                SqlConnection baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ToString());
                baglanti.Open();
                SqlCommand komut = new SqlCommand(kayit, baglanti);
              
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dt);
                SqlConnection baglanti2 = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ToString());
                baglanti.Close();
                baglanti2.Open();

                if (MessageBox.Show(comboBox2.Text + " Nolu Barkod Düzenlenmiştir. Görüntüleme / Yazdırma Yapmak İster Misiniz?", "Başarılı", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {

                    qrcode2 qr2 = new qrcode2();
                    qr2.passvalue = comboBox2.Text;
                    qr2.ShowDialog();


                }

                else
                {
                    kayitguncelle kg = new kayitguncelle();
                    kg.Show();
                    this.Close();
                }

            }

            else
            {

                MessageBox.Show("Hiçbir Alan Güncelleştirilemedi", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            
               
        }
        


        private void kayitguncelle_Load(object sender, EventArgs e)
        {
            if(brk !=null)
            {
                comboBox2.Text = brk;
                yukle();
            }

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ToString());
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

            this.Hide();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            
        }




        



        private void PrintDialog()
        {
            throw new NotImplementedException();
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

        private void yukle()
        {
            string baglancumlesi = ConfigurationManager.ConnectionStrings["connection"].ToString();
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


                        turuntipi.Text = (read["ÜRÜN TİPİ"].ToString());
                        tMarka.Text = (read["Monitör"].ToString());
                        tmodel.Text = (read["Model / Sürüm"].ToString());
                        tMarka.Text = (read["Marka"].ToString());
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
                        textBox13.Text = (read["aciklama"].ToString());

                    }

                    if (baglan.State == ConnectionState.Open)
                    {
                        baglan.Close();
                    }


                    if (pictureBox1.Image != null)
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
                        pictureBox1.InitialImage = Image.FromStream(stream);
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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        //arama yapıldığında
        {

            yukle();



        }

        private void button4_Click_1(object sender, EventArgs e)
        {


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {


            pictureBox1.Height = 540;
            pictureBox1.Width = 660;
            pictureBox1.Location = new Point(10, 10);
            pictureBox1.BringToFront();

            pictureBox1.MouseLeave += (s, a) =>
   {
       pictureBox1.Width = 120;
       pictureBox1.Height = 140;
       pictureBox1.Location = new Point(555, 170);


   };






        }

        private void button4_Click(object sender, EventArgs e)
        {


            saveFileDialog1.Title = "Resim Kaydet";
            saveFileDialog1.Filter = "Jpeg Dosyası (*.jpg)|*.jpg|Gif Dosyası (*.gif)|*.gif|Png Dosyası (*.png)|*.png|Tif Dosyası (*.tif)|*.tif";
            saveFileDialog1.FileName = "Fatura_Ornegi";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string baglancumlesi = ConfigurationManager.ConnectionStrings["connection"].ToString();
                SqlConnection baglan = new SqlConnection(baglancumlesi);



                SqlCommand resimkaydet = new SqlCommand("select resim from ENVTABLO WHERE barkod=('" + comboBox2.Text + "')", baglan);
                resimkaydet.Parameters.AddWithValue("@BARKOD", comboBox2.Text);
                DataSet DS = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(resimkaydet);
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
                    pictureBox1.InitialImage = Image.FromStream(stream);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox1.Image.Save(saveFileDialog1.FileName);
                    MessageBox.Show(saveFileDialog1.FileName + " Olarak Çıkartıldı", "Fatura Çıkart", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }









            }
        }
    }
}

            




    


        



        





