using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Core.Entities;

namespace CleanNotesReact.Logic {
    public class NoteAdapter : Core.Adapters.INoteDisplay {

        public NoteAdapter() {

        }

        public void Get

        #region Override Methods
        public void DisplayList(List<NoteData> noteList) {
            throw new NotImplementedException();
        }

        public void DisplayNote(NoteData note) {
            throw new NotImplementedException();
        }
        #endregion
    }
}