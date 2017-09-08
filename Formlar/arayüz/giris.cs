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
using System.Collections;




namespace WindowsFormsApplication1
{


    public partial class giris : Form
    {
        System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();

        


        public giris()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
           

        }


               private void button1_Click(object sender, EventArgs e)
        {
            

            ArrayList aList = new ArrayList();
            aList.Add("or");
            aList.Add("and");
            aList.Add("insert");
            aList.Add("update");
            aList.Add("select");
            aList.Add("delete");
            aList.Add(" ");
            aList.Add("'\\'");
            aList.Add("' OR 1=1 OR '");
            aList.Add("' --'");
            aList.Add("*");

            if (aList.Contains(textBox1.Text) || aList.Contains(maskedTextBox1.Text))
            {
                MessageBox.Show("Kullanıcı adı veya parolanızda yasaklı kelime tespit edildi!", "Giriş Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }



            try
            {

               
                if (!(textBox1.Text == string.Empty))
                {
                    if (!(maskedTextBox1.Text == string.Empty))
                    {
                        String str = ConfigurationManager.ConnectionStrings["connection"].ToString();

                        String yetkisorgu = "select * from kullanici where ad ='" + textBox1.Text + "'  and yetki='2'  ";
                        SqlConnection con = new SqlConnection(str);
                        SqlCommand cmd = new SqlCommand("select * from kullanici where ad = '" +textBox1.Text+ "' and sifre ='" + maskedTextBox1.Text + "'", con);
                        SqlCommand cmdyetki = new SqlCommand(yetkisorgu, con);

                        SqlDataReader dbr;
                        SqlDataReader yetkidr;
                       
                        con.Open();
                        yetkidr = cmdyetki.ExecuteReader();
                        dbr = cmd.ExecuteReader();
                        int yetkiint = 0;
                        int count = 0;
                        while (dbr.Read())
                        {
                            count = count + 1;
                        }
                        while (yetkidr.Read())
                        {
                            yetkiint = yetkiint + 1;
                        }
                        if (count == 1)
                        {
                       
                              if (yetkiint == 1)
                              {


                                  this.Hide();
                                  textBox1.Text = textBox1.Text.ToUpper();
                                  karsilama kar = new karsilama();
                                  kar.passvalue = textBox1.Text;
                                  kar.ShowDialog();
                                  

                                  
                               



                              }

                              else 
                              {
                                  this.Hide();
                                  textBox1.Text = textBox1.Text.ToUpper();
                                  karsilama kar = new karsilama();
                                  kar.passvalue = textBox1.Text;
                                  kar.ShowDialog();
                              }

                          }
                        
                        else if (count > 1)
                        {
                            MessageBox.Show("Hatalı Giriş", "Giriş başarısız");
                        }
                        else
                        {
                            MessageBox.Show("Kullanıcı adı veya parola yanlış", "Giriş Başarısız",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show(" Parola Boş Olamaz!", "Giriş Başarısız");
                    }
                }
 
                else
                {
                    MessageBox.Show(" Kullanıcı adı boş olamaz", "Giriş Başarısız");
                }
                    // con.Close();


                


            
                }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
 
            }





        }

               private void giris_Load(object sender, EventArgs e)
               {








            Configuration config = ConfigurationManager.OpenExeConfiguration("Envanter.exe");

                   ConnectionStringsSection section = config.GetSection("connectionStrings") as ConnectionStringsSection;

                   if (section.SectionInformation.IsProtected)
                   {
                       section.SectionInformation.UnprotectSection();
                   }
                   else
                   {
                       section.SectionInformation.ProtectSection("DataProtectionConfigurationProvider");
                   }
                   config.Save();
                   
                   this.AcceptButton = button1;
               }

               private void button2_Click_1(object sender, EventArgs e)
               {
                   Application.Exit();
                   
               }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
