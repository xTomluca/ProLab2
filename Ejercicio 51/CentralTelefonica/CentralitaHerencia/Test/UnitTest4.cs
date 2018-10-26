using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CentralitaHerencia;

namespace Test
{
    /// <summary>
    /// Descripción resumida de UnitTest4
    /// </summary>
    [TestClass]
    public class UnitTest4
    {
        [TestClass]
        public class UnitTest1
        {
            /*Dentro de un método de test unitario crear dos llamadas Local y dos Provincial, todos con
los mismos datos de origen y destino. Luego comparar cada uno de estos cuatro objetos
contra los demás, debiendo ser iguales solamente las instancias de Local y de Provincial
entre sí.*/
            [TestMethod]
            public void TestCentralita()
            {
                Local local = new Local("Cañuelas", 12f, "Avellaneda", 35.43f);
                Local local2 = new Local("Cañuelas", 12f, "Avellaneda", 35.43f);
                Provincial provincial = new Provincial("Lanus", Provincial.Franja.Franja_1, 15f, "Constitucion");
                Provincial provincial2 = new Provincial("Lanus", Provincial.Franja.Franja_1, 15f, "Constitucion");

                Assert.AreEqual(true, local == local2);
                Assert.AreEqual(false, local == provincial);
                Assert.AreEqual(false, local == provincial2);
                Assert.AreEqual(true, provincial == provincial2);
                Assert.AreEqual(false, provincial == local);
                Assert.AreEqual(false, provincial == local2);
            }
        }
    }
}

