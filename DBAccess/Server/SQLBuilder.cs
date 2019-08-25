using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DBAccess.Server {
    internal class SQLBuilder {

        public SQLBuilder() {

        }

        public Tuple<string, List<SqlParameter>> SelectAll() {
            string sql = "";
            var dbParams = new List<SqlParameter>();

            sql += Environment.NewLine + "SELECT * ";
            sql += Environment.NewLine + "FROM TNotes ";
            sql += Environment.NewLine + "ORDER BY EditDate DESC ";

            return new Tuple<string, List<SqlParameter>>(sql, dbParams);
        }

        public Tuple<string, List<SqlParameter>> SelectByID(string id) {
            string sql = "";
            var dbParams = new List<SqlParameter>();

            sql += Environment.NewLine + "SELECT * ";
            sql += Environment.NewLine + "FROM TNotes ";
            sql += Environment.NewLine + "WHERE ID = @ID ";
            sql += Environment.NewLine + "ORDER BY EditDate DESC ";

            dbParams.Add(new SqlParameter("ID", id));

            return new Tuple<string, List<SqlParameter>>(sql, dbParams);
        }

        public Tuple<string, List<SqlParameter>> Insert(string id, string title, string body) {
            string sql = "";
            var dbParams = new List<SqlParameter>();

            sql += Environment.NewLine + "INSERT INTO TNotes ( ";
            sql += Environment.NewLine + "    ID ";
            sql += Environment.NewLine + "    ,Title ";
            sql += Environment.NewLine + "    ,Body ";
            sql += Environment.NewLine + "    ,CreateDate ";
            sql += Environment.NewLine + "    ,EditDate ";
            sql += Environment.NewLine + ") VALUES ( ";
            sql += Environment.NewLine + "    @ID ";
            sql += Environment.NewLine + "    ,@Title ";
            sql += Environment.NewLine + "    ,@Body ";
            sql += Environment.NewLine + "    ,GETDATE() ";
            sql += Environment.NewLine + "    ,GETDATE() ";
            sql += Environment.NewLine + ") ";

            dbParams.Add(new SqlParameter("ID", id));
            dbParams.Add(new SqlParameter("Title", title));
            dbParams.Add(new SqlParameter("Body", body));

            return new Tuple<string, List<SqlParameter>>(sql, dbParams);
        }
    }
}
