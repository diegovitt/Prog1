using Microsoft.VisualStudio.TestTools.UnitTesting;
using EjercicioExcepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioExcepciones.Tests
{
    [TestClass()]
    public class DivisionTests
    {
        [TestMethod()]
        public void DividirTest()
        {
            // arrange
            int numerador = 2500;
            int denominador = 1250;
            int expected = 2;

            var divisionn = new Division(2500);

            // act
            divisionn.Dividir();
            int actual = divisionn.Denominador;

            // assert

            Assert.AreEqual(expected,actual);
            

        }
    }
}