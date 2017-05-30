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
    public partial class RunControl : UserControl
    {
        public RunControl()
        {
            InitializeComponent();
        }

        public Run Run
        {
            get
            {
                var run = new Run();
                run.Intencive = comboBoxIntence.SelectedIndex;
                if (comboBoxIntence.SelectedItem == null)
                {
                    return null;
                }
                try
                {
                    run.Distance = Convert.ToInt32(textBoxDistanceRun.Text);
                }
                catch (FormatException)
                {
                    var exception = new FormatException(@"Error with run distance");
                    throw exception;
                }
                return run;
            }

            set
            {
                textBoxDistanceRun.Text = value.Distance.ToString();
                comboBoxIntence.SelectedIndex = value.Intencive;
            }
        }
    }
}
