using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using MessagingToolkit.QRCode;
using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;
using System.Data.SqlClient;


namespace WindowsFormsApplication1
{


    public partial class zimmetformu : Form
    {

        private string brk;
        public string passvalue
        {
            get { return brk; }
            set { brk = value; }
        }
                
      public zimmetformu()
       {
         InitializeComponent();

      }

 
private void zimmetformu_Load(object sender, EventArgs e)
        {
            textBox1.Text = brk;

    //


            string baglancumlesi = "Data Source=IT-HALITDERYA3\\SQLEXPRESS;Initial Catalog=ENVANTER;Integrated Security=True;";
            SqlConnection baglan = new SqlConnection(baglancumlesi);
            baglan.Open();
            SqlCommand k_tumu = new SqlCommand("select *from envtablo where barkod=('" + textBox1.Text + "')", baglan);
            using (SqlDataReader read = k_tumu.ExecuteReader())


                while (read.Read())
                {


                    textBox2.Text = (read["Ürün Tipi"].ToString());
                    textBox3.Text = (read["Marka"].ToString());
                    textBox4.Text = (read["Model / Sürüm"].ToString());
                    textBox5.Text = (read["Seri No"].ToString());

                }


            SqlConnection baglanti2 = new SqlConnection("Data Source=IT-HALITDERYA3\\SQLEXPRESS;Initial Catalog=ENVANTER;Integrated Security=True");
            DataTable bigdt = new DataTable();
            SqlDataAdapter bigda = new SqlDataAdapter("select MAX(BARKOD) FROM ENVTABLO;", baglanti2);
            bigda.Fill(bigdt);

            try
            {
                pictureBox1.Image = KareKodOlustur(bigdt.Rows[0][0].ToString(), 4);
            }
            catch
            {
                MessageBox.Show("Barkod Oluşturulamadı", "Hata !");
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

private void button1_Click(object sender, EventArgs e)
{


       DialogResult pdr = printDialog1.ShowDialog();
       if (pdr == DialogResult.OK)
       {
           printDocument1.Print();
       }





}

private void printPreviewDialog1_Load(object sender, EventArgs e)
{

}
  
private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
{
    

    Font myFont = new Font("Calibri", 28);
    SolidBrush sbrush = new SolidBrush(Color.Black);
    Pen myPen = new Pen(Color.Black);

    e.Graphics.DrawString("ENVANTER KAYIT SISTEMI", new Font("Calibri", 12, FontStyle.Bold), Brushes.Black, 55, 75);
    e.Graphics.DrawString("BARKOD :", new Font("Calibri", 9, FontStyle.Bold), Brushes.Black, 110, 100);
    e.Graphics.DrawString("ÜRÜN TİPİ :", new Font("Calibri", 9, FontStyle.Bold), Brushes.Black, 110, 125);
    e.Graphics.DrawString("MARKA :", new Font("Calibri", 9, FontStyle.Bold), Brushes.Black, 110, 150);
    e.Graphics.DrawString("MODEL :", new Font("Calibri", 9, FontStyle.Bold), Brushes.Black, 110, 175);
    e.Graphics.DrawString("SERİ NO :", new Font("Calibri", 9, FontStyle.Bold), Brushes.Black, 110, 200);

    if (textBox2.Text=="YAZILIM")
    {
        e.Graphics.DrawString("XXX-XXX-XXX", new Font("Calibri", 9, FontStyle.Bold), Brushes.Black, 180, 160);

    }
    else
    {

        e.Graphics.DrawString(textBox5.Text, new Font("Calibri", 9, FontStyle.Bold), Brushes.Black, 180, 200);

    }
    e.Graphics.DrawString(textBox1.Text, new Font("Calibri", 9, FontStyle.Bold), Brushes.Black, 180, 100);
    e.Graphics.DrawString(textBox2.Text, new Font("Calibri", 9, FontStyle.Bold), Brushes.Black, 180, 125);
    e.Graphics.DrawString(textBox3.Text, new Font("Calibri", 9, FontStyle.Bold), Brushes.Black, 180, 150);
    e.Graphics.DrawString(textBox4.Text, new Font("Calibri", 9, FontStyle.Bold), Brushes.Black, 180, 175);
    e.Graphics.DrawString(textBox1.Text, new Font("3 of 9 Barcode", 30, FontStyle.Regular), Brushes.Black, 2, 180);

  
 

    e.Graphics.DrawLine(myPen,5, 5, 300, 5);
    e.Graphics.DrawLine(myPen, 5, 220, 300,220);
    e.Graphics.DrawLine(myPen, 5, 220, 5,5);
    e.Graphics.DrawLine(myPen, 300, 220, 300,5);

    float newWidth = pictureBox1.Image.Width * 50 / pictureBox1.Image.HorizontalResolution;
    float newHeight = pictureBox1.Image.Height * 50 / pictureBox1.Image.VerticalResolution;
    float widthFactor = newWidth / e.MarginBounds.Width;
    float heightFactor = newHeight / e.MarginBounds.Height;
    float newWidth2 = Properties.Resources.logo_polin.Width * 100 / Properties.Resources.logo_polin.HorizontalResolution;
    float newHeight2 = Properties.Resources.logo_polin.Height * 60 / Properties.Resources.logo_polin.VerticalResolution;
    float widthFactor2 = newWidth2 / e.MarginBounds.Width;
    float heightFactor2 = newHeight2 / e.MarginBounds.Height;
    e.Graphics.DrawImage(pictureBox1.Image, 10, 103, (int)newWidth, (int)newHeight);
    e.Graphics.DrawImage(Properties.Resources.logo_polin, 60, 10, (int)newWidth2, (int)newHeight2);
    

                



}







    }
}


