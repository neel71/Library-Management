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
    public partial class Issue_Book : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Visual Studio\Final_Library_Project_Solution\Final_Library_Project\Library_database.mdf;Integrated Security=True");

        public Issue_Book()
        {
            InitializeComponent();
        }
        private void catagory_Box_TextChanged(object sender, EventArgs e)
        {

        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Issue_Book_Load(object sender, EventArgs e)
        {
         }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void Issue_Book_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'library_databaseDataSet1.book' table. You can move, or remove it, as needed.
            this.bookTableAdapter.Fill(this.library_databaseDataSet1.book);


            this.WindowState = FormWindowState.Normal;
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
            if (con.State == ConnectionState.Open)
            {
                con.Close();

            }
            con.Open();

            comboBox1.Items.Clear();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select catagory_name from catagory";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            
            foreach (DataRow dr in dt.Rows)
            {
                comboBox1.Items.Add(dr["catagory_name"].ToString());
            }


            SqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select book_id ,book_name,author_name from book";
            cmd1.ExecuteNonQuery();
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            da1.Fill(dt1);

            dataGridView1.DataSource = dt1;
            con.Close();



            //textBox2.Text = dateTimePicker2.Value.ToString();
            //textBox3.Text = dateTimePicker2.Value.AddDays(7).ToString();
         

        }

        private void button1_search_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("select * from student where student_id ='" + textBox1.Text + "'  ", con);
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
                        panel2.Show();

                    } // while looop end
                }  // try end
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            panel3.Show();
            
            con.Close();

            dispaly();


        }
        private void textBox1_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
        
       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            catagory_Box.Text = comboBox1.Text;



            con.Open();
            SqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select book_id ,book_name,author_name from book where catagory = '"+catagory_Box.Text+"'  ";
            cmd1.ExecuteNonQuery();
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            da1.Fill(dt1);

            dataGridView1.DataSource = dt1;
            

            con.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            con.Open();

            string id = dataGridView1.SelectedCells[0].Value.ToString();

            SqlCommand cmd1 = new SqlCommand("select * from book where book_id= '"+id+"'  ", con);
            SqlDataReader SDR = cmd1.ExecuteReader();
            while (SDR.Read())
            {
                textBox2_BID.Text = SDR["book_id"].ToString();
                textBox3_Bname.Text = SDR["book_name"].ToString();
                textBox4_Aname.Text = SDR["author_name"].ToString();
                textBox5_Edition.Text = SDR["edition"].ToString();
                textBox6_Quantity.Text = SDR["quantity"].ToString();

            }

            con.Close();
        }

        private void button_IssueBook_Click(object sender, EventArgs e)
        {
            con.Open();
            //textBox2.Text = dateTimePicker2.Value.ToString();
            //int Avaialable = 0;
            string Return_Date = dateTimePicker1.Value.AddDays(7).ToString();
            try
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into issue_book  values ('" + textBox1_LID.Text + "','" + textBox1.Text + "','" + textBox2_Sname.Text + "','" + textBox3_email.Text + "','" + textBox4_contact.Text + "','" + textBox2_BID.Text + "','" + textBox3_Bname.Text + "','" + textBox4_Aname.Text + "','" + textBox5_Edition.Text + "', '"+ "1" +"' ,'" + dateTimePicker1.Value.ToString() + "','" + Return_Date + "','" + comboBox1.Text + "','" + "1" + "' )";
                cmd.ExecuteNonQuery();
                MessageBox.Show("New Book Issued","Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                SqlCommand cmd1 = con.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "update book set quantity = quantity-1 where book_id = '" + textBox2_BID.Text + "'  ";
                cmd1.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            catagory_Box.Text = "";textBox2_BID.Text = ""; textBox3_Bname.Text = ""; textBox4_Aname.Text = ""; textBox5_Edition.Text = ""; textBox6_Quantity.Text = "";


            con.Close(); 
        }

        private void dispaly()
        {
            con.Open();

            SqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select  book_id,book_name,author_name,edition,quantity,issue_date,return_date from issue_book where IsDigit = '" + "1" + "' and student_id='"+textBox1.Text+"' ";
            cmd1.ExecuteNonQuery();
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            da1.Fill(dt1);

            dataGridView2.DataSource = dt1;
            con.Close();
        }

        private void button_Refresh_Click(object sender, EventArgs e)
        {
            dispaly();
        }

        private void button1_close_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel3.Visible = false;
            textBox1.Text = "";textBox1_LID.Text = "";textBox2_Sname.Text = "";
            textBox3_email.Text = "";textBox4_contact.Text = "";textBox5_entrytime.Text = "";


        }
    }







        
    }
    

