using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calories
{
    [Serializable]
    public class Swimming : IExercises
    {
        /// <summary>
        /// Название упражнения
        /// </summary>
        public string NameExercises { get; } = @"Swimming";

        /// <summary>
        /// Стиль выполнения
        /// </summary>
        private enum Style
        {
            Bangle,
            Butterfly,
            Freestyle,
            Backswim
        }

        private Style _style;

        public int StyleSwimming
        {
            get { return Convert.ToInt32(_style); }

            set
            {
                _style = (Style) value;
            }
        }
        /// <summary>
        /// Дистанция
        /// </summary>
        private double _distance;

        /// <summary>
        /// аксессоры на дистанцию
        /// </summary>
        public double Distance
        {
            get { return _distance; }

            set
            {
                if (value <= 0 || value > 200)
                {
                    throw new ArgumentException("Error with distance");
                }
                _distance = value;
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
            if (_style == Style.Bangle)
            {
                return _distance*weightHuman*1;
            }
            if (_style == Style.Butterfly)
            {
                return _distance*weightHuman*1.1;
            }
            if (_style == Style.Freestyle)
            {
                return _distance*weightHuman*0.8;
            }
            if (_style == Style.Backswim)
            {
                return _distance*weightHuman*0.7;
            }
            return 0;
        }

        /// <summary>
        /// Конструктор с параметром
        /// </summary>
        /// <param name="distance"></param>
        public Swimming(double distance, int style)
        {
            Distance = distance;
            StyleSwimming = style;
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        public Swimming()
        {
            
        }
    }
}
