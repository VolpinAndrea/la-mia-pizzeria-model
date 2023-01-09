using la_mia_pizzeria.Utils;
using LaMiaPizzeriaModel.Models;
using Microsoft.AspNetCore.Mvc;

namespace LaMiaPizzeriaModel.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            List<Pizza> ListaPizze = PizzaData.GetPizze();
            return View("Index", ListaPizze);
        }
    }
}
