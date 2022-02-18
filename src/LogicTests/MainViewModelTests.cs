using NUnit.Framework;
using System;
using Core;

namespace LogicTests
{
    public class MainViewModelTests
    {
        private static object[] squareConditionCases = {
            new object[] {
                "10E40",
                (0).ToString(),
                (0).ToString(),
                false
            },
            new object[] { 
                (1f / 2f * (float)Math.Sqrt(float.MaxValue)).ToString(), 
                (1f / 2f * (float)Math.Sqrt(float.MaxValue)).ToString(),
                (1f / (float) Math.Sqrt(2) * (float) Math.Sqrt(float.MaxValue)).ToString(),
                false
            },
            new object[] {
                ((float)Math.Sqrt(float.MaxValue)).ToString(),
                ((float)Math.Sqrt(float.MaxValue)).ToString(),
                ((float)Math.Sqrt(2) * (float)Math.Sqrt(float.MaxValue)).ToString(),
                false
            },
        };

        [TestCaseSource(nameof(squareConditionCases))]
        [Test]
        public void SquareConditionTests(string a, string b, string c, bool excepted)
        {
            MainViewModel mVM = new MainViewModel(a, b, c);
            Assert.AreEqual(excepted, mVM.CheckSquareCondition());
        }
    }
}