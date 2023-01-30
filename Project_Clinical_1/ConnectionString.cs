using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Project_Clinical_1
{
    internal class ConnectionString
    {
        public SqlConnection GetCon()
        {
            SqlConnection Con = new SqlConnection();
            Con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\NILE UNIVERSTY\COURSES\Fall22\BMD_302\Clinical_WorkSpace\Clinical_Project-main\Project_Clinical_1\Clinical_DB.mdf"";Integrated Security=True;Connect Timeout=30";
            return Con;
        }
    }
}
