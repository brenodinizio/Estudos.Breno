namespace GeometriaAPI.Models
{
     public class Circulo : GeometriaAPI , IGeometriaFormula
    {
        public double CalcularArea(string[] m)
        {
             double raio;
             raio  = double.Parse(m[0]);
            
              double resultado =  (raio*raio) * 3.14;
              return resultado;
        }

         public double CalcularPerimetro(string[] m)
        {
            double raio;
             raio  = double.Parse(m[0]);

              double resultado = (2*3.14) * raio;
              return resultado;

        }
    }
}