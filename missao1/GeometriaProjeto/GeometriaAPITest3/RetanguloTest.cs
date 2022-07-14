using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeometriaAPI.Models;

namespace GeometriaAPITest
{
    [TestClass]
    public class RetanguloTest
    {
        Retangulo retangulo = new Retangulo();
        [TestMethod]
        public void RetanguloCalcularAreaTestAccept()
        {
           
           double esperado=20;
           string[] medidas ={"4", "5"};

           double resultado = retangulo.CalcularArea(medidas);

           Assert.AreEqual(esperado, resultado);
        }

         [TestMethod]
        public void RetanguloCalcularAreaTestcomTextoPrimeiraPos()
        {
           
           
           double esperado=-1;
           string[] medidas ={"m", "5"};

           double resultado = retangulo.CalcularArea(medidas);

           Assert.AreEqual(esperado, resultado);
        }
         [TestMethod]
         public void RetanguloCalcularAreaTestcomTextoSegundaPos()
        {
           
           
           double esperado=-1;
           string[] medidas ={"4", "m"};

           double resultado = retangulo.CalcularArea(medidas);

           Assert.AreEqual(esperado, resultado);
        }

        [TestMethod]
        public void RetanguloCalcularPerimetroCorreto()
        {
            //base 4, altura 5
            double esperado= 18;
            string[] medidas ={"4", "5"};
            double resultado = retangulo.CalcularPerimetro(medidas);

           Assert.AreEqual(esperado, resultado);
        }

         





    }
}
