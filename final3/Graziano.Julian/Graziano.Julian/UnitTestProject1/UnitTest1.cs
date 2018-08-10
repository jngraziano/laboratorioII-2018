using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Prueba con el tema de los repetidos
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestDNIValidos()
        {
            // arrange
            Alumno a = new Alumno("Pepe","Perez","12A");
           
           
        }
    }
}
