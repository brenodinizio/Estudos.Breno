namespace GeometriaAPI.Models
{
    public class Retangulo : GeometriaAPI , IGeometriaFormula
    {
        public double CalcularArea(string[] m)
        {
            double basev;
            double alturav;

            try
            {
                basev = double.Parse(m[0]);
                alturav =  double.Parse(m[1]);
            }
            catch(System.Exception ex)
            {
                return -1;

            }
         return basev*alturav;
             // return double.Parse(m[0]) * doube.Parse(m[1]);
           
        }

         public double CalcularPerimetro(string[]m)
        {
           double basev = double.Parse(m[0]);
           double alturav = double.Parse(m[1]);

           return (basev*2)+(alturav*2);

        }
    }
}