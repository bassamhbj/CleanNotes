using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core {
    public class ActionFacade {

        public ActionFacade() {
        }

        public void DisplayNoteList() {
            var useCase = new Case.DisplayNotesCase();
            useCase.DisplayList();
        }

        public void DisplayNote(string id) {
            var useCase = new Case.DisplayNotesCase();
            useCase.DisplayNote(id);
        }

        public void CreateNote(string title, string body) {

        }
    }
}

