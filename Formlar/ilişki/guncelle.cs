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
using System.Configuration;

namespace WindowsFormsApplication1
{
    public partial class guncelle : Form
    {

        private string gunc;
        public string guncpass
        {
            get { return gunc; }
            set { gunc = value; }

        }

        private string gunc2;
        public string guncpass2
        {
            get { return gunc2; }
            set { gunc2 = value; }

        }


        public guncelle()
        {
            InitializeComponent();
            string baglanticumlesi = ConfigurationManager.ConnectionStrings["connection"].ToString();
            SqlConnection baglan = new SqlConnection(baglanticumlesi);
            baglan.Open();


        }

        private void guncelle_Load(object sender, EventArgs e)
        {
            if (gunc2 != null)
            {
                 combobarkod.Text = gunc2;
                yukle();
            }

            // textBox1.Text = gunc;
            textBox1.Text = gunc;
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ToString());
            SqlCommand cmd = new SqlCommand("SELECT BARKOD from ENVTABLO", conn);
            SqlCommand cmd2 = new SqlCommand("SELECT TAMAD FROM PERSONEL order by TAMAD asc", conn);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT TOP 1 TAMADI FROM ENVTABLO LEFT JOIN sahiplik ON ENVTABLO.BARKOD=sahiplik.BARKOD WHERE sahiplik.BARKOD=('" + combobarkod.Text + "') ORDER BY zimmet_tarihi desc",conn);
            da.Fill(dt);

            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            SqlDataReader DR2 = cmd2.ExecuteReader();
            while (dr.Read())
                combobarkod.Items.Add(dr["BARKOD"]);
            while (DR2.Read())
                comboBox1.Items.Add(DR2["TAMAD"]);
            conn.Close();


            





        }


        private void yukle()
        {





            string baglancumlesi = ConfigurationManager.ConnectionStrings["connection"].ToString();

            SqlConnection baglan = new SqlConnection(baglancumlesi);
            SqlCommand Markabul = new SqlCommand("SELECT [ÜRÜN TİPİ],Marka,[Model / Sürüm],[Seri No] FROM ENVTABLO where barkod=('" + combobarkod.Text + "')", baglan);
            SqlCommand Markabul2 = new SqlCommand("SELECT İşlemci,ram,hdd,hdd2,[Ürün Giriş Tarihi] FROM ENVTABLO where barkod=('" + combobarkod.Text + "')", baglan);
            SqlDataAdapter Markabulda2 = new SqlDataAdapter(Markabul2);
            SqlDataAdapter Markabulda = new SqlDataAdapter(Markabul);
            DataTable dtMarkabul = new DataTable();
            DataTable dtMarkabul2 = new DataTable();
            Markabulda2.Fill(dtMarkabul2);
            Markabulda.Fill(dtMarkabul);
            dataGridView2.DataSource = dtMarkabul2;
            dataGridView1.DataSource = dtMarkabul;
            dataGridView2.DataSource = dtMarkabul2;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView2.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            string getir = "SELECT TOP 1 TAMADI FROM ENVTABLO LEFT JOIN sahiplik ON ENVTABLO.BARKOD=sahiplik.BARKOD WHERE sahiplik.BARKOD=('" + combobarkod.Text + "') ORDER BY zimmet_tarihi desc";

            SqlCommand denetle = new SqlCommand(getir, baglan);
            baglan.Open();
            SqlDataReader denetledr = denetle.ExecuteReader();





            int denetleint = 0;
            while (denetledr.Read())
            {
                denetleint = denetleint + 1;
            }


            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(getir, baglan);
            da.Fill(dt);
            if (denetleint > 0)
            {
                label3.Text = dt.Rows[0][0].ToString();
            }
            else
            {
                label3.Text = "Boşta";
            }


        }

        private void combobarkod_SelectedIndexChanged(object sender, EventArgs e)
        {
            yukle();

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
            string baglancumlesi = ConfigurationManager.ConnectionStrings["connection"].ToString();

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
            try
            {
                this.sahiplikTableAdapter3.FillBy4(this.eNVANTERDataSet4.sahiplik);
            }
            catch (System.Exception ex)
            {
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
            if (dataGridView1.RowCount == 0)
            {
                MessageBox.Show("Lütfen Bir Barkod Seçiniz", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
            else if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen Zimmetlenecek Kişiyi Seçiniz", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
            else
            //artık zimmetliyoruz
            {
                try { 


                string baglancumlesi = ConfigurationManager.ConnectionStrings["connection"].ToString();
                string getir = "SELECT TOP 1 TAMADI FROM ENVTABLO LEFT JOIN sahiplik ON ENVTABLO.BARKOD=sahiplik.BARKOD WHERE sahiplik.BARKOD=('" + combobarkod.Text + "') ORDER BY zimmet_tarihi desc";
                SqlConnection baglan = new SqlConnection(baglancumlesi);
                baglan.Open();
                SqlCommand denetle = new SqlCommand(getir, baglan);
                SqlDataReader denetledr = denetle.ExecuteReader();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(getir, baglan);
                da.Fill(dt);
                int denetleint = 0;

                while (denetledr.Read())
                {
                    denetleint = denetleint + 1;
                }

                if (denetleint > 0)
                {
                    DialogResult dr2 = MessageBox.Show(dt.Rows[0][0].ToString() + " Üzerinde bulunan " + combobarkod.Text + " barkod numaralı cihazı " + comboBox1.Text + " kişisine zimmetliyorsunuz. ", "Emin Misiniz?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dr2 == DialogResult.Yes)
                    {
                        SqlCommand zimmet = new SqlCommand("INSERT INTO sahiplik (BARKOD,TAMADI,zimmet_tarihi,it) VALUES ('" + combobarkod.Text + "','" + comboBox1.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + "' ,'" + textBox1.Text + "')", baglan);

                        int guncel = zimmet.ExecuteNonQuery();
                        if (guncel > 0)
                        {
                            DialogResult dr = MessageBox.Show(combobarkod.Text.ToString() + " Barkod numaralı ürünün sahibi güncellenmiştir. Zimmet Formu Yazdırmak İster misiniz?", "Başarılı", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                            if (dr == DialogResult.Yes)
                            {
                                qrcode2 qr2 = new qrcode2();
                                qr2.passvalue = combobarkod.Text;
                                qr2.ShowDialog();
                                this.Hide();

                            }
                            else
                            {

                            }
                        }

                    }
                }



                else
                {
                    //kimseye zimmetli değildi
                    SqlCommand zimmet = new SqlCommand("INSERT INTO sahiplik (BARKOD,TAMADI,zimmet_tarihi,it) VALUES ('" + combobarkod.Text + "','" + comboBox1.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + "' ,'" + textBox1.Text + "')", baglan);

                    int guncel = zimmet.ExecuteNonQuery();
                    if (guncel > 0)
                    {
                        DialogResult dr = MessageBox.Show(combobarkod.Text.ToString() + " Barkod numaralı ürünün sahibi güncellenmiştir. Zimmet Formu Yazdırmak İster misiniz?", "Başarılı", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        if (dr == DialogResult.Yes)
                        {
                            qrcode2 qr2 = new qrcode2();
                            qr2.passvalue = combobarkod.Text;
                            qr2.ShowDialog();
                            this.Hide();
                        }
                        else
                        {

                        }


                    }



                    else
                    {
                        MessageBox.Show("Hiçbir Kayıt Güncellenemedi", "Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        baglan.Close();


                    }







                }
            }
                catch (Exception ex )
                {
                    MessageBox.Show("Zimmetleme Başarısız. Sebep : "+ ex.Message);
                }
            }
            



        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Close();





        }

    }
}
