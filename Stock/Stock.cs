using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock
{
   public partial class Stock : Form
   {
      public Stock()
      {
         InitializeComponent();
      }

      private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
      {

      }

      private void Stock_Load(object sender, EventArgs e)
      {
         this.ActiveControl = dateTimePicker1;
         comboBox1.SelectedIndex = 0;
         LoadData();
      }

      private void dateTimePicker1_KeyDown(object sender, KeyEventArgs e)
      {
         if (e.KeyCode == Keys.Enter)
         {
            //textBox1.Enabled = true;
            textBox1.Focus();
         }
         else
         {
            dateTimePicker1.Focus();
         }
      }
      private void textBox1_KeyDown(object sender, KeyEventArgs e)
      {
         if (e.KeyCode == Keys.Enter)
         {
            if (textBox1.Text.Length > 0)
            {
               textBox1.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
               textBox2.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
               textBox3.Focus();
               //SqlConnection con = Connection.GetConnection();
               //con.Open();
               //SqlDataAdapter adapter = new SqlDataAdapter("Select ProductName From [Products] WHERE [ProductCode] = '" + textBox1.Text + "'", con);
               //DataTable dt = new DataTable();
               //adapter.Fill(dt);
               //if (dt.Rows.Count > 0)
               //{
               //   textBox2.Text = dt.Rows[0][0].ToString();
               //   textBox3.Focus();
               //}
               //else
               //{
               //   textBox2.Text = "";
               //}
            }
            else
            {
               textBox1.Focus();
            }
         }
      }
      private void textBox2_KeyDown(object sender, KeyEventArgs e)
      {
         if (e.KeyCode == Keys.Enter)
         {
            //textBox3.Enabled = true;
            textBox3.Focus ();
         }
         else
         {
            textBox2.Focus();
         }
      }

      private void textBox3_KeyDown(object sender, KeyEventArgs e)
      {
         if (e.KeyCode == Keys.Enter)
         {
            //comboBox1.Enabled = true;
            comboBox1.Focus();
         }
         else
         {
            textBox3.Focus();
         }
      }

      private void button3_Click(object sender, EventArgs e)
      {
         reset();
      }

      private void reset()
      {
         dateTimePicker1.Value = DateTime.Now;
         textBox1.Clear();
         //textBox1.Enabled = false;
         textBox2.Clear();
         //textBox2.Enabled = false;
         textBox3.Clear();
         //textBox3.Enabled = false;
         comboBox1.SelectedIndex = -1;
         //comboBox1.Enabled = false;
         dateTimePicker1.Focus();
         button1.Text = "Add";
         button2.Enabled = false;
      }

      private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
      {
         if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != '.')
         {
            e.Handled = true;
         }
      }
      private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
      {
         //if (!textBox1.Text.Equals(""))
         //{
         //   e.Handled = true;
         //}
      }

         private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
      {
         if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != '.')
         {
            e.Handled = true;
         }
      }

      private bool Validation()
      {
         bool result = false;
         if (string.IsNullOrEmpty(textBox1.Text))
         {
            errorProvider1.Clear();
            errorProvider1.SetError(textBox1, "Product Code Required");
         } else if (string.IsNullOrEmpty(textBox2.Text))
         {
            errorProvider1.Clear();
            errorProvider1.SetError(textBox2, "Product Name Required");
         } else if (string.IsNullOrEmpty(textBox3.Text))
         {
            errorProvider1.Clear();
            errorProvider1.SetError(textBox3, "Quantity Required");
         }
         else if (comboBox1.SelectedIndex == -1)
         {
            errorProvider1.Clear();
            errorProvider1.SetError(comboBox1, "Select Status");
         }
         else
         {
            errorProvider1.Clear();
            result = true;
         }
         return result;
      }

      private bool IfProductExists(SqlConnection con, string productCode)
      {
         SqlDataAdapter adapter = new SqlDataAdapter("Select 1 From [Stock] Where [ProductCode]='" + productCode + "'", con);
         DataTable dt = new DataTable();
         adapter.Fill(dt);
         if (dt.Rows.Count > 0 )
         {
            return true;
         }
         else
         {
            return false;
         }
      }

      private void button1_Click(object sender, EventArgs e)
      {
         if (Validation())
         {
            SqlConnection con = Connection.GetConnection();
            con.Open();
            bool status = false;
            if (comboBox1.SelectedIndex == 0)
            {
               status = true;
            }
            else
            {
               status = false;
            }

            var sqlQuery = "";
            if (IfProductExists(con, textBox1.Text))
            {
               sqlQuery = @"UPDATE [Stock] SET  [ProductName] = '" + textBox2.Text + "' ,[Quantity] = '" + textBox3.Text + "' ,[ProductStatus] = '" + status + "' WHERE [ProductCode] = '" + textBox1.Text + "'";
            }
            else
            {
               sqlQuery = @"INSERT INTO [dbo].[Stock]
           ([ProductCode]
           ,[ProductName]
           ,[TransDate]
           ,[Quantity]
           ,[ProductStatus])
            VALUES
           ('" + textBox1.Text + "','" + textBox2.Text + "','" + dateTimePicker1.Value.ToString("MM/dd/yyyy") + "','" + textBox3.Text + "','" + status + "')";
            }

            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Saved Succesfully");
            LoadData();
            reset();

         }
      }

      public void LoadData()
      {
         SqlConnection conn = Connection.GetConnection();
         SqlDataAdapter adapter = new SqlDataAdapter("Select * From [Stock].[dbo].[Stock]", conn);
         DataTable dt = new DataTable();
         adapter.Fill(dt);
         dataGridView1.Rows.Clear();
         foreach (DataRow item in dt.Rows)
         {
            int n = dataGridView1.Rows.Add();
            dataGridView1.Rows[n].Cells["Pno"].Value = n + 1;
            dataGridView1.Rows[n].Cells["Pcode"].Value = item["ProductCode"].ToString();
            dataGridView1.Rows[n].Cells["Pname"].Value = item["ProductName"].ToString();
            dataGridView1.Rows[n].Cells["Pq"].Value = float.Parse(item["Quantity"].ToString());
            dataGridView1.Rows[n].Cells["Pdate"].Value = Convert.ToDateTime(item["TransDate"].ToString()).ToString("dd/MM/yyyy");
            if ((bool)item["ProductStatus"])
            {
               dataGridView1.Rows[n].Cells["Pstatus"].Value = "Active";
            }
            else
            {
               dataGridView1.Rows[n].Cells["Pstatus"].Value = "Deactive";
            }
            if (dataGridView1.Rows.Count > 0)
            {
               label8.Text = dataGridView1.Rows.Count.ToString();
               float totQty = 0;
               for (int i = 0; i < dataGridView1.Rows.Count; i++)
               {
                  totQty += float.Parse(dataGridView1.Rows[i].Cells["Pq"].Value.ToString());
                  label9.Text = totQty.ToString();
               }
            }
            else
            {
               label8.Text = "0";
               label9.Text = "0";
            }
         }
      }

      private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
      {
         button1.Text = "Update";
         button2.Enabled = true;
         textBox1.Text = dataGridView1.SelectedRows[0].Cells["Pcode"].Value.ToString();
         textBox2.Text = dataGridView1.SelectedRows[0].Cells["Pname"].Value.ToString();
         textBox3.Text = dataGridView1.SelectedRows[0].Cells["Pq"].Value.ToString();
         dateTimePicker1.Text = DateTime.Parse(dataGridView1.SelectedRows[0].Cells["Pdate"].Value.ToString()).ToString("dd/MM/yyyy");
         if (dataGridView1.SelectedRows[0].Cells["Pstatus"].Value.ToString() == "Active")
         {
            comboBox1.SelectedIndex = 0;
         }
         else
         {
            comboBox1.SelectedIndex = 1;
         }
      }

      private void button2_Click(object sender, EventArgs e)
      {
         SqlConnection con = Connection.GetConnection();
         con.Open();
         SqlCommand cmd = new SqlCommand("DELETE FROM [dbo].[Stock] WHERE ProductCode = '"+ textBox1.Text +"'",con);
         cmd.ExecuteNonQuery();
         con.Close();
         LoadData();
         reset();
      }

      private void textBox1_TextChanged(object sender, EventArgs e)
      {
         SqlConnection con = Connection.GetConnection();
         con.Open();
         SqlDataAdapter sda = new SqlDataAdapter("Select ProductCode, ProductName FROM [Products] WHERE [ProductCode] like '"+textBox1.Text+"%'",con);
         DataTable dt = new DataTable();
         sda.Fill(dt);
         dataGridView2.DataSource = dt;
      }

      private void dataGridView2_MouseDoubleClick(object sender, MouseEventArgs e)
      {
         textBox1.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
         textBox2.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
         textBox3.Focus();
      }
   }
}
