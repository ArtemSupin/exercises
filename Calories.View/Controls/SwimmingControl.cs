using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calories.View.Controls
{
    public partial class SwimmingControl : UserControl
    {
        public SwimmingControl()
        {
            InitializeComponent();
        }

        public Swimming Swimming
        {
            get
            {
                var swimming = new Swimming();
                swimming.StyleSwimming = comboBoxStyleSwimming.SelectedIndex;
                if (comboBoxStyleSwimming.SelectedItem == null)
                {
                    return null;
                }
                try
                {
                    swimming.Distance = Convert.ToDouble(textBoxDistanceSwimming.Text);
                }
                catch (FormatException)
                {
                    var exception = new FormatException(@"Error wth swimming distance");
                    throw exception;
                }

                return swimming;
            }

            set
            {
                textBoxDistanceSwimming.Text = value.Distance.ToString();
                comboBoxStyleSwimming.SelectedIndex = value.StyleSwimming;
            }
        }
    }
}
