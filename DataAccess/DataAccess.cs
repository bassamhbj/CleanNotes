using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.Entities;

namespace DataAccess {
    public class DataAccess : Client.Adapters.INoteReader {

        public DataAccess() {

        }

        public List<NoteData> GetAllNotes() {
            var data = new DummyData();
            return data.GetNoteList();
        }

        public NoteData GetNoteById(int id) {
            var data = new DummyData();
            return data.GetNoteByID(id);
        }
    }
}
