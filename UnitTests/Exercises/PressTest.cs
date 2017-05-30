using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calories;
using NUnit.Framework;

namespace UnitTests.Exercises
{
    [TestFixture]
    class PressTest
    {
        [Test]
        [TestCase(1, TestName = "Testing repeats with Assignment 1")]
        [TestCase(-1, ExpectedException = typeof(ArgumentException), TestName = "Testing repeats with Assignment -1")]
        [TestCase(0, ExpectedException = typeof(ArgumentException), TestName = "Testing repeats with Assignment 0")]
        public void Repeats(int repeats)
        {
            var press = new Press();
            press.Repeats = repeats;
        }

        [Test]
        [TestCase(1, TestName = "Testing weight with Assignment 1")]
        [TestCase(-1, ExpectedException = typeof(ArgumentException), TestName = "Testing weight with Assignment -1")]
        [TestCase(double.MaxValue, ExpectedException = typeof(ArgumentException), TestName = "Testing weight with Assignment double max value")]
        public void Weight(double weight)
        {
            var press = new Press();
            press.Weight = weight;
        }

        [Test, TestCaseSource(nameof(CalculateTest))]
        public void CalculateCaloriesTest(double weightHuman, double weight, int repeats, int style, double result)
        {
            var press = new Press(weight, repeats, style);
            var calories = press.CalculateCalories(weightHuman);

            Assert.AreEqual(result, calories);
        }

        static readonly TestCaseData[] CalculateTest =
        {
            new TestCaseData(70, 80, 5, 0, 728), // Тестирование в позитивном ключе 
            new TestCaseData(60, 75 , 10, 1, 765),
            new TestCaseData(100, 120 , 12, 0 , 3744)
        };
    }
}
