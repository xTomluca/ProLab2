using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CentralitaHerencia;
namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCentralita()
        {
            Centralita centralita;

            centralita = new Centralita("asdasds");

            Assert.AreNotEqual(null, centralita.Llamadas);
        }
    }
}
