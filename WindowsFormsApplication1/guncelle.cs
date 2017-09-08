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
    public partial class guncelle : Form
    {


        public guncelle()
        {
            InitializeComponent();
           string baglanticumlesi = "Data Source=IT-HALITDERYA3\\SQLEXPRESS;Initial Catalog=ENVANTER;Integrated Security=True;";
           SqlConnection baglan = new SqlConnection(baglanticumlesi);
            baglan.Open();


        }

        private void guncelle_Load(object sender, EventArgs e)
        {


            SqlConnection conn = new SqlConnection("Data Source=IT-HALITDERYA3\\SQLEXPRESS;Initial Catalog=ENVANTER;Integrated Security=True;MultipleActiveResultSets=True");
            SqlCommand cmd = new SqlCommand("SELECT BARKOD from ENVTABLO", conn);
            SqlCommand cmd2 = new SqlCommand("SELECT TAMAD FROM PERSONEL", conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            SqlDataReader DR2 = cmd2.ExecuteReader();
            while (dr.Read())
                combobarkod.Items.Add(dr["BARKOD"]);
            while (DR2.Read())
                comboBox1.Items.Add(DR2["TAMAD"]);
            conn.Close();








        }




        private void combobarkod_SelectedIndexChanged(object sender, EventArgs e)
        {
            




            string baglancumlesi = "Data Source=IT-HALITDERYA3\\SQLEXPRESS;Initial Catalog=ENVANTER;Integrated Security=True;";
            
            SqlConnection baglan = new SqlConnection(baglancumlesi);
            SqlCommand markabul = new SqlCommand("SELECT [ÜRÜN TİPİ],MARKA,[Model / Sürüm],[Seri No] FROM ENVTABLO where barkod=('" + combobarkod.Text + "')", baglan);
            SqlCommand markabul2 = new SqlCommand("SELECT işlemci,ram,hdd,hdd2,[Ürün Giriş Tarihi] FROM ENVTABLO where barkod=('" + combobarkod.Text + "')", baglan);
            SqlDataAdapter markabulda2 = new SqlDataAdapter (markabul2);
            SqlDataAdapter markabulda = new SqlDataAdapter(markabul);
            DataTable dtmarkabul = new DataTable();
            DataTable dtmarkabul2 = new DataTable();
            markabulda2.Fill(dtmarkabul2);
            markabulda.Fill(dtmarkabul);
            dataGridView2.DataSource = dtmarkabul2;
            dataGridView1.DataSource = dtmarkabul;
            dataGridView2.DataSource = dtmarkabul2;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView2.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView2.AllowUserToDeleteRows = false;






        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.sahiplikTableAdapter3.FillBy(this.eNVANTERDataSet4.sahiplik);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string baglancumlesi = "Data Source=IT-HALITDERYA3\\SQLEXPRESS;Initial Catalog=ENVANTER;Integrated Security=True;";

            SqlConnection baglan = new SqlConnection(baglancumlesi);
            SqlCommand sahipbul = new SqlCommand("SELECT [AD],[SOYAD],[FIRMA],[DEPARTMAN],[GOREV] FROM PERSONEL where TAMAD=('" + comboBox1.Text + "')", baglan);
            SqlDataAdapter sahipbulda = new SqlDataAdapter(sahipbul);
            DataTable dtsahipbul = new DataTable();
            sahipbulda.Fill(dtsahipbul);
            grid3.DataSource = dtsahipbul;







            

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.sahiplikTableAdapter3.FillBy1(this.eNVANTERDataSet4.sahiplik);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy2ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.sahiplikTableAdapter3.FillBy2(this.eNVANTERDataSet4.sahiplik);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy4ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.sahiplikTableAdapter3.FillBy4(this.eNVANTERDataSet4.sahiplik);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy4ToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.sahiplikTableAdapter3.FillBy4(this.eNVANTERDataSet4.sahiplik);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy4ToolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                this.sahiplikTableAdapter3.FillBy4(this.eNVANTERDataSet4.sahiplik);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy4ToolStripButton3_Click(object sender, EventArgs e)
        {
            try
            {
                this.sahiplikTableAdapter3.FillBy4(this.eNVANTERDataSet4.sahiplik);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy4ToolStripButton4_Click(object sender, EventArgs e)
        {
try {
    this.sahiplikTableAdapter3.FillBy4(this.eNVANTERDataSet4.sahiplik);
}
catch (System.Exception ex) {
    System.Windows.Forms.MessageBox.Show(ex.Message);
}

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void butonguncelle_Click(object sender, EventArgs e)
        {
            if (combobarkod.SelectedIndex==-1)

            {
                MessageBox.Show("Lütfen Bir Varlık Seçiniz", "Eksik Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Stop);

            }
            else if (comboBox1.SelectedIndex==-1)
            {
                MessageBox.Show("Lütfen Zimmetlenecek Kişiyi Seçiniz","Eksik Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Stop);

            }
            else{
                       string baglancumlesi = "Data Source=IT-HALITDERYA3\\SQLEXPRESS;Initial Catalog=ENVANTER;Integrated Security=True;";
            
            SqlConnection baglan = new SqlConnection(baglancumlesi);
            baglan.Open();
            SqlCommand zimmet = new SqlCommand("INSERT INTO sahiplik (barkod,zimmet_tarihi,TAMADI) VALUES (COMBOBARKOD,comboBox1,dateisimtar)", baglan);
              int guncel = zimmet.ExecuteNonQuery();
                MessageBox.Show(guncel.ToString());
                baglan.Close();


            }
  





        }

        private void button1_Click(object sender, EventArgs e)
        {
            anasayfa frm1 = new anasayfa();
            frm1.Show();
            this.Close();





        }
    }
}

