using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DBAccess.Logic {
    internal class NoteReader {

        public NoteReader() {

        }

        public List<Core.Entities.NoteData> GetAllNotes() {
            var sql = new Server.SQLBuilder();
            var tuple = sql.SelectAll();

            return DoGetNotes(tuple.Item1, tuple.Item2);            
        }

        public Core.Entities.NoteData GetNoteById(string ID) {
            var sql = new Server.SQLBuilder();
            var tuple = sql.SelectByID(ID);

            var list = DoGetNotes(tuple.Item1, tuple.Item2);

            return list.Count > 0 ? list[0] : new Core.Entities.NoteData() { ID = "-1" };
        }

        private List<Core.Entities.NoteData> DoGetNotes(string sql, List<SqlParameter> dbParams) {
            var db = new Server.DB();
            var dt = db.Select(sql, dbParams.ToArray());

            return new DataAdapter().TransformDataTable(dt);
        }
    }
}
