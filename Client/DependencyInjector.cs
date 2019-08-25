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

        protected void InjectNoteDisplay(Adapters.INoteDisplay injection) =>
            Dependency.NoteDisplay = injection;

        protected void InjectNoteReader(Adapters.NoteReaderAbstract injection) =>
            Dependency.NoteReader = injection;

        protected void InjectNoteCreator(Adapters.NoteCreatorAbstract injection) =>
            Dependency.NoteCreator = injection;
    }
}
