using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock
{
   public static class Connection
   {
      public static SqlConnection GetConnection()
      {
         SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-US58GP1\SQLEXPRESS;Initial Catalog=Stock;Integrated Security=True");
         return conn;
      }
   }
}
