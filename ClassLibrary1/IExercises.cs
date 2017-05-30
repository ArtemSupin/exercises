using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calories
{
    public interface IExercises
    {
        /// <summary>
        /// Название упражнения
        /// </summary>
        string NameExercises { get; }

        /// <summary>
        /// Подсчет потраченных калорий
        /// </summary>
        /// <param name="weightHuman">Вес человека</param>
        /// <param name="CaloricCoefficient">Калорийный коэфициент</param>
        /// <returns>Потраченные калории</returns>
        double CalculateCalories(double weightHuman);
        
    }
}
