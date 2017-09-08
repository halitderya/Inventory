using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MessagingToolkit.QRCode.Codec;
using System.Data.SqlClient;
using System.Configuration;


namespace WindowsFormsApplication1
{


    public partial class qrcode2 : Form
    {

        private string brk;
        public string passvalue
        {
            get { return brk; }
            set { brk = value; }
        }
                
      public qrcode2()
       {
         InitializeComponent();

      }

 
private void qrcode2_Load(object sender, EventArgs e)
        {
            textBox1.Text = brk;

    //


            string baglancumlesi = ConfigurationManager.ConnectionStrings["connection"].ToString();
            SqlConnection baglan = new SqlConnection(baglancumlesi);
            baglan.Open();
            SqlCommand k_tumu = new SqlCommand("select *from envtablo env outer apply (select top 1 * from sahiplik  sah where env.BARKOD=sah.BARKOD order by sah.zimmet_tarihi desc) sah where env.BARKOD=('" + textBox1.Text + "')", baglan);
            using (SqlDataReader read = k_tumu.ExecuteReader())


                while (read.Read())
                {


                    textBox2.Text = (read["ÜRÜN TİPİ"].ToString());
                    textBox3.Text = (read["Marka"].ToString());
                    textBox4.Text = (read["Model / Sürüm"].ToString());
                    textBox5.Text = (read["Seri No"].ToString());
                    textBox6.Text = (read["İşlemci"].ToString());
                    textBox7.Text = (read["RAM"].ToString());
                    textBox8.Text = (read["HDD"].ToString());
                    textBox9.Text = (read["hdd2"].ToString());
                    textBox10.Text = (read["TAMADI"].ToString());
                    textBox11.Text = (read["it"].ToString());

                }


            SqlConnection baglanti2 = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ToString());
            DataTable bigdt = new DataTable();
            SqlDataAdapter bigda = new SqlDataAdapter("select MAX(BARKOD) FROM ENVTABLO;", baglanti2);
            bigda.Fill(bigdt);

            try
            {
                pictureBox1.Image = KareKodOlustur(textBox1.Text + "#" + textBox2.Text + "#" + textBox3.Text + "#" + textBox4.Text + "#" + textBox5.Text, 4);
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

            if (etiketbuton.Checked)
            {
                etiket.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("etiket", 236, 157);


            }
            else if (zimmetbuton.Checked)
            {

                zimmet.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("A4", 830, 1170);
                printPreviewDialog1.Document = zimmet;

            }

            
            DialogResult pdr = printDialog1.ShowDialog();
       if (pdr == DialogResult.OK)
       {
           if (etiketbuton.Checked)
           {
                    printPreviewDialog1.Document = etiket;
                    etiket.PrinterSettings = printDialog1.PrinterSettings;

                    etiket.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("etiket", 232, 153);

               etiket.Print();
           }
           else if (zimmetbuton.Checked)
                {
                    printPreviewDialog1.Document = zimmet;

                    zimmet.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("A4", 830, 1170);
                    zimmet.PrinterSettings = printDialog1.PrinterSettings;
                    zimmet.Print();
           }
                else { MessageBox.Show("Yazdırılacak birşey bulunamadı"); }
           

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

    e.Graphics.DrawString("ENVANTER KAYIT SİSTEMİ", new Font("Calibri", 8, FontStyle.Regular), Brushes.Black,55, 45);
    e.Graphics.DrawString("BARKOD :", new Font("Calibri", 6, FontStyle.Regular), Brushes.Black, 100, 63);
    e.Graphics.DrawString("ÜRÜN TİPİ :", new Font("Calibri", 6, FontStyle.Regular), Brushes.Black, 100,83 );
    e.Graphics.DrawString("Marka :", new Font("Calibri", 6, FontStyle.Regular), Brushes.Black, 100, 103);
    e.Graphics.DrawString("MODEL :", new Font("Calibri", 6, FontStyle.Regular), Brushes.Black, 100, 123);
    e.Graphics.DrawString("SERİ NO :", new Font("Calibri", 6, FontStyle.Regular), Brushes.Black, 100, 140);

    if (textBox2.Text=="YAZILIM" || textBox2.Text=="SOFTWARE")
    {
        e.Graphics.DrawString("XXX-XXX-XXX", new Font("Calibri", 6, FontStyle.Regular), Brushes.Black, 150, 140);

    }
    else
    {

        e.Graphics.DrawString(textBox5.Text, new Font("Calibri", 6, FontStyle.Regular), Brushes.Black, 150, 140);

    }
    e.Graphics.DrawString(textBox1.Text, new Font("Calibri", 6, FontStyle.Regular), Brushes.Black, 150, 63);
    e.Graphics.DrawString(textBox2.Text, new Font("Calibri", 6, FontStyle.Regular), Brushes.Black, 150, 83);
    e.Graphics.DrawString(textBox3.Text, new Font("Calibri", 6, FontStyle.Regular), Brushes.Black, 150, 103);
    e.Graphics.DrawString(textBox4.Text, new Font("Calibri", 6, FontStyle.Regular), Brushes.Black, 150, 123);
    e.Graphics.DrawString(textBox1.Text, new Font("3 of 9 Barcode", 16, FontStyle.Regular), Brushes.Black, 15,133 );

            //e.Graphics.DrawLine(myPen, 2, 2, 230, 2);
            //e.Graphics.DrawLine(myPen, 2, 153, 230, 153);
            //e.Graphics.DrawLine(myPen, 2, 153, 2, 2);
            //e.Graphics.DrawLine(myPen, 230, 153, 230, 2);
            e.Graphics.DrawLine(myPen, 90, 65, 90, 150);

            float newWidth = pictureBox1.Image.Width * 45 / pictureBox1.Image.HorizontalResolution;
    float newHeight = pictureBox1.Image.Height * 45 / pictureBox1.Image.VerticalResolution;
    float widthFactor = newWidth / e.MarginBounds.Width;
    float heightFactor = newHeight / e.MarginBounds.Height;

    float newWidth2 = Properties.Resources.logo_polin.Width * 40 / Properties.Resources.logo_polin.HorizontalResolution;
    float newHeight2 = Properties.Resources.logo_polin.Height * 35 / Properties.Resources.logo_polin.VerticalResolution;
    float widthFactor2 = newWidth2 / e.MarginBounds.Width;
    float heightFactor2 = newHeight2 / e.MarginBounds.Height;

    float newWidth3 = Properties.Resources.ebi.Width * 20 / Properties.Resources.streamfile.HorizontalResolution;
    float newHeight3 = Properties.Resources.ebi.Height * 30 / Properties.Resources.streamfile.VerticalResolution;
    float widthFactor3 = newWidth3 / e.MarginBounds.Width;
    float heightFactor3 = newHeight3 / e.MarginBounds.Height;


    e.Graphics.DrawImage(pictureBox1.Image, 15, 65, (int)newWidth, (int)newHeight);
    e.Graphics.DrawImage(Properties.Resources.POLIN_LOGO_1_01, 160, 6, (int)newWidth2, (int)newHeight2);
    e.Graphics.DrawImage(Properties.Resources.ebi_logo, 10, 6, (int)newWidth3, (int)newHeight3);

}

private void zimmet_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
{





            float[] dashValues = { 5, 2, 15, 4 };
            Pen blackPen = new Pen(Color.Black, 5);
            blackPen.DashPattern = dashValues;
            e.Graphics.DrawLine(blackPen, new Point(0, 585), new Point(830, 585));

    Font myFont = new Font("Calibri", 28);
    SolidBrush sbrush = new SolidBrush(Color.Black);
    Pen myPen = new Pen(Color.Black);


    e.Graphics.DrawString("POLİN SU PARKLARI VE HAVUZ SİSTEMLERİ A.Ş.", new Font("Calibri",16, FontStyle.Regular), Brushes.Black, 200, 85);
    e.Graphics.DrawString("VARLIK ZİMMET FORMU", new Font("Calibri", 16, FontStyle.Regular), Brushes.Black, 310, 120);
    e.Graphics.DrawString("Aşağıda özellikleri belirtilen cihaz veya yazılımı, belirtilen özellikleri ile birlikte eksiksiz olarak teslim aldım.", new Font("Calibri", 11, FontStyle.Regular), Brushes.Black, 60, 215);
    e.Graphics.DrawString("Zimmetlenen Personel", new Font("Calibri", 14, FontStyle.Regular), Brushes.Black, 550, 400);
    e.Graphics.DrawString(textBox10.Text, new Font("Calibri", 14, FontStyle.Regular), Brushes.Black, 550, 430);

    e.Graphics.DrawString("Zimmetleyen BT Sorumlusu", new Font("Calibri", 14, FontStyle.Regular), Brushes.Black, 60, 400);
    e.Graphics.DrawString(textBox11.Text.ToUpper(), new Font("Calibri", 14, FontStyle.Regular), Brushes.Black, 60, 430);

    e.Graphics.DrawString(": "+textBox9.Text, new Font("Calibri", 12, FontStyle.Regular), Brushes.Black, 570, 280);
    e.Graphics.DrawString("2.HDD", new Font("Calibri", 12, FontStyle.Regular), Brushes.Black, 450, 280);
    
    e.Graphics.DrawString(": " + textBox8.Text, new Font("Calibri", 12, FontStyle.Regular), Brushes.Black, 570, 260);
    e.Graphics.DrawString("1.HDD", new Font("Calibri", 12, FontStyle.Regular), Brushes.Black, 450, 260);
    
    e.Graphics.DrawString(": " + textBox6.Text, new Font("Calibri", 12, FontStyle.Regular), Brushes.Black, 570, 300);
    e.Graphics.DrawString("İŞLEMCİ", new Font("Calibri", 12, FontStyle.Regular), Brushes.Black, 450, 300);
    
    e.Graphics.DrawString(": " + textBox5.Text, new Font("Calibri", 12, FontStyle.Regular), Brushes.Black, 570, 320);
    e.Graphics.DrawString("SERİ NO", new Font("Calibri", 12, FontStyle.Regular), Brushes.Black, 450, 320);

            e.Graphics.DrawString(": " + DateTime.Now.ToShortDateString(), new Font("Calibri", 12, FontStyle.Regular), Brushes.Black, 570, 340);
            e.Graphics.DrawString("ZİMMET TARİHİ", new Font("Calibri", 12, FontStyle.Regular), Brushes.Black, 450, 340);



            e.Graphics.DrawString(": " , new Font("Calibri", 12, FontStyle.Regular), Brushes.Black, 570, 360);
            e.Graphics.DrawString("İADE TARİHİ", new Font("Calibri", 12, FontStyle.Regular), Brushes.Black, 450, 360);


            e.Graphics.DrawString(": " + textBox7.Text, new Font("Calibri", 12, FontStyle.Regular), Brushes.Black, 150, 340);
    e.Graphics.DrawString("RAM", new Font("Calibri", 12, FontStyle.Regular), Brushes.Black, 60, 340);
    
    e.Graphics.DrawString(": " + textBox4.Text, new Font("Calibri", 12, FontStyle.Regular), Brushes.Black, 150, 320);
    e.Graphics.DrawString("MODEL", new Font("Calibri", 12, FontStyle.Regular), Brushes.Black, 60, 320);
    
    e.Graphics.DrawString(": " + textBox3.Text, new Font("Calibri", 12, FontStyle.Regular), Brushes.Black, 150, 300);
    e.Graphics.DrawString("MARKA", new Font("Calibri", 12, FontStyle.Regular), Brushes.Black, 60, 300);
   
    e.Graphics.DrawString(": " + textBox2.Text, new Font("Calibri", 12, FontStyle.Regular), Brushes.Black, 150, 280);
    e.Graphics.DrawString("ÜRÜN TİPİ", new Font("Calibri", 12, FontStyle.Regular), Brushes.Black, 60, 280);

    e.Graphics.DrawString(": " + textBox1.Text, new Font("Calibri", 12, FontStyle.Regular), Brushes.Black, 150, 260);
    e.Graphics.DrawString("BARKOD NO", new Font("Calibri", 12, FontStyle.Regular), Brushes.Black, 60, 260);






    e.Graphics.DrawString("POLİN SU PARKLARI VE HAVUZ SİSTEMLERİ A.Ş.", new Font("Calibri", 16, FontStyle.Regular), Brushes.Black, 200, 670);
    e.Graphics.DrawString("VARLIK ZİMMET FORMU", new Font("Calibri", 16, FontStyle.Regular), Brushes.Black, 310, 705);
    e.Graphics.DrawString("Aşağıda özellikleri belirtilen cihaz veya yazılımı, belirtilen özellikleri ile birlikte eksiksiz olarak teslim aldım.", new Font("Calibri", 11, FontStyle.Regular), Brushes.Black, 60, 800);
    e.Graphics.DrawString("Zimmetlenen Personel", new Font("Calibri", 14, FontStyle.Regular), Brushes.Black, 550, 1000);
    e.Graphics.DrawString("Zimmetleyen BT Sorumlusu", new Font("Calibri", 14, FontStyle.Regular), Brushes.Black, 60, 1000);
    e.Graphics.DrawString(textBox10.Text, new Font("Calibri", 14, FontStyle.Regular), Brushes.Black, 550, 1030);
    e.Graphics.DrawString(textBox11.Text.ToUpper(), new Font("Calibri", 14, FontStyle.Regular), Brushes.Black, 60, 1030);

    
    e.Graphics.DrawString(": " + textBox9.Text, new Font("Calibri", 12, FontStyle.Regular), Brushes.Black, 570, 880);
    e.Graphics.DrawString("2.HDD", new Font("Calibri", 12, FontStyle.Regular), Brushes.Black, 450, 880);
    
    e.Graphics.DrawString(": " + textBox8.Text, new Font("Calibri", 12, FontStyle.Regular), Brushes.Black, 570, 860);
    e.Graphics.DrawString("1.HDD", new Font("Calibri", 12, FontStyle.Regular), Brushes.Black, 450, 860);
    
    e.Graphics.DrawString(": " + textBox6.Text, new Font("Calibri", 12, FontStyle.Regular), Brushes.Black, 570, 900);
    e.Graphics.DrawString("İŞLEMCİ", new Font("Calibri", 12, FontStyle.Regular), Brushes.Black, 450, 900);
    
    e.Graphics.DrawString(": " + textBox5.Text, new Font("Calibri", 12, FontStyle.Regular), Brushes.Black, 570, 920);
    e.Graphics.DrawString("SERİ NO", new Font("Calibri", 12, FontStyle.Regular), Brushes.Black, 450, 920);

            e.Graphics.DrawString(": " + DateTime.Now.ToShortDateString(), new Font("Calibri", 12, FontStyle.Regular), Brushes.Black, 570, 940);
            e.Graphics.DrawString("ZİMMET TARİHİ", new Font("Calibri", 12, FontStyle.Regular), Brushes.Black, 450, 940);



            e.Graphics.DrawString(": ", new Font("Calibri", 12, FontStyle.Regular), Brushes.Black, 570, 960);
            e.Graphics.DrawString("İADE TARİHİ", new Font("Calibri", 12, FontStyle.Regular), Brushes.Black, 450, 960);



            e.Graphics.DrawString(": " + textBox7.Text, new Font("Calibri", 12, FontStyle.Regular), Brushes.Black, 150, 940);
    e.Graphics.DrawString("RAM", new Font("Calibri", 12, FontStyle.Regular), Brushes.Black, 60, 940);
  
    e.Graphics.DrawString(": " + textBox4.Text, new Font("Calibri", 12, FontStyle.Regular), Brushes.Black, 150, 920);
    e.Graphics.DrawString("MODEL", new Font("Calibri", 12, FontStyle.Regular), Brushes.Black, 60, 920);
   
    e.Graphics.DrawString(": " + textBox3.Text, new Font("Calibri", 12, FontStyle.Regular), Brushes.Black, 150, 900);
    e.Graphics.DrawString("MARKA", new Font("Calibri", 12, FontStyle.Regular), Brushes.Black, 60, 900);
  
    e.Graphics.DrawString(": " + textBox2.Text, new Font("Calibri", 12, FontStyle.Regular), Brushes.Black, 150, 880);
    e.Graphics.DrawString("ÜRÜN TİPİ", new Font("Calibri", 12, FontStyle.Regular), Brushes.Black, 60, 880);

    e.Graphics.DrawString(": " + textBox1.Text, new Font("Calibri", 12, FontStyle.Regular), Brushes.Black, 150, 860);
    e.Graphics.DrawString("BARKOD NO", new Font("Calibri", 12, FontStyle.Regular), Brushes.Black, 60, 860);



    //e.Graphics.DrawLine(myPen, 5, 5, 236, 5);
    float newWidth = pictureBox1.Image.Width * 10 / pictureBox1.Image.HorizontalResolution;
    float newHeight = pictureBox1.Image.Height * 10 / pictureBox1.Image.VerticalResolution;
    float widthFactor = newWidth / e.MarginBounds.Width;
    float heightFactor = newHeight / e.MarginBounds.Height;
    float newWidth2 = Properties.Resources.logo_polin.Width * 100 / Properties.Resources.logo_polin.HorizontalResolution;
    float newHeight2 = Properties.Resources.logo_polin.Height * 60 / Properties.Resources.logo_polin.VerticalResolution;
    float widthFactor2 = newWidth2 / e.MarginBounds.Width;
    float heightFactor2 = newHeight2 / e.MarginBounds.Height;
    e.Graphics.DrawImage(Properties.Resources.logo_polin, 60, 10, (int)newWidth2, (int)newHeight2);
    e.Graphics.DrawImage(Properties.Resources.logo_polin, 60, 595, (int)newWidth2, (int)newHeight2);


}

private void button2_Click(object sender, EventArgs e)
{
    if (etiketbuton.Checked)
    {
       etiket.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("etiket", 236, 157);

        printPreviewDialog1.Document = etiket;
        printPreviewDialog1.ShowDialog();

    }
    else if (zimmetbuton.Checked)
    {
 
     //   printDocument1.DefaultPageSettings.Landscape = false;
        zimmet.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("A4", 830, 1170);
        printPreviewDialog1.Document = zimmet;
        printPreviewDialog1.ShowDialog();

    }












}

private void textBox1_TextChanged(object sender, EventArgs e)
{

}

private void textBox11_TextChanged(object sender, EventArgs e)
{

}







    }
}


