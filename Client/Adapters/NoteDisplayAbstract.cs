using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Adapters {
    public abstract class NoteDisplayAbstract {

        public abstract void DisplayNote(Entities.NoteData note);

        public abstract void DisplayList(List<Entities.NoteData> noteList);
    }
}
