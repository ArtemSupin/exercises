using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calories;
using Calories;

namespace ConsoleApplicationCalories
{
    class Program
    {
        static void Main(string[] args)
        {
            IExercises exercises;

            Console.WriteLine(@"Введите номер упражнения");

            Console.WriteLine(@"1 - бег");

            Console.WriteLine(@"2 - плавание");

            Console.WriteLine(@"3 - жим");

            int n = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            switch (n)
            {
                case 1:
                {
                    var run = new Run();
                    Console.WriteLine(run.NameExercises);
                    run.Distance = 10;
                    run.Intencive = 1;
                    exercises = run;
                    Console.WriteLine(@"Калории - " + exercises.CalculateCalories(70));
                    break;
                }
                case 2:
                {
                    var swimming = new Swimming();
                    Console.WriteLine(swimming.NameExercises);
                    swimming.Distance = 10;
                    swimming.StyleSwimming = 0;
                    exercises = swimming;
                    Console.WriteLine(@"Калории - " + exercises.CalculateCalories(70));
                    break;
                }
                case 3:
                {
                    var press = new Press();
                    Console.WriteLine(press.NameExercises);
                    press.Repeats = 10;
                    press.Weight = 80;
                    press.StylePress = 0;
                    exercises = press;
                    Console.WriteLine(@"Калории - " + exercises.CalculateCalories(70));
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
