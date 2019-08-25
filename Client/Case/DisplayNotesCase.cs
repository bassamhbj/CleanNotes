using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Case {
    class DisplayNotesCase {

        public DisplayNotesCase() {
            if (DependencyInjector.Dependency.NoteReader == null)
                throw new ArgumentNullException("NoteReader dependency is NULL");

            if (DependencyInjector.Dependency.NoteDisplay == null)
                throw new ArgumentNullException("NoteDisplay dependecy is NULL");
        }

        #region Methods
        public void DisplayList() {
            DependencyInjector.Dependency.NoteDisplay.DisplayList(DependencyInjector.Dependency.NoteReader.GetNoteList());
        }

        public void DisplayNote(string id) {
            DependencyInjector.Dependency.NoteDisplay.DisplayNote(DependencyInjector.Dependency.NoteReader.GetNoteById(id));
        }
        #endregion
    }
}
