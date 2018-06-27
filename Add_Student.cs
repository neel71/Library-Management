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
using System.IO;

namespace Final_Library_Project
{
    public partial class Add_Student : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Visual Studio\Final_Library_Project_Solution\Final_Library_Project\Library_database.mdf;Integrated Security=True");
        public Add_Student()
        {
            InitializeComponent();
        }

        private void Add_Student_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            byte[] imageBt = null;
            FileStream fstream = new FileStream(this.textBox_ImagePath.Text,FileMode.Open,FileAccess.Read);
            BinaryReader br = new BinaryReader(fstream);
            imageBt = br.ReadBytes((int)fstream.Length);



            if (maskedTextBox2.Text == String.Empty)
            {
                MessageBox.Show("Fill the Student Id", "Warning");
            }
            else if (textBox2.Text == String.Empty)
            {
                MessageBox.Show("Fill the Student Name", "Warning");
            }
            else if (textBox3.Text == String.Empty)
            {
                MessageBox.Show("Fill the Email", "Warning");
            }
            else if (radioButton1.Checked == false && radioButton2.Checked == false)
            {
                MessageBox.Show("Fill the Gender", "Warning");
            }
            else if (textBox5.Text == String.Empty)
            {
                MessageBox.Show("Fill Blood Group", "Warning");
            }
            else if (textBox4.Text == String.Empty)
            {
                MessageBox.Show("Fill the Address", "Warning");
            }
            else if (maskedTextBox1.Text == String.Empty)
            {
                MessageBox.Show("Give Contact Number", "Warning");
            }
            else if (IsValidEmailAddress(textBox3.Text) == false)
            {
                MessageBox.Show("Invalid Email Addres", "Warning");
            }
            else
            {
                string t_id = autoId();
                string t_value = check();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into student  values('"+t_id+"','"+ maskedTextBox2.Text+"','"+textBox2.Text+"','" + textBox3.Text + "','" + textBox4.Text + "','" +t_value + "','"+textBox5.Text+"','"+maskedTextBox1.Text+"','" + dateTimePicker1.Value.ToString() + "',@imageBt)";
                cmd.Parameters.Add(new SqlParameter("@imageBt",imageBt));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registration Complete","success");
                textBox3.Text = ""; textBox4.Text = ""; textBox5.Text = ""; maskedTextBox2.Text = ""; textBox2.Text = ""; maskedTextBox1.Text = "";
                t_value = ""; radioButton1.Checked = false; radioButton2.Checked = false; textBox_ImagePath.Text = ""; pictureBox1.ImageLocation = "";
            }
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
        string admin = "student_0";
        string auto_id = "";
        private string autoId()
        {
            SqlCommand cmd = new SqlCommand("select count(id) from student", con);
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            i++;
            auto_id = admin + i.ToString();
            return auto_id;

        }
        string value = "";
        private string check()
        {
            
            bool isChecked = radioButton1.Checked;
            if (isChecked)
            {
                value = radioButton1.Text;
                return value;
            }
            else
            {
                value = radioButton2.Text;
                return value;
            }
                
        }

       // string imagelocation = "";
        private void button_UploadImage_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog dialog = new OpenFileDialog();
            // image filters  
            dialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                //imagelocation = dialog.FileName.ToString();
                //pictureBox1.ImageLocation = imagelocation;

                string piclog = dialog.FileName.ToString();
                textBox_ImagePath.Text = piclog;
                pictureBox1.ImageLocation = piclog;
            }
        }
    }
}
