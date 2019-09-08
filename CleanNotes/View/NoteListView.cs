using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace CleanNotes.View {
    class NoteListView {

        public NoteListView() {

        }

        #region Methods
        public void CreateView() {
            var client = new Core.Case.DisplayNotes();
            var notes = client.GetNoteList();
            ProcessList(notes);
        }

        private void ProcessList(List<NoteData> noteList) {
            foreach (var item in noteList) {
                Console.WriteLine($"Title: {item.Title} Body: {item.Body}");
            }
        }
        #endregion
    }
}
