﻿namespace Stock
{
   partial class Products
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
         this.textBox1 = new System.Windows.Forms.TextBox();
         this.textBox2 = new System.Windows.Forms.TextBox();
         this.comboBox1 = new System.Windows.Forms.ComboBox();
         this.dataGridView1 = new System.Windows.Forms.DataGridView();
         this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.button1 = new System.Windows.Forms.Button();
         this.button2 = new System.Windows.Forms.Button();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.button3 = new System.Windows.Forms.Button();
         this.button4 = new System.Windows.Forms.Button();
         this.button5 = new System.Windows.Forms.Button();
         ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
         this.SuspendLayout();
         // 
         // textBox1
         // 
         this.textBox1.Location = new System.Drawing.Point(33, 69);
         this.textBox1.Name = "textBox1";
         this.textBox1.Size = new System.Drawing.Size(158, 27);
         this.textBox1.TabIndex = 0;
         // 
         // textBox2
         // 
         this.textBox2.Location = new System.Drawing.Point(207, 69);
         this.textBox2.Name = "textBox2";
         this.textBox2.Size = new System.Drawing.Size(158, 27);
         this.textBox2.TabIndex = 1;
         // 
         // comboBox1
         // 
         this.comboBox1.FormattingEnabled = true;
         this.comboBox1.Items.AddRange(new object[] {
            "Active",
            "Deactive"});
         this.comboBox1.Location = new System.Drawing.Point(381, 69);
         this.comboBox1.Name = "comboBox1";
         this.comboBox1.Size = new System.Drawing.Size(158, 28);
         this.comboBox1.TabIndex = 2;
         // 
         // dataGridView1
         // 
         this.dataGridView1.AllowUserToAddRows = false;
         this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
         this.dataGridView1.Location = new System.Drawing.Point(33, 121);
         this.dataGridView1.Name = "dataGridView1";
         this.dataGridView1.RowHeadersWidth = 51;
         this.dataGridView1.RowTemplate.Height = 29;
         this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
         this.dataGridView1.Size = new System.Drawing.Size(784, 281);
         this.dataGridView1.TabIndex = 3;
         this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
         // 
         // Column1
         // 
         this.Column1.HeaderText = "Product Code";
         this.Column1.MinimumWidth = 6;
         this.Column1.Name = "Column1";
         this.Column1.Width = 125;
         // 
         // Column2
         // 
         this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
         this.Column2.HeaderText = "Product Name";
         this.Column2.MinimumWidth = 6;
         this.Column2.Name = "Column2";
         // 
         // Column3
         // 
         this.Column3.HeaderText = "Status";
         this.Column3.MinimumWidth = 6;
         this.Column3.Name = "Column3";
         this.Column3.Width = 125;
         // 
         // button1
         // 
         this.button1.BackColor = System.Drawing.Color.LightCoral;
         this.button1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
         this.button1.Location = new System.Drawing.Point(672, 61);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(109, 40);
         this.button1.TabIndex = 4;
         this.button1.Text = "Delete";
         this.button1.UseVisualStyleBackColor = false;
         this.button1.Click += new System.EventHandler(this.button1_Click);
         // 
         // button2
         // 
         this.button2.BackColor = System.Drawing.Color.Turquoise;
         this.button2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
         this.button2.Location = new System.Drawing.Point(557, 61);
         this.button2.Name = "button2";
         this.button2.Size = new System.Drawing.Size(109, 40);
         this.button2.TabIndex = 5;
         this.button2.Text = "Add";
         this.button2.UseVisualStyleBackColor = false;
         this.button2.Click += new System.EventHandler(this.button2_Click);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
         this.label1.Location = new System.Drawing.Point(33, 36);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(119, 23);
         this.label1.TabIndex = 6;
         this.label1.Text = "Product Code";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
         this.label2.Location = new System.Drawing.Point(207, 36);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(125, 23);
         this.label2.TabIndex = 7;
         this.label2.Text = "Product Name";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
         this.label3.Location = new System.Drawing.Point(381, 36);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(60, 23);
         this.label3.TabIndex = 8;
         this.label3.Text = "Status";
         // 
         // button3
         // 
         this.button3.BackColor = System.Drawing.Color.LightSkyBlue;
         this.button3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
         this.button3.Location = new System.Drawing.Point(708, 12);
         this.button3.Name = "button3";
         this.button3.Size = new System.Drawing.Size(109, 40);
         this.button3.TabIndex = 9;
         this.button3.Text = "Update";
         this.button3.UseVisualStyleBackColor = false;
         this.button3.Click += new System.EventHandler(this.button3_Click);
         // 
         // button4
         // 
         this.button4.BackColor = System.Drawing.Color.AntiqueWhite;
         this.button4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
         this.button4.Location = new System.Drawing.Point(593, 12);
         this.button4.Name = "button4";
         this.button4.Size = new System.Drawing.Size(109, 40);
         this.button4.TabIndex = 10;
         this.button4.Text = "Clear";
         this.button4.UseVisualStyleBackColor = false;
         this.button4.Click += new System.EventHandler(this.button4_Click);
         // 
         // button5
         // 
         this.button5.BackColor = System.Drawing.Color.White;
         this.button5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
         this.button5.ForeColor = System.Drawing.SystemColors.ControlText;
         this.button5.Location = new System.Drawing.Point(504, 12);
         this.button5.Name = "button5";
         this.button5.Size = new System.Drawing.Size(83, 40);
         this.button5.TabIndex = 11;
         this.button5.Text = "Refresh";
         this.button5.UseVisualStyleBackColor = false;
         this.button5.Click += new System.EventHandler(this.button5_Click);
         // 
         // Products
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(849, 430);
         this.Controls.Add(this.button5);
         this.Controls.Add(this.button4);
         this.Controls.Add(this.button3);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.button2);
         this.Controls.Add(this.button1);
         this.Controls.Add(this.dataGridView1);
         this.Controls.Add(this.comboBox1);
         this.Controls.Add(this.textBox2);
         this.Controls.Add(this.textBox1);
         this.Name = "Products";
         this.Text = "Products";
         this.Load += new System.EventHandler(this.Products_Load);
         ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private TextBox textBox1;
      private TextBox textBox2;
      private ComboBox comboBox1;
      private DataGridView dataGridView1;
      private Button button1;
      private Button button2;
      private Label label1;
      private Label label2;
      private Label label3;
      private DataGridViewTextBoxColumn Column1;
      private DataGridViewTextBoxColumn Column2;
      private DataGridViewTextBoxColumn Column3;
      private Button button3;
      private Button button4;
      private Button button5;
   }
}