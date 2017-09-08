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
    public partial class seriara : Form
    {

        string resimPath;

        public seriara()
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

        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {



            if (e.RowIndex > -1)
            {
                
                    DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                    tseri.Text = row.Cells["Barkod"].Value.ToString();
                //alanlartemizle();
                    getir();
                
            }




        }
        private void getir()
        {
            

            SqlConnection baglan = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ToString());
            SqlCommand resimbul = new SqlCommand("select resim from ENVTABLO WHERE barkod=('" + tseri.Text + "')", baglan);
            SqlCommand k_tumu = new SqlCommand("IF EXISTS (SELECT * FROM sahiplik where sahiplik.BARKOD=('" + tseri.Text + "')) begin SELECT top 1* FROM sahiplik LEFT JOIN ENVTABLO ON ENVTABLO.BARKOD=sahiplik.BARKOD left join personel ON personel.TAMAD=sahiplik.TAMADI  WHERE sahiplik.BARKOD=('" + tseri.Text + "') order by zimmet_tarihi desc END ELSE BEGIN (select *from ENVTABLO where ENVTABLO.BARKOD=('" + tseri.Text + "')) end", baglan);
            SqlCommand denetle = new SqlCommand("select *from sahiplik where BARKOD=('" + tseri.Text + "')", baglan);

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

                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();
                }
                using (SqlDataReader read = k_tumu.ExecuteReader())
                {
                    {

                    }

                    while (read.Read())
                    {


                        textBox7.Text = (read["Ürün Tipi"].ToString());
                        tmonitor.Text = (read["Monitör"].ToString());
                        tmodel.Text = (read["Model / Sürüm"].ToString());
                        tMarka.Text = (read["Marka"].ToString());
                        tseri.Text = (read["Barkod"].ToString());
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
                        textBox6.Text = (read["Seri No"].ToString());
                        if (denetleint > 0)
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


                    resimbul.Parameters.AddWithValue("@BARKOD", tseri.Text);
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
                baglan.Close();
            }





        }


        private void seriara_Load(object sender, EventArgs e)

        {

            label1.Text = brk;
            SortedDictionary<string, string> userCache = new SortedDictionary<string, string>
{
                     {"Seri No", "Seri No"},
                     {"Marka", "Marka"},
                     {"Ürün Tipi", "Ürün Tipi"},
                     {"Model / Sürüm","Model / Sürüm"},
                     { "Adı veya Soyadı","TAMADI"},
                     {"Barkod No", "BARKOD" }

};
            comboBox1.DataSource = new BindingSource(userCache, null);
            comboBox1.DisplayMember = "Key";
            comboBox1.ValueMember = "Value";
            comboBox1.SelectedIndex = 4;
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



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
 
        {
         //   comboBox1.Items.Add("Seri No");



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
       pictureBox1.Location = new Point(529, 442);


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



                SqlCommand resimkaydet = new SqlCommand("select resim from ENVTABLO WHERE barkod=('" + tseri.Text + "')", baglan);
                resimkaydet.Parameters.AddWithValue("@BARKOD", tseri.Text);
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

                try
                {
                    using (var stream = new System.IO.MemoryStream(data))
                    {
                        pictureBox1.Image = Image.FromStream(stream);
                        pictureBox1.InitialImage = Image.FromStream(stream);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox1.Image.Save(saveFileDialog1.FileName);
                        MessageBox.Show(saveFileDialog1.FileName + " Olarak Çıkartıldı", "Fatura Çıkart", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
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
            if (dataGridView1.SelectedRows.Count ==1)
            {
                qrcode2 qr2 = new qrcode2();
                qr2.passvalue = tseri.Text;
                qr2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Yazdırılacak Birşey Bulunamadı", "Hata", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void alanlartemizle()
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
            textBox6.Text = null;
            textBox7.Text = null;
            tseri.Text = null;
            tMarka.Text = null;
            tmodel.Text = null;
            tmonitor.Text = null;
            tseri.Text = null;
            tislemci.Text = null;
            tisletim.Text = null;
            toffice.Text = null;
            thdd1.Text = null;
            thdd.Text = null;
            tfaturaseri.Text = null;
            ttutar.Text = null;
            pictureBox1.Image = null;
            tram.Text = null;
            dateTimePicker1.Text = null;


            
        }
        public void yenidenboyut()
        {

        }

        private void datadoldur()
        {
           // alanlartemizle();
            if (textBox5.Text.Length > 0)
            {


                SqlConnection baglan = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ToString());
                string deger = "[" + comboBox1.SelectedValue.ToString() + "]";
                string komut2 = "select T.BARKOD,[ÜRÜN TİPİ],Marka,[Model / Sürüm],[Seri No],TAMADI from (select BARKOD,zimmet_tarihi,TAMADI,row_number() over(partition by barkod  order by zimmet_tarihi desc) as rn from sahiplik sah )as T inner join envtablo on ENVTABLO.BARKOD=T.BARKOD where rn = 1 and TAMADI like '%" + textBox5.Text + "%' ";
                string komut = "select T.BARKOD,[ÜRÜN TİPİ],Marka,[Model / Sürüm],[Seri No],sah.TAMADI from ENVTABLO t full outer join sahiplik sah on sah.BARKOD=t.BARKOD where t." + deger + " like '%" + textBox5.Text + "%'";
                this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                this.dataGridView1.MultiSelect = false;
                

                baglan.Open();
                if (comboBox1.SelectedValue.ToString() == "TAMADI")
                {


                    this.dataGridView1.FirstDisplayedCell = null;
                    this.dataGridView1.ClearSelection();
                    SqlDataAdapter da2 = new SqlDataAdapter(komut2, baglan);
                    DataTable dt2 = new DataTable();
                    da2.Fill(dt2);
                    dataGridView1.DataSource = dt2;
                //    label1.Text = komut2;
                }
                else
                {
                    this.dataGridView1.FirstDisplayedCell = null;
                    this.dataGridView1.ClearSelection();
                    SqlDataAdapter da = new SqlDataAdapter(komut, baglan);
                    DataTable dt = new DataTable();
                    dataGridView1.DataSource = dt;
                    da.Fill(dt);
                  //  label1.Text = komut;
                }

                

                


            }
            else
            {
                MessageBox.Show("Boş Arama Yapılamaz", "Arama Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }


        }
        private void button1_Click_1(object sender, EventArgs e)
        {
           alanlartemizle();
            datadoldur();
            getir();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string deger = comboBox1.Text.ToString();
            MessageBox.Show(deger.ToString());
        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                kayitguncelle kay = new kayitguncelle();

                kay.passvalue = tseri.Text;
                kay.ShowDialog();
            }
            else
            {
                MessageBox.Show("Düzenlenecek Birşey Bulunamadı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                
                guncelle gunc = new guncelle();

                gunc.Hide();
              
                gunc.guncpass2 = tseri.Text;
                gunc.guncpass = label1.Text;
               
                gunc.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("Zimmetlenecek Birşey Bulunamadı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >-1)
            {



                alanlartemizle();
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                tseri.Text = row.Cells["Barkod"].Value.ToString();
                 getir();
            }
        }
        
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex >-1)
            //{



            //    //alanlartemizle();
            //    DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            //    tseri.Text = row.Cells["Barkod"].Value.ToString();
            //    // getir();

            //}
        }
    }

}



            




    


        



        





