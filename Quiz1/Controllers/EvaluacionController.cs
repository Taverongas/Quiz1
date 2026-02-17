
using Microsoft.AspNetCore.Mvc;
using Quiz1.Models;

namespace Quiz1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EvaluacionController : Controller
    {
        private static List<Evaluacion> _evaluacion = new List<Evaluacion>
        {
            new Evaluacion{ Id = 1, asignatura="Matematicas", calificacion1=1.2, calificacion2=3.5, calificacion=(1.2+3.5)/2 },
            new Evaluacion{ Id = 2, asignatura="Fisica", calificacion1=4.5, calificacion2=4.2, calificacion=(4.5+4.2)/2 },//no se como ponerle la funcion para que se divida por el nombre de la variable
            new Evaluacion{ Id = 3, asignatura="Lengua", calificacion1=3.8, calificacion2=2.5, calificacion=(3.8+2.5)/2 },
        };
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_evaluacion);
        }
    }
}


