namespace Final_Library_Project
{
    partial class Insert_Book
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1_Bookid = new System.Windows.Forms.TextBox();
            this.textBox2_bookname = new System.Windows.Forms.TextBox();
            this.textBox3_authorname = new System.Windows.Forms.TextBox();
            this.textBox4_edition = new System.Windows.Forms.TextBox();
            this.textBox5_quantity = new System.Windows.Forms.TextBox();
            this.textBox6_price = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1_catagory = new System.Windows.Forms.ComboBox();
            this.catagoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.library_databaseDataSet2 = new Final_Library_Project.Library_databaseDataSet2();
            this.button1 = new System.Windows.Forms.Button();
            this.catagoryTableAdapter = new Final_Library_Project.Library_databaseDataSet2TableAdapters.catagoryTableAdapter();
            this.catagoryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.catagoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_databaseDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catagoryBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(158, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insert Book";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Book Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Author Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(95, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Edition";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(74, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Entry Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(84, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Quantity";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(108, 292);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Price";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(80, 335);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Catagory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(95, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Book ID";
            // 
            // textBox1_Bookid
            // 
            this.textBox1_Bookid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1_Bookid.Location = new System.Drawing.Point(182, 70);
            this.textBox1_Bookid.Name = "textBox1_Bookid";
            this.textBox1_Bookid.ReadOnly = true;
            this.textBox1_Bookid.Size = new System.Drawing.Size(168, 23);
            this.textBox1_Bookid.TabIndex = 10;
            // 
            // textBox2_bookname
            // 
            this.textBox2_bookname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2_bookname.Location = new System.Drawing.Point(182, 104);
            this.textBox2_bookname.Name = "textBox2_bookname";
            this.textBox2_bookname.Size = new System.Drawing.Size(168, 23);
            this.textBox2_bookname.TabIndex = 11;
            // 
            // textBox3_authorname
            // 
            this.textBox3_authorname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3_authorname.Location = new System.Drawing.Point(182, 141);
            this.textBox3_authorname.Name = "textBox3_authorname";
            this.textBox3_authorname.Size = new System.Drawing.Size(168, 23);
            this.textBox3_authorname.TabIndex = 12;
            // 
            // textBox4_edition
            // 
            this.textBox4_edition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4_edition.Location = new System.Drawing.Point(182, 177);
            this.textBox4_edition.Name = "textBox4_edition";
            this.textBox4_edition.Size = new System.Drawing.Size(124, 23);
            this.textBox4_edition.TabIndex = 13;
            // 
            // textBox5_quantity
            // 
            this.textBox5_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5_quantity.Location = new System.Drawing.Point(182, 250);
            this.textBox5_quantity.Name = "textBox5_quantity";
            this.textBox5_quantity.Size = new System.Drawing.Size(87, 23);
            this.textBox5_quantity.TabIndex = 14;
            // 
            // textBox6_price
            // 
            this.textBox6_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6_price.Location = new System.Drawing.Point(182, 289);
            this.textBox6_price.Name = "textBox6_price";
            this.textBox6_price.Size = new System.Drawing.Size(87, 23);
            this.textBox6_price.TabIndex = 15;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(182, 212);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(266, 23);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // comboBox1_catagory
            // 
            this.comboBox1_catagory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1_catagory.FormattingEnabled = true;
            this.comboBox1_catagory.Location = new System.Drawing.Point(182, 332);
            this.comboBox1_catagory.Name = "comboBox1_catagory";
            this.comboBox1_catagory.Size = new System.Drawing.Size(168, 24);
            this.comboBox1_catagory.TabIndex = 17;
            this.comboBox1_catagory.SelectedIndexChanged += new System.EventHandler(this.comboBox1_catagory_SelectedIndexChanged);
            // 
            // catagoryBindingSource
            // 
            this.catagoryBindingSource.DataMember = "catagory";
            this.catagoryBindingSource.DataSource = this.library_databaseDataSet2;
            // 
            // library_databaseDataSet2
            // 
            this.library_databaseDataSet2.DataSetName = "Library_databaseDataSet2";
            this.library_databaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(162, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 33);
            this.button1.TabIndex = 18;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // catagoryTableAdapter
            // 
            this.catagoryTableAdapter.ClearBeforeFill = true;
            // 
            // catagoryBindingSource1
            // 
            this.catagoryBindingSource1.DataMember = "catagory";
            this.catagoryBindingSource1.DataSource = this.library_databaseDataSet2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(275, 292);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "Taka/-";
            // 
            // Insert_Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(474, 480);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1_catagory);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox6_price);
            this.Controls.Add(this.textBox5_quantity);
            this.Controls.Add(this.textBox4_edition);
            this.Controls.Add(this.textBox3_authorname);
            this.Controls.Add(this.textBox2_bookname);
            this.Controls.Add(this.textBox1_Bookid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Insert_Book";
            this.Text = "Insert_Book";
            this.Load += new System.EventHandler(this.Insert_Book_Load);
            ((System.ComponentModel.ISupportInitialize)(this.catagoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_databaseDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catagoryBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1_Bookid;
        private System.Windows.Forms.TextBox textBox2_bookname;
        private System.Windows.Forms.TextBox textBox3_authorname;
        private System.Windows.Forms.TextBox textBox4_edition;
        private System.Windows.Forms.TextBox textBox5_quantity;
        private System.Windows.Forms.TextBox textBox6_price;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1_catagory;
        private System.Windows.Forms.Button button1;
        private Library_databaseDataSet2 library_databaseDataSet2;
        private System.Windows.Forms.BindingSource catagoryBindingSource;
        private Library_databaseDataSet2TableAdapters.catagoryTableAdapter catagoryTableAdapter;
        private System.Windows.Forms.BindingSource catagoryBindingSource1;
        private System.Windows.Forms.Label label10;
    }
}