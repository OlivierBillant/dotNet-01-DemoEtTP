using TPPizza.Business.Models;
using TPPizza.Web.Models;

var pizzas = new List<Pizza>
{
    new Pizza { Id = 1, Nom = "P1" },
    new Pizza { Id = 2, Nom = "P2" },
    new Pizza { Id = 3, Nom = "P3" },
    new Pizza { Id = 4, Nom = "P4" },
    new Pizza { Id = 5, Nom = "P5" },
    new Pizza { Id = 6, Nom = "P6" },
};

var pizzaA = new Pizza { Id = 7, Nom = "La Zavata" };

var pizzaVM = new PizzaViewModel { Id = pizzaA.Id, Nom = pizzaA.Nom };

var pizzaVM2 = PizzaViewModel.FromPizza(pizzaA);

var pizzasVM = new List<PizzaViewModel>();
foreach(var pizza in pizzas)
{
    pizzasVM.Add(new PizzaViewModel { Id = pizza.Id, Nom = pizza.Nom });
}

var pizzaVMV2 = pizzas.Select(p => new PizzaViewModel { Id = p.Id, Nom = p.Nom });

var pizzaVMV3 = pizzas.Select(PizzaViewModel.FromPizza);