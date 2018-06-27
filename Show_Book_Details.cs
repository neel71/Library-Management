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
    public partial class Show_Book_Details : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Visual Studio\Final_Library_Project_Solution\Final_Library_Project\Library_database.mdf;Integrated Security=True");

        
        public Show_Book_Details()
        {
            InitializeComponent();
        }

        private void Show_Book_Details_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();

            }
            con.Open();
            label10.Text = Book_Update_Delete.SetValue;
            SqlCommand cmd = new SqlCommand("select * from book where book_id ='"+label10.Text+"'  ",con);
            SqlDataReader SDR = cmd.ExecuteReader();
            while (SDR.Read())
            {
              label11.Text  = SDR["book_name"].ToString();
                label12.Text = SDR["author_name"].ToString();
                label13.Text = SDR["edition"].ToString();
                label14.Text = SDR["entry_date"].ToString();
                label15.Text = SDR["quantity"].ToString();
                label16.Text = SDR["price"].ToString();
                label17.Text = SDR["catagory"].ToString();
               
            }
            
        }
    }
}
