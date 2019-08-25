using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace DataAccess {
    public class DataAccess : Core.Adapters.INoteDisplay {

        public DataAccess() {

        }

        public void DisplayList(List<NoteData> noteList) {
            throw new NotImplementedException();
        }

        public void DisplayNote(NoteData note) {
            throw new NotImplementedException();
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
