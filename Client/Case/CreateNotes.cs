using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Case {
    public class CreateNotes {

        public CreateNotes() {
            if (DependencyInjector.Dependency.DataCreator == null)
                throw new ArgumentNullException("DataCreator dependency is NULL");

        }

        #region Methods
        public bool CreateNote(string title, string body) {
            string ID = Guid.NewGuid().ToString();
            return DependencyInjector.Dependency.DataCreator.CreateNote(ID, title, body);
        }
        #endregion
    }
}
