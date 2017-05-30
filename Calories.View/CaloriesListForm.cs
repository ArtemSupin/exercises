using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace Calories.View
{
    public partial class CaloriesListForm : Form
    {
        public CaloriesListForm()
        {
            InitializeComponent();
#if !DEBUG
            buttonRandom.Visible = false;
#endif
            _caloriesProject = new CaloriesProject();
            _caloriesProject.WeightHuman = Convert.ToDouble(textBoxWeightHuman.Text);
            _caloriesProject.Exerciseses = _exercises;

            _exercises = new List<IExercises>();
        }

        private CaloriesProject _caloriesProject;
        
        /// <summary>
        /// Список упражнений
        /// </summary>
        private List<IExercises> _exercises  { get; set; }

        /// <summary>
        /// Добавление нового элемента
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (WeightHumanChecker.CheckWeight(textBoxWeightHuman.Text) == false)
            {
                return;
            }

            var form = new CaloriesForm();

            if (form.ShowDialog() == DialogResult.OK)
            {
                var exercises = form.Exercises;
                if (exercises == null)
                {
                    return;
                }
                _exercises.Add(exercises);
                dataGridViewCalories.Rows.Add(exercises.NameExercises,
                    exercises.CalculateCalories(Convert.ToDouble(textBoxWeightHuman.Text)));
            }
        }

        /// <summary>
        /// Изменение элемента
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (WeightHumanChecker.CheckWeight(textBoxWeightHuman.Text) == false || _exercises.Count == 0)
            {
                return;
            }
            
            int indexDataGridView = dataGridViewCalories.SelectedCells[0].RowIndex;

            double c = Convert.ToDouble(dataGridViewCalories.Rows[indexDataGridView].Cells[1].Value);
                
            var n = 0;
            if (Math.Abs(c - _exercises[indexDataGridView].CalculateCalories(Convert.ToDouble(textBoxWeightHuman.Text))) > 0)
            {
                for (int i = 0; i < _exercises.Count; i++)
                {
                    var calories = _exercises[i].CalculateCalories(Convert.ToDouble(textBoxWeightHuman.Text));
                    if (c == calories)
                    {
                        n = i;
                        break;
                    }
                }
            }
            else
            {
                n = indexDataGridView;
            }

            var form = new CaloriesForm
            {
                Exercises = _exercises[n]
            };
            

            form.ShowDialog();

            var exercises = form.Exercises;

            if (exercises == null)
            {
                return;
            }

            _exercises.RemoveAt(n);
            _exercises.Insert(n, exercises);
            dataGridViewCalories.Rows.RemoveAt(indexDataGridView);
            dataGridViewCalories.Rows.Insert(indexDataGridView, exercises.NameExercises,
                exercises.CalculateCalories(Convert.ToDouble(textBoxWeightHuman.Text)));

        }

        /// <summary>
        /// Удаление элемента
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (_exercises.Count == 0)
            {
                return;
            }

            int indexDataGridView = dataGridViewCalories.SelectedCells[0].RowIndex;
            double c = Convert.ToDouble(dataGridViewCalories.Rows[indexDataGridView].Cells[1].Value);

            var n = 0;
            if (Math.Abs(c - _exercises[indexDataGridView].CalculateCalories(Convert.ToDouble(textBoxWeightHuman.Text))) > 0)
            {
                for (int i = 0; i < _exercises.Count; i++)
                {
                    var calories = _exercises[i].CalculateCalories(Convert.ToDouble(textBoxWeightHuman.Text));
                    if (c == calories)
                    {
                        n = i;
                        break;
                    }
                }
            }
            else
            {
                n = indexDataGridView;
            }

            _exercises.RemoveAt(n);
            dataGridViewCalories.Rows.RemoveAt(indexDataGridView);
        }

        /// <summary>
        /// Пересчитать при другом весе
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRecalculate_Click(object sender, EventArgs e)
        {
            if (textBoxWeightHuman.Text == "" || _exercises.Count == 0)
            {
                MessageBox.Show(@"Error with recalculate");
                return;
            }

            for (int i = 0; i < _exercises.Count; i++)
            {
                dataGridViewCalories.Rows[i].Cells[1].Value =
                    _exercises[i].CalculateCalories(Convert.ToDouble(textBoxWeightHuman.Text));
            }
        }

        /// <summary>
        /// Добавление рандомного элемента
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRandom_Click(object sender, EventArgs e)
        {
            if (WeightHumanChecker.CheckWeight(textBoxWeightHuman.Text) == false)
            {
                return;
            }

            var rand = new Random();

            int n = rand.Next(3);

            IExercises exer = null;

            switch (n)
            {
                case 0:
                {
                    exer = RandomExercises.GenerateRun();
                    break;
                }
                case 1:
                {
                    exer = RandomExercises.GenerateSwimming();
                    break;
                }
                case 2:
                {
                    exer = RandomExercises.GeneratePress();
                    break;
                }
            }

            _exercises.Add(exer);
            dataGridViewCalories.Rows.Add(exer.NameExercises,
                exer.CalculateCalories(Convert.ToDouble(textBoxWeightHuman.Text)));
        }

        /// <summary>
        /// Сериализация
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _caloriesProject.Exerciseses = _exercises;
            _caloriesProject.WeightHuman = Convert.ToDouble(textBoxWeightHuman.Text);
            SerializeElement.Serilization(_caloriesProject);
        }

        /// <summary>
        /// Десериализация
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            _caloriesProject = SerializeElement.Deserilization();
            if (_caloriesProject == null)
            {
                return;
            }

            textBoxWeightHuman.Text = _caloriesProject.WeightHuman.ToString(CultureInfo.InvariantCulture);
            _exercises = _caloriesProject.Exerciseses;
            dataGridViewCalories.Rows.Clear();

            for (int i = 0; i < _exercises.Count; i++)
            {
                dataGridViewCalories.Rows.Add(_exercises[i].NameExercises,
                    _exercises[i].CalculateCalories(Convert.ToDouble(textBoxWeightHuman.Text)));
            }
        }

        /// <summary>
        /// Поиск
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            var form = new SearchForm(_exercises, Convert.ToDouble(textBoxWeightHuman.Text));
            form.ShowDialog();
        }

        /// <summary>
        /// Выбор элемента таблицы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewCalories_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int indexDataGridView = dataGridViewCalories.SelectedCells[0].RowIndex;

            double c = Convert.ToDouble(dataGridViewCalories.Rows[indexDataGridView].Cells[1].Value);

            var n = 0;
            if (Math.Abs(c - _exercises[indexDataGridView].CalculateCalories(Convert.ToDouble(textBoxWeightHuman.Text))) > 0)
            {
                for (int i = 0; i < _exercises.Count; i++)
                {
                    var calories = _exercises[i].CalculateCalories(Convert.ToDouble(textBoxWeightHuman.Text));
                    if (c == calories)
                    {
                        n = i;
                        break;
                    }
                }
            }
            else
            {
                n = indexDataGridView;
            }
            exerControl.Exercises = _exercises[n];
        }
    }
}
