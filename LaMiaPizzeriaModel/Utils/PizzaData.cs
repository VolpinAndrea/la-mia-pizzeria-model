using LaMiaPizzeriaModel.Models;

namespace la_mia_pizzeria.Utils
{
    public static class PizzaData
    {
        static private List<Pizza> ListaPizze = new List<Pizza>()
        {
            new Pizza(0, "Margherita", "pomodoro, mozzarella, basilico", "..\\img\\marghe.jfif", 6),
            new Pizza(0, "Marinara", "pomodoro, origano", "..\\img\\mari.jfif", 5),
            new Pizza(0, "Funghi", "pomodoro, mozzarella, funghi", "..\\img\\fung.jfif", 7),
            new Pizza(0, "Crudo", "pomodoro, mozzarella, crudo", "..\\img\\crudo.jfif", 8),
            new Pizza(0, "Crudo e bufala", "pomodoro, mozzarella, crudo, bufala", "..\\img\\crbf.jfif", 6)


        };

        public static List<Pizza> GetPizze()
        {
            return ListaPizze;
        }

    }
}
