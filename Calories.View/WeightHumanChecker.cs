using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calories.View
{
    static class WeightHumanChecker
    {
        public static bool CheckWeight(string ss)
        {
            if (ss == "")
            {
                MessageBox.Show(@"Human weight is empty");
                return false;
            }
            if (Convert.ToDouble(ss) < 50 || Convert.ToDouble(ss) > 150)
            {
                MessageBox.Show(@"Human weight must be 50 .. 150");
                return false;
            }
            try
            {
                double weight = Convert.ToDouble(ss);
            }
            catch (FormatException)
            {
                MessageBox.Show(@"Error with human weight");
                return false;
            }
            return true;
        }
    }
}
