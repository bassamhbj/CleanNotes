using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DBAccess.Server {
    internal class DB {

        private readonly string CONNECTION_STR;

        public DB() {
            CONNECTION_STR = ConfigurationManager.ConnectionStrings["Default"].ToString();
        }

        public DataTable Select(string sql, SqlParameter[] dbParams) {
            DataTable dataTable = new DataTable();

            using(SqlConnection cnn = new SqlConnection(CONNECTION_STR)) {
                using (SqlDataAdapter adapter = new SqlDataAdapter(sql, cnn)) {
                    adapter.SelectCommand.Parameters.AddRange(dbParams);
                    adapter.Fill(dataTable);
                }
            }

            return dataTable;
        }
    
        public int Insert(string sql, SqlParameter[] dbParams) {
            int result = 0;

            using (SqlConnection cnn = new SqlConnection(CONNECTION_STR)) {
                var command = new SqlCommand(sql, cnn);
                command.Parameters.AddRange(dbParams);

                result = command.ExecuteNonQuery();
            }

            return result;
        }
    }
}
