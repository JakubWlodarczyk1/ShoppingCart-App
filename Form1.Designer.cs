namespace StoreCartWinForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.productList = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.panel4 = new System.Windows.Forms.Panel();
            this.birthDate = new System.Windows.Forms.DateTimePicker();
            this.updateBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.surnameTxt = new System.Windows.Forms.TextBox();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.priceTxt = new System.Windows.Forms.TextBox();
            this.quanityTxt = new System.Windows.Forms.TextBox();
            this.productNameTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.productList);
            this.panel1.Location = new System.Drawing.Point(12, 175);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 218);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Zamówione produkty:";
            // 
            // productList
            // 
            this.productList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.productList.FullRowSelect = true;
            this.productList.GridLines = true;
            this.productList.Location = new System.Drawing.Point(0, 26);
            this.productList.Name = "productList";
            this.productList.Size = new System.Drawing.Size(776, 192);
            this.productList.TabIndex = 0;
            this.productList.UseCompatibleStateImageBehavior = false;
            this.productList.View = System.Windows.Forms.View.Details;
            this.productList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.productList_MouseClick_1);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nazwa produktu";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ilość";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Cena";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.birthDate);
            this.panel4.Controls.Add(this.updateBtn);
            this.panel4.Controls.Add(this.deleteBtn);
            this.panel4.Controls.Add(this.addBtn);
            this.panel4.Controls.Add(this.surnameTxt);
            this.panel4.Controls.Add(this.nameTxt);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(12, 11);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(385, 158);
            this.panel4.TabIndex = 7;
            // 
            // birthDate
            // 
            this.birthDate.Location = new System.Drawing.Point(101, 76);
            this.birthDate.Name = "birthDate";
            this.birthDate.Size = new System.Drawing.Size(210, 23);
            this.birthDate.TabIndex = 9;
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(229, 118);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(112, 33);
            this.updateBtn.TabIndex = 8;
            this.updateBtn.Text = "Zmień produkt";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(118, 118);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(105, 33);
            this.deleteBtn.TabIndex = 7;
            this.deleteBtn.Text = "Usuń produkt";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click_1);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(0, 118);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(112, 33);
            this.addBtn.TabIndex = 6;
            this.addBtn.Text = "Dodaj produkt";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // surnameTxt
            // 
            this.surnameTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.surnameTxt.Location = new System.Drawing.Point(101, 40);
            this.surnameTxt.Name = "surnameTxt";
            this.surnameTxt.Size = new System.Drawing.Size(210, 23);
            this.surnameTxt.TabIndex = 4;
            this.surnameTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.surnameTxt_KeyPress);
            // 
            // nameTxt
            // 
            this.nameTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameTxt.Location = new System.Drawing.Point(101, 6);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(210, 23);
            this.nameTxt.TabIndex = 3;
            this.nameTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameTxt_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Imię";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nazwisko";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Data urodzenia";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.priceTxt);
            this.panel3.Controls.Add(this.quanityTxt);
            this.panel3.Controls.Add(this.productNameTxt);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(403, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(385, 150);
            this.panel3.TabIndex = 6;
            this.panel3.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Location = new System.Drawing.Point(365, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(20, 20);
            this.button1.TabIndex = 9;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // priceTxt
            // 
            this.priceTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.priceTxt.Location = new System.Drawing.Point(100, 75);
            this.priceTxt.MaxLength = 7;
            this.priceTxt.Name = "priceTxt";
            this.priceTxt.Size = new System.Drawing.Size(59, 23);
            this.priceTxt.TabIndex = 8;
            this.priceTxt.TextChanged += new System.EventHandler(this.priceTxt_TextChanged);
            // 
            // quanityTxt
            // 
            this.quanityTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.quanityTxt.Location = new System.Drawing.Point(100, 39);
            this.quanityTxt.MaxLength = 3;
            this.quanityTxt.Name = "quanityTxt";
            this.quanityTxt.Size = new System.Drawing.Size(59, 23);
            this.quanityTxt.TabIndex = 7;
            this.quanityTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.quanityTxt_KeyPress);
            // 
            // productNameTxt
            // 
            this.productNameTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.productNameTxt.Location = new System.Drawing.Point(100, 5);
            this.productNameTxt.Name = "productNameTxt";
            this.productNameTxt.Size = new System.Drawing.Size(259, 23);
            this.productNameTxt.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Nazwa produktu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-3, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 15);
            this.label7.TabIndex = 5;
            this.label7.Text = "Cena";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Ilość";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(481, 402);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 36);
            this.button2.TabIndex = 8;
            this.button2.Text = "Zapisz do bazy danych";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(645, 402);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 36);
            this.button3.TabIndex = 9;
            this.button3.Text = "Zapisz do XML";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private ListView productList;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Panel panel4;
        private Button updateBtn;
        private Button deleteBtn;
        private Button addBtn;
        private TextBox surnameTxt;
        private TextBox nameTxt;
        private Label label2;
        private Label label3;
        private Label label4;
        private Panel panel3;
        private Button button1;
        private TextBox priceTxt;
        private TextBox quanityTxt;
        private TextBox productNameTxt;
        private Label label5;
        private Label label7;
        private Label label6;
        private DateTimePicker birthDate;
        private Button button2;
        private Button button3;
    }
}