using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Adapters {
    public interface INoteDisplay {
        void DisplayNote(Entities.NoteData note);
        void DisplayList(List<Entities.NoteData> noteList);
    }
}
