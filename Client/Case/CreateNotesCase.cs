using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Case {
    public class CreateNotesCase {

        public CreateNotesCase() {

        }

        public void CreateNote(string title, string body) {
            var result = DependencyInjector.Dependency.NoteCreator.CreateNote(title, body);

            if (result == Adapters.NoteCreatorAbstract.ReturnCode.SUCCESS) {

            } else {

            }
        }
    }
}
