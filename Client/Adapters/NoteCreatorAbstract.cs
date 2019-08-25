using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Adapters {
    public abstract class NoteCreatorAbstract {

        public enum ReturnCode {
            SUCCESS,
            ERROR
        }

        public abstract ReturnCode CreateNote(string title, string body);
    }
}
