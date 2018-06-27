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
    public partial class Student_Update_Delete : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Visual Studio\Final_Library_Project_Solution\Final_Library_Project\Library_database.mdf;Integrated Security=True");
        public static string SetValue = "";
        public Student_Update_Delete()
        {
            InitializeComponent();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            string t_value = check();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update student set student_id='"+maskedTextBox2.Text+"',name='"+textBox2.Text+"', email='"+ textBox3.Text+"',address='"+textBox4.Text+"',gender = '"+t_value +"',blood_group='"+textBox5.Text+"',contact='"+maskedTextBox1.Text+"',entry_time='"+dateTimePicker1.Value.ToString()+"' where student_lib_id = '"+textBox1.Text+"'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Student Informaton Updated", "success");
            textBox3.Text = ""; textBox4.Text = ""; textBox5.Text = ""; maskedTextBox2.Text = ""; textBox2.Text = ""; maskedTextBox1.Text = "";
            t_value = ""; radioButton1.Checked = false; radioButton2.Checked = false;
            this.Close();
        }
       

        private void Student_Update_Delete_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();

            }
            con.Open();
            
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

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete?", "warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from student where student_lib_id = '" + textBox1.Text + "' ";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Student Informaton Deleted", "success");
                this.Close();
            }

            
        }

        private void button_details_Click(object sender, EventArgs e)
        {
            SetValue = textBox1.Text;
            Show_student_Details SSD = new Show_student_Details();
            SSD.Show();
        }
    }
}
