﻿namespace Stock
{
   partial class StockMain
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
         this.menuStrip = new System.Windows.Forms.MenuStrip();
         this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.statusStrip = new System.Windows.Forms.StatusStrip();
         this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
         this.toolTip = new System.Windows.Forms.ToolTip(this.components);
         this.menuStrip.SuspendLayout();
         this.statusStrip.SuspendLayout();
         this.SuspendLayout();
         // 
         // menuStrip
         // 
         this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
         this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productsToolStripMenuItem,
            this.stockToolStripMenuItem});
         this.menuStrip.Location = new System.Drawing.Point(0, 0);
         this.menuStrip.Name = "menuStrip";
         this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
         this.menuStrip.Size = new System.Drawing.Size(843, 30);
         this.menuStrip.TabIndex = 0;
         this.menuStrip.Text = "MenuStrip";
         // 
         // productsToolStripMenuItem
         // 
         this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
         this.productsToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
         this.productsToolStripMenuItem.Text = "Products";
         this.productsToolStripMenuItem.Click += new System.EventHandler(this.productsToolStripMenuItem_Click);
         // 
         // stockToolStripMenuItem
         // 
         this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
         this.stockToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
         this.stockToolStripMenuItem.Text = "Stock";
         this.stockToolStripMenuItem.Click += new System.EventHandler(this.stockToolStripMenuItem_Click);
         // 
         // statusStrip
         // 
         this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
         this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
         this.statusStrip.Location = new System.Drawing.Point(0, 387);
         this.statusStrip.Name = "statusStrip";
         this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
         this.statusStrip.Size = new System.Drawing.Size(843, 26);
         this.statusStrip.TabIndex = 2;
         this.statusStrip.Text = "StatusStrip";
         // 
         // toolStripStatusLabel
         // 
         this.toolStripStatusLabel.Name = "toolStripStatusLabel";
         this.toolStripStatusLabel.Size = new System.Drawing.Size(49, 20);
         this.toolStripStatusLabel.Text = "Status";
         // 
         // StockMain
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(843, 413);
         this.Controls.Add(this.statusStrip);
         this.Controls.Add(this.menuStrip);
         this.IsMdiContainer = true;
         this.MainMenuStrip = this.menuStrip;
         this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.Name = "StockMain";
         this.Text = "StockMain";
         this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
         this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StockMain_FormClosing);
         this.menuStrip.ResumeLayout(false);
         this.menuStrip.PerformLayout();
         this.statusStrip.ResumeLayout(false);
         this.statusStrip.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }
      #endregion


      private System.Windows.Forms.MenuStrip menuStrip;
      private System.Windows.Forms.StatusStrip statusStrip;
      private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
      private System.Windows.Forms.ToolTip toolTip;
      private ToolStripMenuItem productsToolStripMenuItem;
      private ToolStripMenuItem stockToolStripMenuItem;
   }
}



