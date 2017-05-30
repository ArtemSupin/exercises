using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Calories.View
{
    static class RandomExercises
    {
        public static IExercises GenerateRun()
        {
            Random rand = new Random();
            
            var run = new Run();
            run.Distance = rand.Next(1, 199);
            run.Intencive = rand.Next(2);
            return run;
        }

        public static IExercises GenerateSwimming()
        {
            Random rand = new Random();
            
            var swimming = new Swimming();
            swimming.Distance = rand.Next(1, 199);
            swimming.StyleSwimming = rand.Next(2);
            return swimming;
        }

        public static IExercises GeneratePress()
        {
            Random rand = new Random();
            
            var press = new Press();
            press.Repeats = rand.Next(1, 499);
            press.Weight = rand.Next(1, 499);
            press.StylePress = rand.Next(1);
            return press;
        }
    }
}
