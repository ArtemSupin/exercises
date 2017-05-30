using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calories
{
    [Serializable]
    public class Run : IExercises
    {
        /// <summary>
        /// Название упражнения
        /// </summary>
        public string NameExercises { get; } = @"Run";

        /// <summary>
        /// Интенсивность выполнения
        /// </summary>
        private enum Intence
        {
            Slow,
            Middle,
            Fast
        }

        private Intence _intence;

        public int Intencive
        {
            get { return Convert.ToInt32(_intence); }
            set
            {
                _intence = (Intence)value;
            }
        }

        /// <summary>
        /// Дистанция
        /// </summary>
        private double _distance;

        /// <summary>
        /// Аксессоры на дистанцию
        /// </summary>
        public double Distance
        {
            get { return _distance; }

            set
            {
                if ((value <= 0) || (value > 200))
                {
                    throw new ArgumentException("Error with run distance");
                }
                _distance = value;
            }
        }

        /// <summary>
        /// Подсчет потраченных калорий
        /// </summary>
        /// <param name="weightHuman">Вес человека</param>
        /// <param name="intence">Интенсивность</param>
        /// <returns>Потраченные калории</returns>
        public double CalculateCalories(double weightHuman)
        {
            if (_intence == Intence.Slow)
            {
                return weightHuman*_distance*1;
            }
            if (_intence == Intence.Middle)
            {
                return weightHuman*_distance*1.56;
            }
            if (_intence == Intence.Fast)
            {
                return weightHuman*_distance*2;
            }
            return 0;
        }

        /// <summary>
        /// Конструктор с параметром
        /// </summary>
        /// <param name="distance">Дистанция</param>
        public Run(double distance, int intencive)
        {
            Distance = distance;
            Intencive = intencive;
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        public Run()
        {
            
        }
    }
}
