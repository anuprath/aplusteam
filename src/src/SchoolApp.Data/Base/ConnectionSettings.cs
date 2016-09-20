using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolApp.Data.Base
{
    public class ConnectionSettings
    {
        public string MongoDBClusterIP { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string PortNumber { get; set; }
        public string DatabaseName { get; set; }
    }
}
