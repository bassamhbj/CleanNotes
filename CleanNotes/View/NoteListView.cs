using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace CleanNotes.View {
    class NoteListView : Core.Adapters.INoteDisplay {

        public NoteListView() {

        }

        #region Methods
        public void CreateView() {
            var client = new Core.ActionFacade();
            client.DisplayNoteList();
        }

        private void ProcessList(List<NoteData> noteList) {
            foreach (var item in noteList) {
                Console.WriteLine($"Title: {item.Title} Body: {item.Body}");
            }
        }
        #endregion

        #region Override Methods
        public void DisplayList(List<NoteData> noteList) {
            ProcessList(noteList);
        }

        public void DisplayNote(NoteData note) {
            throw new NotImplementedException();
        }
        #endregion
    }
}
