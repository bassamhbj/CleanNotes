using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities {
    public class Dependencies {
        public Adapters.DataReaderAbstract DataReader { get; set; } = null;
        public Adapters.DataCreatorAbstract DataCreator { get; set; } = null;
    }
}
