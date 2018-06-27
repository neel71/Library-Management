namespace Final_Library_Project
{
    partial class Book_Update_Delete
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
            this.label10 = new System.Windows.Forms.Label();
            this.catagoryTableAdapter = new Final_Library_Project.Library_databaseDataSet2TableAdapters.catagoryTableAdapter();
            this.btn_update = new System.Windows.Forms.Button();
            this.library_databaseDataSet2 = new Final_Library_Project.Library_databaseDataSet2();
            this.catagoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1_catagory = new System.Windows.Forms.ComboBox();
            this.textBox6_price = new System.Windows.Forms.TextBox();
            this.textBox5_quantity = new System.Windows.Forms.TextBox();
            this.textBox4_edition = new System.Windows.Forms.TextBox();
            this.catagoryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.textBox3_authorname = new System.Windows.Forms.TextBox();
            this.textBox2_bookname = new System.Windows.Forms.TextBox();
            this.textBox1_Bookid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_Show = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.library_databaseDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catagoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catagoryBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(244, 288);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 17);
            this.label10.TabIndex = 38;
            this.label10.Text = "Taka/-";
            // 
            // catagoryTableAdapter
            // 
            this.catagoryTableAdapter.ClearBeforeFill = true;
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(80, 377);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(89, 42);
            this.btn_update.TabIndex = 37;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // library_databaseDataSet2
            // 
            this.library_databaseDataSet2.DataSetName = "Library_databaseDataSet2";
            this.library_databaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // catagoryBindingSource
            // 
            this.catagoryBindingSource.DataMember = "catagory";
            this.catagoryBindingSource.DataSource = this.library_databaseDataSet2;
            // 
            // comboBox1_catagory
            // 
            this.comboBox1_catagory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1_catagory.FormattingEnabled = true;
            this.comboBox1_catagory.Location = new System.Drawing.Point(151, 328);
            this.comboBox1_catagory.Name = "comboBox1_catagory";
            this.comboBox1_catagory.Size = new System.Drawing.Size(168, 24);
            this.comboBox1_catagory.TabIndex = 36;
            // 
            // textBox6_price
            // 
            this.textBox6_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6_price.Location = new System.Drawing.Point(151, 285);
            this.textBox6_price.Name = "textBox6_price";
            this.textBox6_price.Size = new System.Drawing.Size(87, 23);
            this.textBox6_price.TabIndex = 34;
            // 
            // textBox5_quantity
            // 
            this.textBox5_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5_quantity.Location = new System.Drawing.Point(151, 246);
            this.textBox5_quantity.Name = "textBox5_quantity";
            this.textBox5_quantity.Size = new System.Drawing.Size(87, 23);
            this.textBox5_quantity.TabIndex = 33;
            // 
            // textBox4_edition
            // 
            this.textBox4_edition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4_edition.Location = new System.Drawing.Point(151, 209);
            this.textBox4_edition.Name = "textBox4_edition";
            this.textBox4_edition.Size = new System.Drawing.Size(124, 23);
            this.textBox4_edition.TabIndex = 32;
            // 
            // catagoryBindingSource1
            // 
            this.catagoryBindingSource1.DataMember = "catagory";
            this.catagoryBindingSource1.DataSource = this.library_databaseDataSet2;
            // 
            // textBox3_authorname
            // 
            this.textBox3_authorname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3_authorname.Location = new System.Drawing.Point(151, 173);
            this.textBox3_authorname.Name = "textBox3_authorname";
            this.textBox3_authorname.Size = new System.Drawing.Size(168, 23);
            this.textBox3_authorname.TabIndex = 31;
            // 
            // textBox2_bookname
            // 
            this.textBox2_bookname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2_bookname.Location = new System.Drawing.Point(151, 136);
            this.textBox2_bookname.Name = "textBox2_bookname";
            this.textBox2_bookname.Size = new System.Drawing.Size(168, 23);
            this.textBox2_bookname.TabIndex = 30;
            // 
            // textBox1_Bookid
            // 
            this.textBox1_Bookid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1_Bookid.Location = new System.Drawing.Point(151, 102);
            this.textBox1_Bookid.Name = "textBox1_Bookid";
            this.textBox1_Bookid.ReadOnly = true;
            this.textBox1_Bookid.Size = new System.Drawing.Size(168, 23);
            this.textBox1_Bookid.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "Book ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(49, 331);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 17);
            this.label9.TabIndex = 27;
            this.label9.Text = "Catagory";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(77, 288);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 17);
            this.label8.TabIndex = 26;
            this.label8.Text = "Price";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(53, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 17);
            this.label7.TabIndex = 25;
            this.label7.Text = "Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(64, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "Edition";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Author Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Book Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(111, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 22);
            this.label1.TabIndex = 20;
            this.label1.Text = "Book Information";
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete.Location = new System.Drawing.Point(212, 377);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(87, 42);
            this.button_delete.TabIndex = 39;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_Show
            // 
            this.button_Show.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button_Show.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Show.Location = new System.Drawing.Point(273, 12);
            this.button_Show.Name = "button_Show";
            this.button_Show.Size = new System.Drawing.Size(85, 26);
            this.button_Show.TabIndex = 40;
            this.button_Show.Text = "Details";
            this.button_Show.UseVisualStyleBackColor = false;
            this.button_Show.Click += new System.EventHandler(this.button_Show_Click);
            // 
            // Book_Update_Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 459);
            this.Controls.Add(this.button_Show);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.comboBox1_catagory);
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
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Book_Update_Delete";
            this.Text = "Book_Update_Delete";
            this.Load += new System.EventHandler(this.Book_Update_Delete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.library_databaseDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catagoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catagoryBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Library_databaseDataSet2TableAdapters.catagoryTableAdapter catagoryTableAdapter;
        private System.Windows.Forms.Button btn_update;
        private Library_databaseDataSet2 library_databaseDataSet2;
        private System.Windows.Forms.BindingSource catagoryBindingSource;
        private System.Windows.Forms.BindingSource catagoryBindingSource1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_delete;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.ComboBox comboBox1_catagory;
        public System.Windows.Forms.TextBox textBox6_price;
        public System.Windows.Forms.TextBox textBox5_quantity;
        public System.Windows.Forms.TextBox textBox4_edition;
        public System.Windows.Forms.TextBox textBox3_authorname;
        public System.Windows.Forms.TextBox textBox2_bookname;
        public System.Windows.Forms.TextBox textBox1_Bookid;
        private System.Windows.Forms.Button button_Show;
    }
}