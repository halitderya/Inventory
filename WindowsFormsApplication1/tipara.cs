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
    public partial class tipara : Form
    {
        public tipara()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            string baglancumlesi = "Data Source=IT-HALITDERYA3\\SQLEXPRESS;Initial Catalog=ENVANTER;Integrated Security=True;";

            SqlConnection baglan = new SqlConnection(baglancumlesi);
            SqlCommand markabul = new SqlCommand("SELECT BARKOD, MARKA,[Model / Sürüm],[Seri No] FROM ENVTABLO where [ÜRÜN TİPİ]=('" + comboBox1.Text + "')", baglan);
            SqlDataAdapter markabulda = new SqlDataAdapter(markabul);
            DataTable dtmarkabul = new DataTable();
            markabulda.Fill(dtmarkabul);
            dataGridView1.DataSource = dtmarkabul;




        }

        private void tipara_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=IT-HALITDERYA3\\SQLEXPRESS;Initial Catalog=ENVANTER;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT DISTINCT [ÜRÜN TİPİ] from ENVTABLO", conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
                comboBox1.Items.Add(dr["ÜRÜN TİPİ"]);

            conn.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            anasayfa frm1 = new anasayfa();
            frm1.Show();
            this.Close();
        }
    }
}
