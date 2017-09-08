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
    public partial class durumsil : Form
    {
        public durumsil()
        {
            InitializeComponent();
        }

        private void durumsil_Load(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ToString());
            SqlCommand cmd = new SqlCommand("SELECT TAMAD from personel order by TAMAD asc", conn);

            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
                comboBox1.Items.Add(dr["TAMAD"] );
            comboBox1.ValueMember = "ID";

                  conn.Close();



        }
     
        //geri butonu
        private void button3_Click(object sender, EventArgs e)
        {

            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string baglancumlesi = ConfigurationManager.ConnectionStrings["connection"].ToString();
            SqlConnection baglan = new SqlConnection(baglancumlesi);
            int denetleint = 0;
            baglan.Open();
            SqlCommand denetle = new SqlCommand("SELECT  env.[BARKOD],[ÜRÜN TİPİ],Marka,[Model / Sürüm],[Seri No],HDD,HDD2,İşlemci,RAM, [İşletim Sistemi],office,TAMAD,zimmet_tarihi,DEPARTMAN FROM  ENVTABLO env OUTER APPLY (SELECT TOP 1 * FROM sahiplik sah where   env.BARKOD = sah.BARKOD ORDER BY sah.zimmet_tarihi DESC  ) sah  OUTER APPLY (SELECT * FROM PERSONEL per  where  per.TAMAD=SAH.TAMADI) per where per.TAMAD=('" + comboBox1.Text + "')", baglan);
            if (baglan.State == ConnectionState.Closed)
            {
                baglan.Open();
            }
            SqlDataReader denetledr = denetle.ExecuteReader();


            while (denetledr.Read())
            {
                denetleint = denetleint + 1;
            }

            


                if (comboBox1.SelectedIndex > -1)
                {
                    if (denetleint == 0)
                    {
                    if (MessageBox.Show(comboBox1.SelectedItem + " Silinecektir. Bu işlem geri alınamaz. Devam Etmek İstiyor Musunuz?", "Silme İşlemini Onayla", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        if (baglan.State == ConnectionState.Closed)
                        {
                            baglan.Open();
                        }
                        
                        SqlCommand sil = new SqlCommand("delete from personel where TAMAD='" + comboBox1.Text + "'", baglan);
                        int etki = sil.ExecuteNonQuery();
                        MessageBox.Show(etki.ToString() + " Adet Kayıt Silindi", "Sil");
                        comboBox1.SelectedIndex = -1;
                        comboBox1.Refresh();
                        baglan.Close();
                    }
                    else
                    {

                    }
            }
                    else
                    {
                        MessageBox.Show("Personelin Üzerinde "+ denetleint.ToString() +" adet zimmet var. Lütfen önce zimmetleri temizleyiniz.", "Silinemedi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }

            else
            {
                DialogResult sonuc = MessageBox.Show("Öncelikle bir personel getiriniz", "Başarısız", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
                if (sonuc == DialogResult.OK)
                {


                }


                else if (sonuc == DialogResult.Cancel)
                {
                    anasayfa frm4 = new anasayfa();

                    frm4.Show();
                    this.Hide();


                }


            }



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ToString());
            SqlCommand tamadbul = new SqlCommand("SELECT AD,SOYAD,GOREV,FIRMA,DEPARTMAN FROM PERSONEL where TAMAD=('" + comboBox1.Text + "')", conn);
            conn.Open();
            DataTable dttamadbul = new DataTable();
            SqlDataAdapter tamadbulda = new SqlDataAdapter(tamadbul);
            tamadbulda.Fill(dttamadbul);
            dataGridView1.DataSource=(dttamadbul);

            conn.Close();
       
        }
        

               
        }
    }

