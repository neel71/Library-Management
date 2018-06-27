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
    public partial class Add_Catagory : Form
    {

      // SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C Drive\Final_Library_Project_Solution\Final_Library_Project\Library_database.mdf;Integrated Security=True");
        public Add_Catagory()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-VRC6R0T\\SQLEXPRESS;Initial Catalog=Library_Database;User ID=sa;Password=1234";
            InitializeComponent();
        }
        private void Add_Catagory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'library_DatabaseDataSet1.catagory' table. You can move, or remove it, as needed.
            this.catagoryTableAdapter1.Fill(this.library_DatabaseDataSet1.catagory);
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-VRC6R0T\\SQLEXPRESS;Initial Catalog=Library_Database;User ID=sa;Password=1234";
            // TODO: This line of code loads data into the 'library_databaseDataSet2.catagory' table. You can move, or remove it, as needed.
           
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            display();
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-VRC6R0T\\SQLEXPRESS;Initial Catalog=Library_Database;User ID=sa;Password=1234";
            con.Open();
            string auto_id = autoId();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into catagory values ('"+auto_id+"','"+textBox1.Text+"')";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Catagory Added Successsfully");
            textBox1.Text = "";
            display();
            con.Close();
        }

        string catagory = "CAT-0";
        string auto_id = "";
        private string autoId()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-VRC6R0T\\SQLEXPRESS;Initial Catalog=Library_Database;User ID=sa;Password=1234";
            con.Open();
            SqlCommand cmd = new SqlCommand("select count(id) from catagory", con);
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            i++;
            auto_id = catagory + i.ToString();
            return auto_id;
            con.Close();

        }
        public void display()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-VRC6R0T\\SQLEXPRESS;Initial Catalog=Library_Database;User ID=sa;Password=1234";
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from catagory";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
            {
                if (MessageBox.Show("Are you sure to delete?", "warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int row = e.RowIndex;
                    dataGridView1.Rows.RemoveAt(row);
                }
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            panel2.Show();
            if (e.RowIndex > 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                textBox2.Text = row.Cells["catagoryidDataGridViewTextBoxColumn"].Value.ToString();
                textBox3.Text = row.Cells["catagorynameDataGridViewTextBoxColumn"].Value.ToString();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            display();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-VRC6R0T\\SQLEXPRESS;Initial Catalog=Library_Database;User ID=sa;Password=1234";
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update catagory set catagory_name = '"+textBox3.Text+"' where catagory_id='"+textBox2.Text+"'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Catagory Upadated","Success");
            textBox2.Text = ""; textBox3.Text = "";
            panel2.Hide();
            con.Close();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete?", "warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-VRC6R0T\\SQLEXPRESS;Initial Catalog=Library_Database;User ID=sa;Password=1234";
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from catagory where catagory_id='" + textBox2.Text + "' ";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Catagory Deleted", "success");
                con.Close();
               
            }
            panel2.Hide();
        }
    }
}
