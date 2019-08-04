using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client {
    public class DisplayFacade {

        private Adapters.INoteReader _readerAdapter;

        public DisplayFacade(Adapters.INoteReader readerAdapter) {
            _readerAdapter = readerAdapter;
        }

        public void DisplayNoteList(Adapters.INoteListDisplay adapter) {
            var useCase = new Case.DisplayNotesCase(_readerAdapter);
            useCase.DisplayList(adapter);
        }

        public void DisplayNote(Adapters.INoteDisplay adapter, int id) {
            var useCase = new Case.DisplayNotesCase(_readerAdapter);
            useCase.DisplayNote(adapter, id);
        }
    }
}

