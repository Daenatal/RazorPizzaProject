using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzaProject.Models;

namespace RazorPizzaProject.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> fakePizzaDB = new List<PizzasModel>()
        {
            new PizzasModel()
            {
                ImageTitle="Margerita",
                PizzaName="Margerita",
                BasePrice=10,
                TomatoSauce=true,
                Cheese=true,
                FinalPrice=14
            },
            new PizzasModel()
            {
                ImageTitle="Carbonara",
                PizzaName="Carbonara",
                BasePrice=10,
                TomatoSauce=true,
                Cheese=true,
                FinalPrice=12
            },
            new PizzasModel()
            {
                ImageTitle="Bolognese",
                PizzaName="Bolognese",
                BasePrice=10,
                TomatoSauce=true,
                Cheese=true,
                Ham=true,
                FinalPrice=15
            },
            new PizzasModel()
            {
                ImageTitle="Hawaiian",
                PizzaName="Hawaiian",
                BasePrice=10,
                TomatoSauce=true,
                Cheese=true,
                Pineapple=true,
                Ham=true,
                FinalPrice=20
            },
            new PizzasModel()
            {
                ImageTitle="MeatFeast",
                PizzaName="MeatFeast",
                BasePrice=10,
                TomatoSauce=true,
                Cheese=true,
                Pepperoni=true,
                Beef=true,
                FinalPrice=18
            },
            new PizzasModel()
            {
                ImageTitle="Mushroom",
                PizzaName="Mushroom",
                BasePrice=10,
                TomatoSauce=true,
                Cheese=true,
                Mushroom=true,
                FinalPrice=20
            },
            new PizzasModel()
            {
                ImageTitle="Pepperoni",
                PizzaName="Pepperoni",
                BasePrice=10,
                TomatoSauce=true,
                Cheese=true,
                Pepperoni=true,
                FinalPrice=14
            },
            new PizzasModel()
            {
                ImageTitle="Seafood",
                PizzaName="Seafood",
                BasePrice=10,
                TomatoSauce=true,
                Cheese=true,
                Tuna=true,
                FinalPrice=16
            },
            new PizzasModel()
            {
                ImageTitle="Vegetarian",
                PizzaName="Vegetarian",
                BasePrice=10,
                TomatoSauce=true,
                Cheese=true,
                Pineapple=true,
                Mushroom=true,
                FinalPrice=15
            }
        };
        public void OnGet()
        {
        }
    }
}
