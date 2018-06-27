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
    public partial class Student_List : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Visual Studio\Final_Library_Project_Solution\Final_Library_Project\Library_database.mdf;Integrated Security=True");
        public Student_List()
        {
            InitializeComponent();
        }

        private void Student_List_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'library_databaseDataSet.student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.library_databaseDataSet.student);
            if (con.State == ConnectionState.Open)
            {
                con.Close();
                
            }
            con.Open();
            display();
        }
        public void display()
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from student";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Student_Update_Delete STD = new Student_Update_Delete();
            STD.textBox1.Text= this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            STD.maskedTextBox2.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            STD.textBox2.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            STD.textBox3.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            STD.textBox4.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            STD.textBox5.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
            STD.maskedTextBox1.Text = this.dataGridView1.CurrentRow.Cells[7].Value.ToString();
           // STD.dateTimePicker1.Text = this.dataGridView1.CurrentRow.Cells[9].Value.ToString();
            STD.ShowDialog();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            display();
        }

        private void button_namesearch_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from student where name like('%" + textBox1_name.Text + "%') ";
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
        }

        private void textBox1_name_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from student where name like('%" + textBox1_name.Text + "%') ";
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
        }

        private void maskedTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
           
        }

        private void button_idsearch_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from student where student _id like('%" + textBox1_id.Text + "%') ";
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
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from student where student _id like('%" + textBox1_id.Text + "%') ";
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
        }
    }
}
