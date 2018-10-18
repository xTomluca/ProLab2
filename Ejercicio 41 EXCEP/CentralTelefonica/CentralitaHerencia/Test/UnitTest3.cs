using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CentralitaHerencia;

namespace Test
{
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void TestMethod1()
        {
            /*Controlar mediante un nuevo método de test unitario que la excepción CentralitaExcepcion
            se lance al intentar cargar una segunda llamada con solamente los mismos datos de origen y
            destino de una llamada Provincial ya existente.*/
            Centralita centralita;
            centralita = new Centralita("asdasdas");
            Provincial provincial1 = new Provincial("15212121",Provincial.Franja.Franja_1, 10F, "1551112927");
            Provincial provincial2 = new Provincial("15212121", Provincial.Franja.Franja_1, 10F, "1551112927");
            centralita += provincial1;
            try
            {
                centralita += provincial2;
                Assert.Fail();
            }
            catch(Exception e)
            {

                Assert.IsInstanceOfType(e, typeof(CentralitaExcepcion));
            }
        }
    }
}
