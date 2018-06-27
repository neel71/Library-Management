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
using System.IO;

namespace Final_Library_Project
{
    public partial class Show_student_Details : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Visual Studio\Final_Library_Project_Solution\Final_Library_Project\Library_database.mdf;Integrated Security=True");


        public Show_student_Details()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Show_student_Details_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
            if (con.State == ConnectionState.Open)
            {
                con.Close();

            }
            con.Open();
            label10_Lid.Text = Student_Update_Delete.SetValue;
            SqlCommand cmd = new SqlCommand("select * from student where student_lib_id ='" + label10_Lid.Text + "'  ", con);
            SqlDataReader SDR = cmd.ExecuteReader();
            {
                while (SDR.Read())
                {
                    label11_sid.Text = SDR["student_id"].ToString();
                    label18_sname.Text = SDR["name"].ToString();
                    label12_email.Text = SDR["email"].ToString();
                    label13_address.Text = SDR["address"].ToString();
                    label15_gender.Text = SDR["gender"].ToString();
                    label17_blood.Text = SDR["blood_group"].ToString();
                    label16_contact.Text = SDR["contact"].ToString();
                    label14_entry_time.Text = SDR["entry_time"].ToString();

                    try
                    {
                        if (SDR.HasRows)
                        {
                            byte[] img = (byte[])SDR["picture"];
                            if (img == null)
                            {
                                pictureBox1.Image = null;
                                MessageBox.Show("Image Not Available", "Error");
                            }
                            else
                            {
                                MemoryStream mstream = new MemoryStream(img);
                                pictureBox1.Image = Image.FromStream(mstream);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Image Not Available", "Error");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }



        }
    }
}
