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
    class RunTest
    {
        [Test]
        [TestCase(1, TestName = "Testing distance with Assignment 1")]
        [TestCase(-1, ExpectedException = typeof(ArgumentException), TestName = "Testing distance with Assignment -1")]
        [TestCase(double.MaxValue, ExpectedException = typeof(ArgumentException), TestName = "Testing distance with Assignment double max value")]
        public void Distance(double distance)
        {
            var run = new Run();
            run.Distance = distance;
        }

        [Test, TestCaseSource(nameof(CalculateTest))]
        public void CalculateCaloriesTest(double weightHuman, double distance, int intencive, double result)
        {
            var run = new Run(distance, intencive);
            var calories = run.CalculateCalories(weightHuman);

            Assert.AreEqual(result, calories);
        }

        static readonly TestCaseData[] CalculateTest =
        {
            new TestCaseData(70, 10, 0, 700), // Тестирование в позитивном ключе 
            new TestCaseData(60, 15 , 1, 1404),
            new TestCaseData(100, 5 , 2, 1000)
        };
    }
}
