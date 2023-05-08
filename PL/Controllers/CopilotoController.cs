using Microsoft.AspNetCore.Mvc;

namespace PL.Controllers
{
    public class CopilotoController : Controller
    {
        public ActionResult Mapa()
        {
            ML.Result result = BL.Punto.GetAll();
            ML.Punto punto = new ML.Punto();
            if (result.Correct)
            {
                punto.Puntos = result.Objects;
                return View(punto);
            }
            else
            {
                return View(punto);
            }
        }
    }
}
