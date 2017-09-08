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
    public partial class durumsil : Form
    {
        public durumsil()
        {
            InitializeComponent();
        }

        private void durumsil_Load(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection("Data Source=IT-HALITDERYA3\\SQLEXPRESS;Initial Catalog=ENVANTER;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT TAMAD from personel", conn);

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
            anasayfa frm4 = new anasayfa();

            frm4.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //sil butonu
            if (comboBox1.SelectedIndex > -1)
            {
                if (MessageBox.Show(comboBox1.SelectedItem + " Silinecektir. Bu işlem geri alınamaz. Devam Etmek İstiyor Musunuz?", "Silme İşlemini Onayla", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    string baglancumlesi = "Data Source=IT-HALITDERYA3\\SQLEXPRESS;Initial Catalog=ENVANTER;Integrated Security=True;";
                    SqlConnection baglan = new SqlConnection(baglancumlesi);
                    baglan.Open();
                    SqlCommand sil = new SqlCommand("delete from personel where TAMAD='" + comboBox1.Text + "'", baglan);
                    int etki = sil.ExecuteNonQuery();
                    MessageBox.Show(etki.ToString() + " Adet Kayıt Silindi", "Sil");
                    comboBox1.SelectedIndex = -1;
                    comboBox1.Refresh();
                }
                else
                {

                }

            }

            else

            {
               DialogResult sonuc = MessageBox.Show("Öncelikle bir değer getiriniz", "Getirilemedi", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
               if (sonuc == DialogResult.OK)
               {

                   
               }
                   
               
               else if (sonuc==DialogResult.Cancel)
               {
                   anasayfa frm4 = new anasayfa();

                   frm4.Show();
                   this.Hide();


               }


            }



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection("Data Source=IT-HALITDERYA3\\SQLEXPRESS;Initial Catalog=ENVANTER;Integrated Security=True");
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

