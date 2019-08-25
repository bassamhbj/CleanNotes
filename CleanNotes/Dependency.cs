using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanNotes {
    public class Dependency : Core.DependencyInjector {

        public Dependency() : base() {

        }

        public void AddDependencies() {
            base.InjectNoteReader(new DBAccess.DataReader());
            base.InjectNoteCreator(new DBAccess.DataCreator());
            base.InjectNoteDisplay(new View.NoteListView());
        }
    }
}
