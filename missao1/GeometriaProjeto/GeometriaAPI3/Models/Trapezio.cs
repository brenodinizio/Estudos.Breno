namespace GeometriaAPI.Models
{
     public class Trapezio : GeometriaAPI , IGeometriaFormula
    {
        public double CalcularArea(string[] m)
        {
            double basev;
            double basemaior;
            double alturav;
             try
             {
                basev = double.Parse(m[0]);
               basemaior = double.Parse(m[1]);
               alturav =  double.Parse(m[2]);

             }
             catch(System.Exception ex)
             {
                return -1;
             }
               
             
              double resultado =  ((basev+basemaior)*alturav)/2;
              return resultado;
        }

         public double CalcularPerimetro(string[] m)
        {
            double basev;
            double basemaior;
            double lado1;
            double lado2;

               basev = double.Parse(m[0]);
               basemaior = double.Parse(m[1]);
               lado1 =  double.Parse(m[2]);
               lado2 =  double.Parse(m[3]);

              double resultado = basev + basemaior + lado1 + lado2;
              return resultado;

        }
    }
}