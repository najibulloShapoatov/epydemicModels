using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;

namespace EpydemicModels
{
    public class Utils
    {

        public static Form mainForm = new MainForm();
        public static Form sirForm = new SIRForm();
        public static Form seirdForm = new SEIRDForm();
        public static Form seihfrForm = new SEIHFRForm();
        public static Form seihfrdForm = new SEIHFRDForm();
        public static Form seirhcdForm = new SEIRHCDForm();

        //Convert and check correct value

        public static double toDoble(string str)
        {
            try
            {
                return double.Parse(str, CultureInfo.InvariantCulture.NumberFormat);
            }
            catch (Exception ex)
            {
                MessageBox.Show("\t\"" + str + "\"\t" + ex.Message, "Хатоги дар дохилкуни");
                return 0.00;
            }
        }
    }
}
