using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Adapters;

namespace DBAccess {
    public class DataCreator : Core.Adapters.NoteCreatorAbstract {

        public override ReturnCode CreateNote(string title, string body) {
            var creator = new Logic.NoteCreator();
            int result = creator.CreateNote(title, body);

            return result == 0 ? ReturnCode.ERROR : ReturnCode.SUCCESS;
        }

    }
}
