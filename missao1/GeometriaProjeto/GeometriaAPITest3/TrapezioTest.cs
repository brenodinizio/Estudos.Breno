using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeometriaAPI.Models;

namespace GeometriaAPITest
{
    [TestClass]
    public class TrapezioTest
    {
        Trapezio trapezio = new Trapezio();
        [TestMethod]

        public void TrapezioCalcularAreaTestAccept()
        {
             double esperado=27;
           string[] medidas ={"4", "5", "6"};

           double resultado = trapezio.CalcularArea(medidas);

           Assert.AreEqual(esperado, resultado);

        }

         [TestMethod]
        public void RetanguloCalcularAreaTestcomTextoPrimeiraPos()
        {
           double esperado=-1;
           string[] medidas ={"m", "5" , "6"};

            double resultado = trapezio.CalcularArea(medidas);

           Assert.AreEqual(esperado, resultado);
        }

         [TestMethod]
         public void RetanguloCalcularAreaTestcomTextoSegundaPos()
        {
           
           
           double esperado=-1;
           string[] medidas ={"4", "m", "6"};

           double resultado = trapezio.CalcularArea(medidas);

           Assert.AreEqual(esperado, resultado);
        }

         [TestMethod]
         public void RetanguloCalcularAreaTestcomTextoTerceiraPos()
        {
           
           
           double esperado=-1;
           string[] medidas ={"4", "5", "m"};

            double resultado = trapezio.CalcularArea(medidas);

           Assert.AreEqual(esperado, resultado);
        }

    }
}