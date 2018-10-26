using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CentralitaHerencia;

namespace Test
{
    /// <summary>
    /// Descripción resumida de UnitTest2
    /// </summary>
    [TestClass]
    public class UnitTest2
    {
       
        [TestMethod]
        public void TestMethod1()
        {
            Local local1 = new Local("1151112927", 1.5F, "1551112927", 16.5F);
            Local local2 = new Local("1151112927", 1.5F, "1551112927", 16.5F);
            Centralita centralita = new Centralita("asdasdasd");
            centralita += local1;
            try
            {
                centralita += local2;
                Assert.Fail();
            }
            catch(Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(CentralitaExcepcion));
            }
           
        }
    }
}
