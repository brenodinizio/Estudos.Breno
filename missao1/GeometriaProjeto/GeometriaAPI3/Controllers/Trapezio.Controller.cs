using GeometriaAPI.Models;
using Microsoft.AspNetCore.Mvc;


namespace GeometriaAPI3.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class TrapezioController : ControllerBase
    {
        [HttpGet]
        [Route("GetArea")]

        public ActionResult<string>GetArea(double basev, double basemaior, double alturav)
        {
            Trapezio trapezio = new Trapezio();

            string[] valores = {basev.ToString(), basemaior.ToString(), alturav.ToString()};

            return trapezio.CalcularArea(valores).ToString();
        }

         [HttpGet]
        [Route("GetPerimetro")]
        public ActionResult<string>GetPerimetro(double basev, double basemaior, double lado1, double lado2)
        {
             Trapezio trapezio = new Trapezio();

            string[] valores = {basev.ToString(), basemaior.ToString(), lado1.ToString(), lado2.ToString()};

            return trapezio.CalcularPerimetro(valores).ToString();
        }

    }

}