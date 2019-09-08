using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Case {
    public class DisplayNotes {

        public DisplayNotes() {
            if (DependencyInjector.Dependency.DataReader == null)
                throw new ArgumentNullException("NoteReader dependency is NULL");
        }

        #region Methods
        public List<NoteData> GetNoteList() {
            return DependencyInjector.Dependency.DataReader.GetNoteList();
        }

        public List<NoteData> GetNoteById(string ID) {
            var list = new List<NoteData>() {
                DependencyInjector.Dependency.DataReader.GetNoteById(ID)
            };

            return list;
        }
        #endregion
    }
}
