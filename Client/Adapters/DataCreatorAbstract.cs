using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Adapters {
    public abstract class DataCreatorAbstract {
        public abstract bool CreateNote(string ID, string title, string body);
    }
}
