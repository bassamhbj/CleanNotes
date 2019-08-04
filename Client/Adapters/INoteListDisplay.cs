using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Adapters {
    public interface INoteListDisplay {
        void DisplayList(List<Entities.NoteData> noteList);
    }
}
