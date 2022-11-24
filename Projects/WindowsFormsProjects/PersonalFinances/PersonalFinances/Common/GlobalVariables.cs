using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PersonalFinances.Common.GlobalConstants;

namespace PersonalFinances.Common
{
    public class GlobalVariables
    {
        public static string clientId;
        public static string dossierId;
        public static List<Form> hiddenForms;
        public static bool isAdministrator;
        public static Form previousForm;
        public static string connectionString = ConfigurationManager.ConnectionStrings[connectionStringName].ConnectionString;
    }
}
