using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities {
    public class NoteData {

        public NoteData() {

        }

        #region Properties
        public string ID { get; set; } = "";
        public string Title { get; set; } = "";
        public string Body { get; set; } = "";
        public DateTime EditDate { get; set; }
        public DateTime CreateDate { get; set; }
        #endregion

        #region Methods
        #endregion
    }
}
