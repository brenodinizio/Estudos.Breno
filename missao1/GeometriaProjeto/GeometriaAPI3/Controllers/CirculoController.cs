using GeometriaAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace GeometriaAPI3.Controllers
{

     [ApiController]
    [Route("[controller]")]
    public class CirculoController : ControllerBase
    {
        [HttpGet]
        [Route("GetArea")]
           
           //editar!!
         public ActionResult<string>GetArea(double basev, double alturav)
        {
            Retangulo retangulo = new Retangulo();

            string[] valores = {basev.ToString(), alturav.ToString()};

            return retangulo.CalcularArea(valores).ToString();
        }
    }
}