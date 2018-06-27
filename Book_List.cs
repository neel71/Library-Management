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
    public partial class Book_List : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Visual Studio\Final_Library_Project_Solution\Final_Library_Project\Library_database.mdf;Integrated Security=True");

        public Book_List()
        {
            InitializeComponent();
        }

        private void Book_List_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'library_databaseDataSet1.book' table. You can move, or remove it, as needed.
            this.bookTableAdapter.Fill(this.library_databaseDataSet1.book);
            if (con.State == ConnectionState.Open)
            {
                con.Close();

            }
            con.Open();
           // display();

        }
        public void display()
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from book";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            display();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Book_Update_Delete b = new Book_Update_Delete();
            b.textBox1_Bookid.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            b.textBox2_bookname.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            b.textBox3_authorname.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            b.textBox4_edition.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            b.textBox5_quantity.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            b.textBox6_price.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
            b.comboBox1_catagory.Text = this.dataGridView1.CurrentRow.Cells[7].Value.ToString();
            // STD.dateTimePicker1.Text = this.dataGridView1.CurrentRow.Cells[9].Value.ToString();
            b.ShowDialog();
        }
    }
}
