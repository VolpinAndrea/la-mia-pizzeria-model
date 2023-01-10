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
        public IActionResult Dettagli(int ID)
        {
            List<Pizza> listaPizze = PizzaData.GetPizze();

            foreach (Pizza pizza in listaPizze)
            {
                if (pizza.Id == ID)
                {
                    return View(pizza);
                }
            }
            return NotFound("La pizza ricercata non è presente nel menu");
        }
    }
}
