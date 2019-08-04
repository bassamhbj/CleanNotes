using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities {
    public class Note {

        public Note() {

        }


        #region Properties
        public int ID { get; set; } = 0;
        public string Title { get; set; } = "";
        public string Body { get; set; } = "";
        public DateTime ModifiedDate { get; set; }
        #endregion

        #region Methods
        #endregion
    }
}
