using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core {
    public abstract class NoteDisplayer {

        public NoteDisplayer() {
        }


        public abstract List<Entities.NoteData> DisplayNoteList();

        public abstract Entities.NoteData DisplayNote(string id);
    }
}

