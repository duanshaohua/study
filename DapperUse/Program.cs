using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace DapperUse
{
    class Program
    {
        static void Main(string[] args)
        {
            using (IDbConnection db = new SqlConnection("server=.;uid=sa;pwd=sa;database=DSHCMS2000;"))
            {
                string sql = "";
                db.Query(sql);
            }
        }
    }
}
