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
using System.IO;
#pragma warning disable CS0105 // Using directive appeared previously in this namespace
using System.Configuration;
#pragma warning restore CS0105 // Using directive appeared previously in this namespace

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

        }

        private void tipara_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ToString());
            SqlCommand cmd = new SqlCommand("SELECT DISTINCT [ÜRÜN TİPİ] from ENVTABLO", conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
                comboBox1.Items.Add(dr["ÜRÜN TİPİ"]);

            conn.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string baglancumlesi = ConfigurationManager.ConnectionStrings["connection"].ToString();
            SqlConnection baglan = new SqlConnection(baglancumlesi);
            SqlCommand Markabul = new SqlCommand("SELECT  j.[BARKOD],[ÜRÜN TİPİ],Marka,[Model / Sürüm],[Seri No],HDD,HDD2,İşlemci,RAM, [İşletim Sistemi],office,TAMADI FROM    ENVTABLO j OUTER APPLY (SELECT  TOP 1 * FROM    sahiplik js WHERE   js.BARKOD = j.BARKOD  ORDER BY js.zimmet_tarihi DESC ) js where  j.[ÜRÜN TİPİ]=('" + comboBox1.Text + "')", baglan);
            SqlDataAdapter Markabulda = new SqlDataAdapter(Markabul);
            DataTable dtMarkabul = new DataTable();
            Markabulda.Fill(dtMarkabul);
            dataGridView1.DataSource = dtMarkabul;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void ToCsV(DataGridView dGV, string filename)
        {
            string stOutput = "";
            string sHeaders = "";

            for (int j = 0; j < dGV.Columns.Count; j++)
                sHeaders = sHeaders.ToString() + Convert.ToString(dGV.Columns[j].HeaderText) + "\t";
            stOutput += sHeaders + "\r\n";
            for (int i = 0; i < dGV.RowCount - 1; i++)
            {
                string stLine = "";
                for (int j = 0; j < dGV.Rows[i].Cells.Count; j++)
                    stLine = stLine.ToString() + Convert.ToString(dGV.Rows[i].Cells[j].Value) + "\t";
                stOutput += stLine + "\r\n";
            }
            Encoding iso = Encoding.GetEncoding("ISO-8859-1");
                       
            
            byte[] output = iso.GetBytes(stOutput);
            FileStream fs = new FileStream(filename, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(output, 0, output.Length); 
            bw.Flush();
            bw.Close();
            fs.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Çalışma Kitabı (*.xls)|*.xls";
            sfd.FileName = comboBox1.Text+"_Urun_tipindeki_Tum_Urunler.xls";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                ToCsV(dataGridView1, sfd.FileName); 
            }
        }  
    
    
    
    }
}
