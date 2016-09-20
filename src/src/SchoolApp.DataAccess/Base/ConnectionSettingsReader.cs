using SchoolApp.Data.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolApp.DataAccess.Base
{
    public class ConnectionSettingsReader
    {
        public static Func<ConnectionSettings> ConnectionSettingsProvider;
        private static ConnectionSettings aConnectionSettings = null;
        public static void SetConnectionSettingsProvider(ConnectionSettings connectionSettings)
        {
            aConnectionSettings = connectionSettings;

        }
        public static ConnectionSettings ReadConnectionSettings()
        {
            
            if (aConnectionSettings==null && ConnectionSettingsProvider != null)
            {
                aConnectionSettings = ConnectionSettingsProvider();
            }
            else
                throw new Exception("ConnectionSettingsProvider delegate is not set...");

            return aConnectionSettings;
        }
    }
}
