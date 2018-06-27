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
    public partial class Book_Update_Delete : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Visual Studio\Final_Library_Project_Solution\Final_Library_Project\Library_database.mdf;Integrated Security=True");
        public static string SetValue = "";
        public Book_Update_Delete()
        {
            InitializeComponent();
        }

        private void Book_Update_Delete_Load(object sender, EventArgs e)
        {

            if (con.State == ConnectionState.Open)
            {
                con.Close();

            }
            con.Open();
            
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete?", "warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from book where book_id = '" + textBox1_Bookid.Text + "' ";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Book Informaton Deleted", "success");
                this.Close();
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
           
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update book set book_name='" + textBox2_bookname.Text + "',author_name='" + textBox3_authorname.Text + "', edition='" + textBox4_edition.Text + "',quantity='" + textBox5_quantity.Text + "',price = '" + textBox6_price.Text + "' where book_id = '" + textBox1_Bookid.Text + "'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Book Informaton Updated", "success");
            textBox2_bookname.Text = ""; textBox3_authorname.Text = ""; textBox4_edition.Text = ""; textBox5_quantity.Text = "";  textBox6_price.Text = "";
            this.Close();
        }

        private void button_Show_Click(object sender, EventArgs e)
        {
            SetValue = textBox1_Bookid.Text;
            Show_Book_Details SBD = new Show_Book_Details();
            SBD.Show();
            
        }
    }
}
