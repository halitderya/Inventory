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
using MessagingToolkit.QRCode;
using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;


namespace WindowsFormsApplication1
{
    public partial class barkodara : Form

 
    {

        string resimPath;

        public barkodara()
        {
            InitializeComponent();


        }


        private void Button1_Click(object sender, EventArgs e)
        {

        }



        private void barkodara_Load(object sender, EventArgs e)
        {
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



        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
 
        {
            

            SqlConnection baglan = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ToString());
            SqlCommand resimbul = new SqlCommand("select resim from ENVTABLO WHERE barkod=('" + comboBox2.Text + "')", baglan);
            SqlCommand k_tumu = new SqlCommand("IF EXISTS (SELECT * FROM sahiplik where sahiplik.BARKOD=('" + comboBox2.Text + "')) begin SELECT top 1* FROM sahiplik LEFT JOIN ENVTABLO ON ENVTABLO.BARKOD=sahiplik.BARKOD left join personel ON personel.TAMAD=sahiplik.TAMADI  WHERE sahiplik.BARKOD=('" + comboBox2.Text + "') order by zimmet_tarihi desc END ELSE BEGIN (select *from ENVTABLO where ENVTABLO.BARKOD=('" + comboBox2.Text + "')) end", baglan);                    
            SqlCommand denetle = new SqlCommand("select *from sahiplik where BARKOD=('" + comboBox2.Text + "')",baglan);
            
            
            try
            {

                baglan.Open();
                //
                SqlDataReader denetledr = denetle.ExecuteReader();

                int denetleint = 0;
                while (denetledr.Read())
                {
                    denetleint = denetleint + 1;
                }
                 
                
            baglan.Close();
                
                if (baglan.State== ConnectionState.Closed)
                {
                    baglan.Open();
                }
                using (SqlDataReader read = k_tumu.ExecuteReader())
                {
                    {

                    }

                    while (read.Read())
                    {


                        turuntipi.Text = (read["ÜRÜN TİPİ"].ToString());
                        tMarka.Text = (read["Marka"].ToString());
                        tmodel.Text = (read["Model / Sürüm"].ToString());
                      //  tMarka.Text = (read["Marka"].ToString());
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
                        if (denetleint >0)
                        {
                            textBox1.Text = (read["TAMADI"].ToString());
                            textBox2.Text = (read["DEPARTMAN"].ToString());
                            textBox3.Text = (read["FIRMA"].ToString());
                            textBox4.Text = (read["GOREV"].ToString());


                        }
                        else
                        {
                            textBox1.Text = "";
                            textBox2.Text = "";
                            textBox3.Text = "";
                            textBox4.Text = "";


                        }
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
                }
            }
            finally
            {
                comboBox2.SelectionLength = 0;
                baglan.Close();
            }





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
                SqlConnection baglan = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ToString());



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




        private Image KareKodOlustur(string giris, int kkDuzey)
        {
            var deger = giris;
            MessagingToolkit.QRCode.Codec.QRCodeEncoder qe = new MessagingToolkit.QRCode.Codec.QRCodeEncoder();
            qe.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE;
            qe.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.L;
            qe.QRCodeVersion = kkDuzey;
            System.Drawing.Bitmap bm = qe.Encode(deger);
            return bm;
        }

        private void buttonyazdir_Click(object sender, EventArgs e)
        {
            qrcode2 qr2 = new qrcode2();
            qr2.passvalue = comboBox2.Text;
            qr2.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



}
            
    }



            




    


        



        





