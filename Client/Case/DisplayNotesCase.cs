using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Case {
    class DisplayNotesCase {

        private Adapters.INoteListDisplay _listAdapter;
        private Adapters.INoteDisplay _noteAdapter;
        private readonly Adapters.INoteReader _readerAdapter;

        public DisplayNotesCase(Adapters.INoteReader readerAdapter) {
            _readerAdapter = readerAdapter;
        }

        #region Methods
        public void DisplayList(Adapters.INoteListDisplay adapter) {
            _listAdapter = adapter;
            _listAdapter.DisplayList(_readerAdapter.GetAllNotes());
        }

        public void DisplayNote(Adapters.INoteDisplay adapter, int id) {
            _noteAdapter = adapter;
            _noteAdapter.DisplayNote(_readerAdapter.GetNoteById(id));
        }
        #endregion
    }
}
