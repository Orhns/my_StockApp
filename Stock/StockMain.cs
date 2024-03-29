﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock
{
   public partial class StockMain : Form
   {

      public StockMain()
      {
         InitializeComponent();
      }

      private void productsToolStripMenuItem_Click(object sender, EventArgs e)
      {
         Products products = new Products();
         products.MdiParent = this;
         products.StartPosition = FormStartPosition.CenterScreen;
         products.Show();
      }

      private void StockMain_FormClosing(object sender, FormClosingEventArgs e)
      {
         Application.Exit();
      }

      private void stockToolStripMenuItem_Click(object sender, EventArgs e)
      {
         Stock stock = new Stock();
         stock.MdiParent = this;
         stock.StartPosition = FormStartPosition.CenterScreen;
         stock.Show();
      }

      private void accounterToolStripMenuItem_Click(object sender, EventArgs e)
      {
         //Accounter accounter = new Accounter();
         //accounter.MdiParent = this;
         //accounter.StartPosition = FormStartPosition.CenterScreen;
         //accounter.Show();
      }
   }
}
