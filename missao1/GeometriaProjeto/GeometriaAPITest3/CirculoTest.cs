using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeometriaAPI.Models;

namespace GeometriaAPITest
{
    [TestClass]
    public class CirculoTest
    {
       Circulo circulo = new Circulo();
        [TestMethod]
        public void CirculoCalcularAreaTestAccept()
        {
           double esperado=50.24;
           string[] medidas ={"4"};

           double resultado = circulo.CalcularArea(medidas);

           Assert.AreEqual(esperado, resultado);
        }




    }
}