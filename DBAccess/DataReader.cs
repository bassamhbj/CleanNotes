using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace DBAccess {
    public class DataReader : Core.Adapters.NoteReaderAbstract {

        public override NoteData GetNoteById(string ID) {
            return new Logic.NoteReader().GetNoteById(ID);
        }

        public override List<NoteData> GetNoteList() {
            return new Logic.NoteReader().GetAllNotes();
        }
    }
}
