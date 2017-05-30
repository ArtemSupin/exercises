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
    public partial class ExerControl : UserControl
    {
        public ExerControl()
        {
            InitializeComponent();

            runControl.Visible = false;
            swimmingControl.Visible = false;
            pressControl.Visible = false;
        }

        public IExercises Exercises
        {
            get
            {
                IExercises exercises = null;
                int ss = comboBoxExercises.SelectedIndex;

                switch (ss)
                {
                    case 0:
                        {
                            try
                            {
                                exercises = runControl.Run;
                            }
                            catch (FormatException exception)
                            {
                                throw exception;
                            }
                            break;
                        }
                    case 1:
                        {
                            try
                            {
                                exercises = swimmingControl.Swimming;
                            }
                            catch (FormatException exception)
                            {
                                throw exception;
                            }
                            break;
                        }
                    case 2:
                        {
                            try
                            {
                                exercises = pressControl.Press;
                            }
                            catch (FormatException exception)
                            {
                                throw exception;
                            }
                            break;
                        }
                }
                return exercises;
            }

            set
            {
                if (value is Run)
                {
                    comboBoxExercises.SelectedIndex = 0;
                    runControl.Run = (Run)value;
                }

                if (value is Swimming)
                {
                    comboBoxExercises.SelectedIndex = 1;
                    swimmingControl.Swimming = (Swimming)value;
                }

                if (value is Press)
                {
                    comboBoxExercises.SelectedIndex = 2;
                    pressControl.Press = (Press)value;
                }
            }
        }

        private void comboBoxExercises_SelectedIndexChanged(object sender, EventArgs e)
        {
            runControl.Visible = comboBoxExercises.SelectedIndex == 0;
            swimmingControl.Visible = comboBoxExercises.SelectedIndex == 1;
            pressControl.Visible = comboBoxExercises.SelectedIndex == 2;
        }
    }
}
