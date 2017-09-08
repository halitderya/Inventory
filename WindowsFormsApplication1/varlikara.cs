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

namespace WindowsFormsApplication1
{
    public partial class varlikara : Form
    {
        public varlikara()
        {

        InitializeComponent();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void varlikara_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=IT-HALITDERYA3\\SQLEXPRESS;Initial Catalog=ENVANTER;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT BARKOD from ENVTABLO", conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
                comboBox1.Items.Add(dr["BARKOD"]);
                      conn.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            anasayfa frm1 = new anasayfa();
            frm1.Show();
            this.Hide();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {

          
            string baglancumlesi = "Data Source=IT-HALITDERYA3\\SQLEXPRESS;Initial Catalog=ENVANTER;Integrated Security=True;";
            SqlConnection baglan = new SqlConnection(baglancumlesi);
            SqlCommand markabul = new SqlCommand("SELECT [ÜRÜN TİPİ],MARKA,[Model / Sürüm],[Seri No] FROM ENVTABLO where barkod=('" + comboBox1.Text + "')", baglan);
            SqlCommand markabul2 = new SqlCommand("SELECT işlemci,ram,hdd,hdd2,[Monitör] FROM ENVTABLO where barkod=('" + comboBox1.Text + "')", baglan);
            SqlCommand markabul3 = new SqlCommand("select [İşletim sistemi], office, [Ürün Giriş Tarihi] from ENVTABLO where barkod=('" + comboBox1.Text + "')", baglan);
            SqlCommand resimbul = new SqlCommand("select resim from ENVTABLO WHERE barkod=('" + comboBox1.Text + "')", baglan);
            SqlDataAdapter markabulda3 = new SqlDataAdapter(markabul3);
            SqlDataAdapter markabulda2 = new SqlDataAdapter(markabul2);
            SqlDataAdapter markabulda = new SqlDataAdapter(markabul);
            SqlDataAdapter resimbulda = new SqlDataAdapter(resimbul);
            DataTable dtmarkabul = new DataTable();
            DataTable dtmarkabul2 = new DataTable();
            DataTable dtmarkabul3 = new DataTable();
            DataTable dtresimbul = new DataTable();
            markabulda2.Fill(dtmarkabul2);
            markabulda.Fill(dtmarkabul);
            markabulda3.Fill(dtmarkabul3);
            resimbulda.Fill(dtresimbul);
            dataGridView3.DataSource = dtmarkabul3;
            dataGridView2.DataSource = dtmarkabul2;
            dataGridView1.DataSource = dtmarkabul;
            dataGridView2.DataSource = dtmarkabul2;
            //picturebox text
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.Dispose();
                pictureBox1.Image = null;
            }
            resimbul.Parameters.AddWithValue("@BARKOD", comboBox1.Text);
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
          










        }
    }
}
