using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core {
    public class DependencyInjector {

        internal static Entities.Dependencies Dependency { get; set; }

        public DependencyInjector() {
            Dependency = Dependency ?? new Entities.Dependencies();
        }

        protected void InjectDataReader(Adapters.DataReaderAbstract injection) =>
            Dependency.DataReader = injection;

        protected void InjectDataCreator(Adapters.DataCreatorAbstract injection) =>
            Dependency.DataCreator = injection;
    }
}
