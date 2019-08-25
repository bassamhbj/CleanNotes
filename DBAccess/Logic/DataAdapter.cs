using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Core.Entities;

namespace DBAccess.Logic {
    internal class DataAdapter {

        public DataAdapter() {

        }

        public List<NoteData> TransformDataTable(DataTable targetDt) {
            var list = new List<NoteData>();

            foreach (DataRow row in targetDt.Rows) {
                list.Add(TransformRow(row));
            }

            return list;
        }

        public NoteData TransformRow(DataRow targetRow) {
            var note = new NoteData() {
                ID = targetRow["ID"].ToString(),
                Title = targetRow["Title"].ToString(),
                Body = targetRow["Body"].ToString(),
                CreateDate = (DateTime)targetRow["CreateDate"],
                EditDate = (DateTime)targetRow["EditDate"]
            };

            return note;
        }
    }
}
