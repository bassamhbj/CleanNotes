using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Adapters {
    public interface INoteReader {
        List<Entities.NoteData> GetAllNotes();
        Entities.NoteData GetNoteById(int id);
    }
}
