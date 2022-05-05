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
   public partial class Products : Form
   {
      public Products()
      {
         InitializeComponent();
      }

      private void Products_Load(object sender, EventArgs e)
      {
         comboBox1.SelectedIndex = 0;
         LoadData();
      }

      private void button2_Click(object sender, EventArgs e)
      {
         SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-US58GP1\SQLEXPRESS;Initial Catalog=Stock;Integrated Security=True");
         //Insert Logic
         con.Open();
         Boolean status = false;
         if (comboBox1.SelectedIndex == 0)
         {
            status = true;
         }
         else { status = false; }

         SqlCommand cmd = new SqlCommand(@"INSERT INTO [Stock].[dbo].[Products]
           ([ProductCode]
           ,[ProductName]
           ,[ProductStatus])
     VALUES
           ('" + textBox1.Text + "','" + textBox2.Text + "','" + status + "')", con);
         cmd.ExecuteNonQuery();
         con.Close();

         //Reading Data
         LoadData();

      }
      public void LoadData(){
         SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-US58GP1\SQLEXPRESS;Initial Catalog=Stock;Integrated Security=True");
         SqlDataAdapter sda = new SqlDataAdapter(@"SELECT [ProductCode],[ProductName],[ProductStatus]
         FROM[dbo].[Products]", con);
         DataTable dt = new DataTable();
         sda.Fill(dt);

         dataGridView1.Rows.Clear();
         foreach (DataRow item in dt.Rows)
         {
            int n = dataGridView1.Rows.Add();
            dataGridView1.Rows[n].Cells[0].Value = item["ProductCode"].ToString();
            dataGridView1.Rows[n].Cells[1].Value = item["ProductName"].ToString();
            if ((bool)item["ProductStatus"])
            {
               dataGridView1.Rows[n].Cells[2].Value = "Active";
            }
            else
            {
               dataGridView1.Rows[n].Cells[2].Value = "Deactive";
            }
         }
      }

      private void button1_Click(object sender, EventArgs e)
      {
         SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-US58GP1\SQLEXPRESS;Initial Catalog=Stock;Integrated Security=True");
         con.Open();
         SqlCommand cmd = new SqlCommand(@"DELETE FROM [dbo].[Products]
         WHERE ProductCode = '" + textBox1.Text + "'", con);
         cmd.ExecuteNonQuery();
         con.Close();
         LoadData();
      }

      private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
      {
         textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
         textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
         if (dataGridView1.SelectedRows[0].Cells[2].Value.ToString() == "Active")
         {
            comboBox1.SelectedIndex = 0;
         }
         else
         {
            comboBox1.SelectedIndex = 1;
         }
      }

      private void button3_Click(object sender, EventArgs e)
      {
         SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-US58GP1\SQLEXPRESS;Initial Catalog=Stock;Integrated Security=True");
         con.Open();

         String pCode = textBox1.Text;
         String pName = textBox2.Text;
         Boolean status = false;
         if (comboBox1.SelectedIndex == 0)
         {
            status = true;
         }
         else { status = false; }

         SqlCommand command = new SqlCommand("",con);
   
         command.CommandText = "UPDATE [dbo].[Products] SET ProductName = @pName, ProductStatus = @pStatus Where ProductCode = '"+pCode+"'";
         command.Parameters.AddWithValue("@pName", pName);
         command.Parameters.AddWithValue("@pStatus", status);
         command.ExecuteNonQuery();
         con.Close();
         LoadData();
      }

      private void button4_Click(object sender, EventArgs e)
      {
         textBox1.Clear();
         textBox2.Clear();
         comboBox1.SelectedIndex=0;
      }

      private void button5_Click(object sender, EventArgs e)
      {
         LoadData();
      }
   }
}
