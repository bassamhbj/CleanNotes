using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Core.Tools {
    public static class Settings {
        public static string DBConnection {
            get { return ConfigurationManager.ConnectionStrings["Default"].ToString(); }
        }
    }
}
