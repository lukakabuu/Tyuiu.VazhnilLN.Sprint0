using System;
using System.ComponentModel.DataAnnotations;
using Tyuiu.VazhnikLN.Sprint0.Task2.V0.Lib;


namespace Tyuiu.VazhnikLN.Sprint0.Task2.V0.Test
{
    [TestClass]
    public sealed class DataserviceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Лука";
            var res = DataService.GetMessage(name);
            Assert.AreEqual("Привет, Лука", res);
        }
    }
}
