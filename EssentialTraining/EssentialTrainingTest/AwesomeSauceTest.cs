using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EssentialTraining;

namespace EssentialTrainingTest
{
    [TestClass]
    public class AwesomeSauceTest
    {
        [TestMethod]
        public void IsSauceAwesomeTest()
        {
            var testInstance = new AwesomeSauce();
            testInstance.Sauces.Add("Tobasco");
            testInstance.Sauces.Add("Cholula");

            //expect true
            Assert.IsTrue(testInstance.IsSauceAwesome("Tobasco"));

            //expect false
            Assert.IsFalse(testInstance.IsSauceAwesome("Ketchup"));

        }
    }
}
