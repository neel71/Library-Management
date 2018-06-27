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
    public partial class Return_Book : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C Drive\Final_Library_Project_Solution\Final_Library_Project\Library_database.mdf;Integrated Security=True");

        public Return_Book()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            panel2.Visible = true;
            
            con.Open();

            try
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select book_id,book_name,author_name,edition,quantity,issue_date,return_date,book_catagory from issue_book where student_id='" + textBox1_Sid.Text + "' ";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
        private void button_SeeRunningRcord_Click(object sender, EventArgs e)
        {

            
            panel3.Visible = true;

            con.Open();

            try
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select book_id,book_name,author_name,edition,quantity,issue_date,return_date,book_catagory from issue_book where student_id='" + textBox1_Sid.Text + "' and IsDigit= '" + "1" + "' ";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView2.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            con.Close();
        }

        private void Return_Book_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
            if (con.State == ConnectionState.Open)
            {
                con.Close();

            }
            
        }
       

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1_Sid.Text = "";
        }

        private void button1_searchID_Click(object sender, EventArgs e)
        {

            con.Open();
            if (textBox1_Sid.Text == null)
            {
                MessageBox.Show("Please Inset Student Id","Warning");
            }
            else
            {
                SqlCommand cmd = new SqlCommand("select * from student where student_id ='" + textBox1_Sid.Text + "'  ", con);
                SqlDataReader SDR = cmd.ExecuteReader();

                {
                    try
                    {
                        while (SDR.Read())
                        {
                            textBox1_LID.Text = SDR["student_lib_id"].ToString();
                            textBox2_Sname.Text = SDR["name"].ToString();
                            textBox3_email.Text = SDR["email"].ToString();
                            textBox4_contact.Text = SDR["contact"].ToString();
                            textBox5_entrytime.Text = SDR["entry_time"].ToString();

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

                            button_SeeAllRecord.Visible = true;
                            button_SeeRunningRcord.Visible = true;
                        } // while looop end
                        
                    }  // try end
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

                con.Close();



               
            }
        }

       

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            con.Open();

            try
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select *from book where book_name like '%"+textBox_SearchByBook.Text+"%' ";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



            con.Close();
        }

        private void button_SearchBook_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlDataAdapter da = new SqlDataAdapter("select * from issue_book where issue_date between '" + dateTimePicker1.Value.ToString("mm/dd/yyyy") + "' and '" + dateTimePicker2.Value.ToString("mm/dd/yyyy") + "'",con);
            DataSet ds = new DataSet();
            da.Fill(ds,"issue_book");
            dataGridView1.DataSource = ds.Tables["issue_book"];



           /// DateTime 
            //SqlCommand cmd = con.CreateCommand();
            //cmd.CommandType = CommandType.Text;
            //cmd.CommandText = ;
            //cmd.ExecuteNonQuery();

            //DataTable dt = new DataTable();
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //da.Fill(dt);
            //dataGridView1.DataSource = dt;




            con.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            panel2.Visible = false;
            
        }

        private void button_Running_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }
    }
}
