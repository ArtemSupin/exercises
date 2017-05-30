using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calories;

namespace Calories
{
    [Serializable]
    public class Press : IExercises
    {
        /// <summary>
        /// Название упражнения
        /// </summary>
        public string NameExercises { get; } = @"Press";
        
        /// <summary>
        /// Стиль
        /// </summary>
        enum Style
        {
            WithLegs,
            WithoutLegs
        }

        private Style _style;

        public int StylePress
        {
            get { return Convert.ToInt32(_style); }

            set
            {
                _style = (Style) value;
            }
        }

        /// <summary>
        /// Вес штанги
        /// </summary>
        private double _weight;

        /// <summary>
        /// Аксессоры на вес штанги
        /// </summary>
        public double Weight
        {
            get { return _weight; }

            set
            {
                if (value <= 0 || value > 500)
                {
                    throw new ArgumentException(@"Error with weight");
                }
                _weight = value;
            }
        }

        /// <summary>
        /// Повторения
        /// </summary>
        private int _repeats;

        /// <summary>
        /// Аксессоры на повторение
        /// </summary>
        public int Repeats
        {
            get { return _repeats; }

            set
            {
                if (value <= 0 || value > 500)
                {
                    throw new ArgumentException(@"Error with repeats");
                }
                _repeats = value;
            }
        }

        /// <summary>
        /// Подсчет калорий
        /// </summary>
        /// <param name="weightHuman">Вес человека</param>
        /// <param name="style">Стиль</param>
        /// <returns>Потраченные калории</returns>
        public double CalculateCalories(double weightHuman)
        {
            if (_style == Style.WithLegs)
            {
                return _weight*weightHuman*_repeats*0.026;
            }
            if (_style == Style.WithoutLegs)
            {
                return _weight*weightHuman*_repeats*0.017;
            }
            return 0;
        }

        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="weight">Вес штанги</param>
        /// <param name="repeats">Повторения</param>
        public Press(double weight, int repeats, int style)
        {
            Weight = weight;
            Repeats = repeats;
            StylePress = style;
        }
         
        /// <summary>
        /// Конструктор
        /// </summary>
        public Press()
        {
            
        }
    }
}
