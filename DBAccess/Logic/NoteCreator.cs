﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBAccess.Logic {
    internal class NoteCreator {

        public NoteCreator() {

        }

        public int CreateNote(string title, string body) {
            string ID = Guid.NewGuid().ToString();

            var sql = new Server.SQLBuilder();
            var tuple = sql.Insert(ID, title, body);

            var db = new Server.DB();
            return db.Insert(tuple.Item1, tuple.Item2.ToArray());
        }
    }
}
