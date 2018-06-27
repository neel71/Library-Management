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
namespace Final_Library_Project
{
    public partial class Insert_Book : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Visual Studio\Final_Library_Project_Solution\Final_Library_Project\Library_database.mdf;Integrated Security=True");
        public Insert_Book()
        {
            InitializeComponent();
        }

        private void Insert_Book_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'library_databaseDataSet2.catagory' table. You can move, or remove it, as needed.
            this.catagoryTableAdapter.Fill(this.library_databaseDataSet2.catagory);
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();

            comboBox1_catagory.Items.Clear();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select catagory_name from catagory";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboBox1_catagory.Items.Add(dr["catagory_name"].ToString());
            }
            con.Close();
            this.ActiveControl = textBox2_bookname;

        }
        string admin = "Book-0";
        string auto_id = "";
        private string autoId()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select count(Id) from book", con);
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            i++;
            auto_id = admin + i.ToString();
            return auto_id;
            con.Close();

        }

        private void comboBox1_catagory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cid = "";
            string tempid = autoId();
            try
            {
                
                SqlCommand cmd1 = new SqlCommand("select * from catagory where catagory_name = '"+comboBox1_catagory.Text+"' ",con);
            cmd1.ExecuteNonQuery();
            SqlDataReader SDR = cmd1.ExecuteReader();
          
                while (SDR.Read())
                {
                     cid = (string)SDR["catagory_id"].ToString();
                }
            }
            
            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message);
            }

            
           // textBox1_Bookid.Text = cid;
            textBox1_Bookid.Text = tempid + "(" + cid + ")";
            con.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
             if (textBox2_bookname.Text == String.Empty)
            {
                MessageBox.Show("Student Name is Empty", "Warning");
            }
            else if (textBox3_authorname.Text == String.Empty)
            {
                MessageBox.Show("Author Name is Empty", "Warning");
            }
            
            else if (textBox4_edition.Text == String.Empty)
            {
                MessageBox.Show("Edition is Empty", "Warning");
            }
            else if (textBox5_quantity.Text == String.Empty)
            {
                MessageBox.Show("Give the Quantity", "Warning");
            }
            else if (comboBox1_catagory.Text == String.Empty)
            {
                MessageBox.Show("Give Contact Number", "Warning");
            }
           
            else
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into book  values('" + textBox1_Bookid.Text + "','" + textBox2_bookname.Text + "','" + textBox3_authorname.Text + "','" + textBox4_edition.Text + "','" + dateTimePicker1.Value.ToString()+ "','" + textBox5_quantity.Text + "','" + textBox6_price.Text + "','"+comboBox1_catagory.Text+"')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Book Inserted Successfully", "success");
                textBox1_Bookid.Text = ""; textBox2_bookname.Text = ""; textBox3_authorname.Text = ""; textBox4_edition.Text = ""; textBox5_quantity.Text = ""; textBox6_price.Text = ""; comboBox1_catagory.ResetText();
            }
        }
    }
}
