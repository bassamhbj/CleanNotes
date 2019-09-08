using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Adapters;

namespace DBAccess {
    public class DataCreator : Core.Adapters.DataCreatorAbstract {

        public override bool CreateNote(string ID, string title, string body) {
            var creator = new Logic.NoteCreator();
            int result = creator.CreateNote(ID, title, body);

            return result >= 1;
        }

    }
}
