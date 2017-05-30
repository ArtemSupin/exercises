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
    public partial class PressControl : UserControl
    {
        public PressControl()
        {
            InitializeComponent();
        }

        public Press Press
        {
            get
            {
                var press = new Press();
                press.StylePress = comboBoxStylePress.SelectedIndex;
                if (comboBoxStylePress.SelectedItem == null)
                {
                    return null;
                }
                try
                {
                    press.Repeats = Convert.ToInt32(textBoxRepeats.Text);
                }
                catch (FormatException)
                {
                    var exception = new FormatException(@"Error with press repeats");
                    throw exception;
                }

                try
                {
                    press.Weight = Convert.ToInt32(textBoxWeight.Text);
                }
                catch (FormatException)
                {
                    var exception = new FormatException(@"Error with run weight");
                    throw exception;
                }
                return press;
            }

            set
            {
                textBoxRepeats.Text = value.Repeats.ToString();
                textBoxWeight.Text = value.Weight.ToString();
                comboBoxStylePress.SelectedIndex = value.StylePress;
            }
        }
    }
}
