namespace Stock
{
   partial class Stock
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
         this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.label5 = new System.Windows.Forms.Label();
         this.textBox1 = new System.Windows.Forms.TextBox();
         this.textBox2 = new System.Windows.Forms.TextBox();
         this.textBox3 = new System.Windows.Forms.TextBox();
         this.comboBox1 = new System.Windows.Forms.ComboBox();
         this.button1 = new System.Windows.Forms.Button();
         this.button2 = new System.Windows.Forms.Button();
         this.button3 = new System.Windows.Forms.Button();
         this.dataGridView1 = new System.Windows.Forms.DataGridView();
         this.Pno = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Pcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Pname = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Pq = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Pdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Pstatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.label6 = new System.Windows.Forms.Label();
         this.label7 = new System.Windows.Forms.Label();
         this.label8 = new System.Windows.Forms.Label();
         this.label9 = new System.Windows.Forms.Label();
         this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
         this.dataGridView2 = new System.Windows.Forms.DataGridView();
         this.label10 = new System.Windows.Forms.Label();
         ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
         this.SuspendLayout();
         // 
         // dateTimePicker1
         // 
         this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
         this.dateTimePicker1.Location = new System.Drawing.Point(339, 45);
         this.dateTimePicker1.Name = "dateTimePicker1";
         this.dateTimePicker1.Size = new System.Drawing.Size(139, 27);
         this.dateTimePicker1.TabIndex = 0;
         this.dateTimePicker1.Value = new System.DateTime(2022, 5, 5, 0, 0, 0, 0);
         this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
         this.dateTimePicker1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dateTimePicker1_KeyDown);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
         this.label1.Location = new System.Drawing.Point(339, 19);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(46, 23);
         this.label1.TabIndex = 1;
         this.label1.Text = "Date";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
         this.label2.Location = new System.Drawing.Point(503, 19);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(115, 23);
         this.label2.TabIndex = 2;
         this.label2.Text = "Product Code";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
         this.label3.Location = new System.Drawing.Point(969, 19);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(57, 23);
         this.label3.TabIndex = 3;
         this.label3.Text = "Status";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
         this.label4.Location = new System.Drawing.Point(688, 19);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(121, 23);
         this.label4.TabIndex = 4;
         this.label4.Text = "Product Name";
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
         this.label5.Location = new System.Drawing.Point(873, 19);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(77, 23);
         this.label5.TabIndex = 5;
         this.label5.Text = "Quantity";
         // 
         // textBox1
         // 
         this.textBox1.Location = new System.Drawing.Point(503, 45);
         this.textBox1.Name = "textBox1";
         this.textBox1.Size = new System.Drawing.Size(179, 27);
         this.textBox1.TabIndex = 6;
         this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
         this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
         this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
         // 
         // textBox2
         // 
         this.textBox2.Location = new System.Drawing.Point(688, 45);
         this.textBox2.Name = "textBox2";
         this.textBox2.Size = new System.Drawing.Size(179, 27);
         this.textBox2.TabIndex = 7;
         this.textBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
         this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
         // 
         // textBox3
         // 
         this.textBox3.Location = new System.Drawing.Point(873, 45);
         this.textBox3.Name = "textBox3";
         this.textBox3.Size = new System.Drawing.Size(90, 27);
         this.textBox3.TabIndex = 8;
         this.textBox3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox3_KeyDown);
         this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
         // 
         // comboBox1
         // 
         this.comboBox1.FormattingEnabled = true;
         this.comboBox1.Items.AddRange(new object[] {
            "Active",
            "Deactive"});
         this.comboBox1.Location = new System.Drawing.Point(969, 45);
         this.comboBox1.Name = "comboBox1";
         this.comboBox1.Size = new System.Drawing.Size(114, 28);
         this.comboBox1.TabIndex = 9;
         // 
         // button1
         // 
         this.button1.BackColor = System.Drawing.Color.PaleGreen;
         this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
         this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
         this.button1.Location = new System.Drawing.Point(743, 78);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(107, 37);
         this.button1.TabIndex = 10;
         this.button1.Text = "Add";
         this.button1.UseVisualStyleBackColor = false;
         this.button1.Click += new System.EventHandler(this.button1_Click);
         // 
         // button2
         // 
         this.button2.BackColor = System.Drawing.Color.LightCoral;
         this.button2.Enabled = false;
         this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
         this.button2.Location = new System.Drawing.Point(861, 78);
         this.button2.Name = "button2";
         this.button2.Size = new System.Drawing.Size(107, 37);
         this.button2.TabIndex = 11;
         this.button2.Text = "Delete";
         this.button2.UseVisualStyleBackColor = false;
         this.button2.Click += new System.EventHandler(this.button2_Click);
         // 
         // button3
         // 
         this.button3.BackColor = System.Drawing.Color.LightSkyBlue;
         this.button3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
         this.button3.Location = new System.Drawing.Point(977, 78);
         this.button3.Name = "button3";
         this.button3.Size = new System.Drawing.Size(107, 37);
         this.button3.TabIndex = 12;
         this.button3.Text = "Reset";
         this.button3.UseVisualStyleBackColor = false;
         this.button3.Click += new System.EventHandler(this.button3_Click);
         // 
         // dataGridView1
         // 
         this.dataGridView1.AllowUserToAddRows = false;
         this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Pno,
            this.Pcode,
            this.Pname,
            this.Pq,
            this.Pdate,
            this.Pstatus});
         this.dataGridView1.Location = new System.Drawing.Point(339, 121);
         this.dataGridView1.MultiSelect = false;
         this.dataGridView1.Name = "dataGridView1";
         this.dataGridView1.RowHeadersWidth = 51;
         this.dataGridView1.RowTemplate.Height = 29;
         this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
         this.dataGridView1.Size = new System.Drawing.Size(743, 245);
         this.dataGridView1.TabIndex = 13;
         this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
         // 
         // Pno
         // 
         this.Pno.HeaderText = "S.No";
         this.Pno.MinimumWidth = 6;
         this.Pno.Name = "Pno";
         this.Pno.Width = 57;
         // 
         // Pcode
         // 
         this.Pcode.HeaderText = "Product Code";
         this.Pcode.MinimumWidth = 6;
         this.Pcode.Name = "Pcode";
         this.Pcode.Width = 125;
         // 
         // Pname
         // 
         this.Pname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
         this.Pname.HeaderText = "Product Name";
         this.Pname.MinimumWidth = 6;
         this.Pname.Name = "Pname";
         this.Pname.Width = 133;
         // 
         // Pq
         // 
         this.Pq.HeaderText = "Quantity";
         this.Pq.MinimumWidth = 6;
         this.Pq.Name = "Pq";
         this.Pq.Width = 125;
         // 
         // Pdate
         // 
         this.Pdate.HeaderText = "Date";
         this.Pdate.MinimumWidth = 6;
         this.Pdate.Name = "Pdate";
         this.Pdate.Width = 125;
         // 
         // Pstatus
         // 
         this.Pstatus.HeaderText = "Product Status";
         this.Pstatus.MinimumWidth = 6;
         this.Pstatus.Name = "Pstatus";
         this.Pstatus.Width = 125;
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Location = new System.Drawing.Point(504, 375);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(114, 20);
         this.label6.TabIndex = 14;
         this.label6.Text = "Total Products : ";
         // 
         // label7
         // 
         this.label7.AutoSize = true;
         this.label7.Location = new System.Drawing.Point(688, 375);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(113, 20);
         this.label7.TabIndex = 15;
         this.label7.Text = "Total Quantity : ";
         // 
         // label8
         // 
         this.label8.AutoSize = true;
         this.label8.Location = new System.Drawing.Point(613, 375);
         this.label8.Name = "label8";
         this.label8.Size = new System.Drawing.Size(17, 20);
         this.label8.TabIndex = 16;
         this.label8.Text = "0";
         // 
         // label9
         // 
         this.label9.AutoSize = true;
         this.label9.Location = new System.Drawing.Point(801, 375);
         this.label9.Name = "label9";
         this.label9.Size = new System.Drawing.Size(17, 20);
         this.label9.TabIndex = 17;
         this.label9.Text = "0";
         // 
         // errorProvider1
         // 
         this.errorProvider1.ContainerControl = this;
         // 
         // dataGridView2
         // 
         this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dataGridView2.Location = new System.Drawing.Point(12, 47);
         this.dataGridView2.Name = "dataGridView2";
         this.dataGridView2.RowHeadersWidth = 51;
         this.dataGridView2.RowTemplate.Height = 29;
         this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
         this.dataGridView2.Size = new System.Drawing.Size(307, 319);
         this.dataGridView2.TabIndex = 18;
         this.dataGridView2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView2_MouseDoubleClick);
         // 
         // label10
         // 
         this.label10.AutoSize = true;
         this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
         this.label10.Location = new System.Drawing.Point(12, 21);
         this.label10.Name = "label10";
         this.label10.Size = new System.Drawing.Size(77, 23);
         this.label10.TabIndex = 19;
         this.label10.Text = "Products";
         // 
         // Stock
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(1098, 405);
         this.Controls.Add(this.label10);
         this.Controls.Add(this.dataGridView2);
         this.Controls.Add(this.label9);
         this.Controls.Add(this.label8);
         this.Controls.Add(this.label7);
         this.Controls.Add(this.label6);
         this.Controls.Add(this.dataGridView1);
         this.Controls.Add(this.button3);
         this.Controls.Add(this.button2);
         this.Controls.Add(this.button1);
         this.Controls.Add(this.comboBox1);
         this.Controls.Add(this.textBox3);
         this.Controls.Add(this.textBox2);
         this.Controls.Add(this.textBox1);
         this.Controls.Add(this.label5);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.dateTimePicker1);
         this.Name = "Stock";
         this.Text = "Stock";
         this.Load += new System.EventHandler(this.Stock_Load);
         ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private DateTimePicker dateTimePicker1;
      private Label label1;
      private Label label2;
      private Label label3;
      private Label label4;
      private Label label5;
      private TextBox textBox1;
      private TextBox textBox2;
      private TextBox textBox3;
      private ComboBox comboBox1;
      private Button button1;
      private Button button2;
      private Button button3;
      private DataGridView dataGridView1;
      private Label label6;
      private Label label7;
      private Label label8;
      private Label label9;
      private ErrorProvider errorProvider1;
      private DataGridViewTextBoxColumn Pno;
      private DataGridViewTextBoxColumn Pcode;
      private DataGridViewTextBoxColumn Pname;
      private DataGridViewTextBoxColumn Pq;
      private DataGridViewTextBoxColumn Pdate;
      private DataGridViewTextBoxColumn Pstatus;
      private DataGridView dataGridView2;
      private Label label10;
   }
}