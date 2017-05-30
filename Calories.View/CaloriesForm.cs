using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calories.View
{
    public partial class CaloriesForm : Form
    {
        public CaloriesForm()
        {
            InitializeComponent();
        }
        
        public IExercises Exercises
        {
            get
            {
                try
                {
                    var cathThrowElements = exerControl.Exercises;
                }
                catch (FormatException exception)
                {
                    MessageBox.Show(exception.Message);
                    return null;
                }
                catch (ArgumentException)
                {
                    MessageBox.Show(@"Error");
                    return null;
                }
                return exerControl.Exercises;
            }

            set
            {
                try
                {
                    exerControl.Exercises = value;
                }
                catch (FormatException exception)
                {
                    MessageBox.Show(exception.Message);
                    throw;
                }
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
