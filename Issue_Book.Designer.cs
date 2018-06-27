namespace Final_Library_Project
{
    partial class Issue_Book
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox5_entrytime = new System.Windows.Forms.TextBox();
            this.textBox4_contact = new System.Windows.Forms.TextBox();
            this.textBox3_email = new System.Windows.Forms.TextBox();
            this.textBox2_Sname = new System.Windows.Forms.TextBox();
            this.textBox1_LID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1_searchID = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_IssueBook = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox6_Quantity = new System.Windows.Forms.TextBox();
            this.textBox5_Edition = new System.Windows.Forms.TextBox();
            this.textBox4_Aname = new System.Windows.Forms.TextBox();
            this.textBox3_Bname = new System.Windows.Forms.TextBox();
            this.textBox2_BID = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.catagory_Box = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.library_databaseDataSet1 = new Final_Library_Project.Library_databaseDataSet1();
            this.bookTableAdapter = new Final_Library_Project.Library_databaseDataSet1TableAdapters.bookTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1_close = new System.Windows.Forms.Button();
            this.button_Refresh = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_databaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.textBox5_entrytime);
            this.panel1.Controls.Add(this.textBox4_contact);
            this.panel1.Controls.Add(this.textBox3_email);
            this.panel1.Controls.Add(this.textBox2_Sname);
            this.panel1.Controls.Add(this.textBox1_LID);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button1_searchID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(15, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(547, 322);
            this.panel1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(286, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(194, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Enter (xxx-xxx-xxx) Format";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(128, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(134, 16);
            this.textBox1.TabIndex = 15;
            this.textBox1.Text = "xxx-xxx-xxx";
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(340, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // textBox5_entrytime
            // 
            this.textBox5_entrytime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5_entrytime.Location = new System.Drawing.Point(127, 218);
            this.textBox5_entrytime.Name = "textBox5_entrytime";
            this.textBox5_entrytime.ReadOnly = true;
            this.textBox5_entrytime.Size = new System.Drawing.Size(200, 23);
            this.textBox5_entrytime.TabIndex = 13;
            // 
            // textBox4_contact
            // 
            this.textBox4_contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4_contact.Location = new System.Drawing.Point(127, 178);
            this.textBox4_contact.Name = "textBox4_contact";
            this.textBox4_contact.ReadOnly = true;
            this.textBox4_contact.Size = new System.Drawing.Size(200, 23);
            this.textBox4_contact.TabIndex = 12;
            // 
            // textBox3_email
            // 
            this.textBox3_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3_email.Location = new System.Drawing.Point(127, 142);
            this.textBox3_email.Name = "textBox3_email";
            this.textBox3_email.ReadOnly = true;
            this.textBox3_email.Size = new System.Drawing.Size(200, 23);
            this.textBox3_email.TabIndex = 11;
            // 
            // textBox2_Sname
            // 
            this.textBox2_Sname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2_Sname.Location = new System.Drawing.Point(127, 105);
            this.textBox2_Sname.Name = "textBox2_Sname";
            this.textBox2_Sname.ReadOnly = true;
            this.textBox2_Sname.Size = new System.Drawing.Size(200, 23);
            this.textBox2_Sname.TabIndex = 10;
            // 
            // textBox1_LID
            // 
            this.textBox1_LID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1_LID.Location = new System.Drawing.Point(127, 66);
            this.textBox1_LID.Name = "textBox1_LID";
            this.textBox1_LID.ReadOnly = true;
            this.textBox1_LID.Size = new System.Drawing.Size(200, 23);
            this.textBox1_LID.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Entry Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Contact";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Student Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Library ID";
            // 
            // button1_searchID
            // 
            this.button1_searchID.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button1_searchID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1_searchID.Location = new System.Drawing.Point(232, 273);
            this.button1_searchID.Name = "button1_searchID";
            this.button1_searchID.Size = new System.Drawing.Size(122, 28);
            this.button1_searchID.TabIndex = 2;
            this.button1_searchID.Text = "Search ID";
            this.button1_searchID.UseVisualStyleBackColor = false;
            this.button1_searchID.Click += new System.EventHandler(this.button1_search_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button_IssueBook);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.textBox6_Quantity);
            this.panel2.Controls.Add(this.textBox5_Edition);
            this.panel2.Controls.Add(this.textBox4_Aname);
            this.panel2.Controls.Add(this.textBox3_Bname);
            this.panel2.Controls.Add(this.textBox2_BID);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.catagory_Box);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(568, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(724, 321);
            this.panel2.TabIndex = 1;
            this.panel2.Visible = false;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button_IssueBook
            // 
            this.button_IssueBook.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button_IssueBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_IssueBook.Location = new System.Drawing.Point(583, 273);
            this.button_IssueBook.Name = "button_IssueBook";
            this.button_IssueBook.Size = new System.Drawing.Size(128, 31);
            this.button_IssueBook.TabIndex = 18;
            this.button_IssueBook.Text = "Issue Book";
            this.button_IssueBook.UseVisualStyleBackColor = false;
            this.button_IssueBook.Click += new System.EventHandler(this.button_IssueBook_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(28, 246);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 17);
            this.label14.TabIndex = 17;
            this.label14.Text = "Issue Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(31, 273);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(267, 23);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // textBox6_Quantity
            // 
            this.textBox6_Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6_Quantity.Location = new System.Drawing.Point(157, 207);
            this.textBox6_Quantity.Name = "textBox6_Quantity";
            this.textBox6_Quantity.ReadOnly = true;
            this.textBox6_Quantity.Size = new System.Drawing.Size(111, 23);
            this.textBox6_Quantity.TabIndex = 15;
            // 
            // textBox5_Edition
            // 
            this.textBox5_Edition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5_Edition.Location = new System.Drawing.Point(157, 173);
            this.textBox5_Edition.Name = "textBox5_Edition";
            this.textBox5_Edition.ReadOnly = true;
            this.textBox5_Edition.Size = new System.Drawing.Size(111, 23);
            this.textBox5_Edition.TabIndex = 14;
            // 
            // textBox4_Aname
            // 
            this.textBox4_Aname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4_Aname.Location = new System.Drawing.Point(157, 137);
            this.textBox4_Aname.Name = "textBox4_Aname";
            this.textBox4_Aname.ReadOnly = true;
            this.textBox4_Aname.Size = new System.Drawing.Size(172, 23);
            this.textBox4_Aname.TabIndex = 13;
            // 
            // textBox3_Bname
            // 
            this.textBox3_Bname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3_Bname.Location = new System.Drawing.Point(157, 103);
            this.textBox3_Bname.Name = "textBox3_Bname";
            this.textBox3_Bname.ReadOnly = true;
            this.textBox3_Bname.Size = new System.Drawing.Size(172, 23);
            this.textBox3_Bname.TabIndex = 12;
            // 
            // textBox2_BID
            // 
            this.textBox2_BID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2_BID.Location = new System.Drawing.Point(157, 68);
            this.textBox2_BID.Name = "textBox2_BID";
            this.textBox2_BID.ReadOnly = true;
            this.textBox2_BID.Size = new System.Drawing.Size(172, 23);
            this.textBox2_BID.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(28, 210);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 17);
            this.label13.TabIndex = 10;
            this.label13.Text = "Quantity";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(28, 177);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 17);
            this.label12.TabIndex = 9;
            this.label12.Text = "Edition";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(28, 140);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 17);
            this.label11.TabIndex = 8;
            this.label11.Text = "Author Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(28, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 17);
            this.label10.TabIndex = 7;
            this.label10.Text = "Book Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(28, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 17);
            this.label9.TabIndex = 6;
            this.label9.Text = "Book ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(369, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(342, 223);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // catagory_Box
            // 
            this.catagory_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catagory_Box.Location = new System.Drawing.Point(369, 14);
            this.catagory_Box.Name = "catagory_Box";
            this.catagory_Box.ReadOnly = true;
            this.catagory_Box.Size = new System.Drawing.Size(192, 20);
            this.catagory_Box.TabIndex = 4;
            this.catagory_Box.TextChanged += new System.EventHandler(this.catagory_Box_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Book Catagory";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(157, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(203, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataMember = "book";
            this.bookBindingSource.DataSource = this.library_databaseDataSet1;
            // 
            // library_databaseDataSet1
            // 
            this.library_databaseDataSet1.DataSetName = "Library_databaseDataSet1";
            this.library_databaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookTableAdapter
            // 
            this.bookTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(180, 10);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(728, 175);
            this.dataGridView2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button1_close);
            this.panel3.Controls.Add(this.button_Refresh);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.dataGridView2);
            this.panel3.Location = new System.Drawing.Point(21, 340);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(926, 188);
            this.panel3.TabIndex = 3;
            this.panel3.Visible = false;
            // 
            // button1_close
            // 
            this.button1_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1_close.Location = new System.Drawing.Point(39, 119);
            this.button1_close.Name = "button1_close";
            this.button1_close.Size = new System.Drawing.Size(75, 26);
            this.button1_close.TabIndex = 4;
            this.button1_close.Text = "Close";
            this.button1_close.UseVisualStyleBackColor = true;
            this.button1_close.Click += new System.EventHandler(this.button1_close_Click);
            // 
            // button_Refresh
            // 
            this.button_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Refresh.Location = new System.Drawing.Point(39, 70);
            this.button_Refresh.Name = "button_Refresh";
            this.button_Refresh.Size = new System.Drawing.Size(75, 26);
            this.button_Refresh.TabIndex = 3;
            this.button_Refresh.Text = "Refresh";
            this.button_Refresh.UseVisualStyleBackColor = true;
            this.button_Refresh.Click += new System.EventHandler(this.button_Refresh_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(12, 10);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(162, 17);
            this.label15.TabIndex = 0;
            this.label15.Text = "Previous Transaction";
            // 
            // Issue_Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 555);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Issue_Book";
            this.Text = "Issue_Book";
            this.Load += new System.EventHandler(this.Issue_Book_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_databaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox5_entrytime;
        private System.Windows.Forms.TextBox textBox4_contact;
        private System.Windows.Forms.TextBox textBox3_email;
        private System.Windows.Forms.TextBox textBox2_Sname;
        private System.Windows.Forms.TextBox textBox1_LID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1_searchID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox catagory_Box;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Library_databaseDataSet1 library_databaseDataSet1;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private Library_databaseDataSet1TableAdapters.bookTableAdapter bookTableAdapter;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox6_Quantity;
        private System.Windows.Forms.TextBox textBox5_Edition;
        private System.Windows.Forms.TextBox textBox4_Aname;
        private System.Windows.Forms.TextBox textBox3_Bname;
        private System.Windows.Forms.TextBox textBox2_BID;
        private System.Windows.Forms.Button button_IssueBook;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button_Refresh;
        private System.Windows.Forms.Button button1_close;
    }
}