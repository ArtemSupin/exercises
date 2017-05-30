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
    public partial class SearchForm : Form
    {
        public SearchForm(List<IExercises> list, double weight)
        {
            InitializeComponent();
            _exercisesSearchList = list;
            _weight = weight;
        }

        private List<IExercises> _exercisesSearchList;

        private double _weight;

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            dataGridViewSearch.Rows.Clear();

            string ss = textBoxSearch.Text;
            int critation = comboBoxSearch.SelectedIndex;
            switch (critation)
            {
                case 0:
                {
                    foreach (var searchL in _exercisesSearchList)
                    {
                        if (searchL.NameExercises == ss)
                        {
                            dataGridViewSearch.Rows.Add(searchL.NameExercises, searchL.CalculateCalories(_weight));
                        }
                    }
                    break;
                }

                case 1:
                {
                    foreach (var searchL in _exercisesSearchList)
                    {
                        if (searchL.CalculateCalories(_weight).ToString() == ss)
                        {
                            dataGridViewSearch.Rows.Add(searchL.NameExercises, searchL.CalculateCalories(_weight));
                        }
                    }
                    break;
                }
            }
        }
    }
}
