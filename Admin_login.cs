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
using System.Text.RegularExpressions;
using System.Net.Mail;
using System.Net;
using S22.Imap;
namespace Final_Library_Project
{
    public partial class Admin_login : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Visual Studio\Final_Library_Project_Solution\Final_Library_Project\Library_database.mdf;Integrated Security=True");
        public Admin_login()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Admin_login_Load(object sender, EventArgs e)
        {
            if(con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            autoId();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*
             
                
             
             */

            if (textBox3.Text == String.Empty)
            {
                MessageBox.Show("Username is empty", "Warning");
            }
            else if (textBox4.Text == String.Empty)
            {
                MessageBox.Show("Email is empty", "Warning");
            }
            else if (IsValidEmailAddress(textBox4.Text) == false)
            {
                MessageBox.Show("Invalid Email Addres", "Warning");
            }
            
            else
            {
                string t_id = autoId();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into registration  values('"+textBox3.Text+"','"+textBox4.Text+"','"+textBox5.Text+"','"+t_id+"')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registration Complete","success");
                textBox3.Text = ""; textBox4.Text = ""; textBox5.Text = ""; textBox6.Text = "";

            }

        }

        string admin = "admin_00_";
        string auto_id = "";
        private string autoId( )
        {
            SqlCommand cmd = new SqlCommand("select count(id) from registration",con);
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            i++;
            auto_id = admin + i.ToString();
            return auto_id; 

        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from registration where admin_id = '" + textBox1.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            int i = Convert.ToInt32(dt.Rows.Count.ToString());
            if (i == 0)
            {
                MessageBox.Show("Wrong User");
            }
            else
            {
                Menu_Form MF = new Menu_Form();
                MF.Show();
                
            }
            textBox1.Text = "";
            textBox2.Text = "";

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            
        }
        public bool IsValidEmailAddress(string s)
        {
            //if (string.IsNullOrEmpty(s))
              //  return false;
            //else
           // {
                var regex = new Regex(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
                return regex.IsMatch(s) && !s.EndsWith(".");
           // }
        }

        private void textBox6_TextChanged_1(object sender, EventArgs e)
        {
            if (textBox5.Text == textBox6.Text)
            {
                label13.ForeColor = Color.DarkGreen;
                label13.Text = "Right";
            }
            else
            {
                label13.ForeColor = Color.DarkRed;
                label13.Text = "Wrong";
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
