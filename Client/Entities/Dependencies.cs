using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities {
    public class Dependencies {
        public Adapters.INoteDisplay NoteDisplay { get; set; } = null;
        public Adapters.NoteCreatorAbstract NoteCreator { get; set; } = null;
        public Adapters.NoteReaderAbstract NoteReader { get; set; } = null;
    }
}
