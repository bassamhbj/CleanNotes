using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.Entities;

namespace CleanNotes.View {
    class NoteListView : Client.Adapters.INoteListDisplay {

        public NoteListView() {

        }

        #region Methods
        public void CreateView() {
            var client = new Client.DisplayFacade(new DataAccess.DataAccess());
            client.DisplayNoteList(this);
        }

        private void ProcessList(List<NoteData> noteList) {
            foreach (var item in noteList) {
                Console.WriteLine($"Title: {item.Title}");
            }
        }
        #endregion

        #region Override Methods
        public void DisplayList(List<NoteData> noteList) {
            ProcessList(noteList);
        }
        #endregion
    }
}
