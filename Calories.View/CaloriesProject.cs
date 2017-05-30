using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calories.View
{
    [Serializable]
    class CaloriesProject
    {
        public List<IExercises> Exerciseses { get; set; }

        private double _weightHuman;

        public double WeightHuman
        {
            get { return _weightHuman; }

            set
            {
                if (value < 0 || value > 300)
                {
                    throw new ArgumentException(@"Error with weight Human");
                }
                _weightHuman = value;
            }
        }
    }
}
