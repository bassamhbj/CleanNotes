using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Entities {
    public class NoteData {

        public NoteData() {

        }

        #region Properties
        public int ID { get; set; } = 0;
        public string Title { get; set; } = "";
        public string Body { get; set; } = "";
        public DateTime ModifiedDate { get; set; }
        public int CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        #endregion

        #region Methods
        #endregion
    }
}
