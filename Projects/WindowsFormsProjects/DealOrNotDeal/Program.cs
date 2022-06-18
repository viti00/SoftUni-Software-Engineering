using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DealOrNotDeal
{
    static class Program
    {

        public static int count = 0;
        public static Dictionary<int, double> boxesData = new Dictionary<int, double>();
        public static List<double> prices = new List<double>();
        public static Dictionary<int, double> boxes = new Dictionary<int, double>();
        public static int boxNumeric = 1;
        public static Dictionary<int, double> yourBox = new Dictionary<int, double>();
        public static int offersCount = 0;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
