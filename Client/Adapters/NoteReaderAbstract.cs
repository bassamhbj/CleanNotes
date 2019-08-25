using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Adapters {
    public abstract class NoteReaderAbstract {

        public abstract List<Entities.NoteData> GetNoteList();

        public abstract Entities.NoteData GetNoteById(string ID);
    }
}