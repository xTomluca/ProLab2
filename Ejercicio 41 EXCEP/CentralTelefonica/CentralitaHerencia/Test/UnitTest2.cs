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
       public bool llamadasIguales(Llamada llamada, Centralita centralita)
        {
            bool retorno = false;
            foreach(Llamada aux in centralita.Llamadas)
            {
                if(aux is Local && aux.NroDistinto == llamada.NroDistinto && aux.NroOrigen == llamada.NroOrigen)
                {
                    retorno =  true;
                    throw new CentralitaExcepcion("ERROR LA LLAMADA YA EXISTE", "LOCAL", "AGREGAR LLAMADA TEST");
                }
            }
            return retorno;
        }

        [TestMethod]
        public void TestMethod1()
        {
            Local local1 = new Local("1151112927", 1.5F, "1551112927", 15.5F);
            Local local2 = new Local("1151112927", 1.5F, "1551112927", 15.5F);
            Centralita centralita = new Centralita("asdasdasd");
            centralita += local1;
            centralita += local2;
            Assert.ThrowsException()
        }
    }
}
