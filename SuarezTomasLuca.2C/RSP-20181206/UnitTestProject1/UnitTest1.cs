using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using Excepciones;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// ESPERA EXCEPCION DEL TIPO CLAVE INVALIDA
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ClaveInvalidaException))]
        public void TestMethod1()
        {             
            Usuario usuario = new Usuario("Josesito", "123456");
        }
        /// <summary>
        /// Espera que la agencia este instanciada
        /// </summary>
        [TestMethod]
        public void TestMethod2()
        {
            PasajeAvion pasajeAvion = new PasajeAvion();
            Assert.IsNotNull(pasajeAvion);
        }
    }
}
