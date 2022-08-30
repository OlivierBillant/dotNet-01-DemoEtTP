namespace TPPizza.Business;

using System;
using System.Collections.Generic;
using TPPizza.Business.Models;

public class PizzaService
{
    private static readonly List<Ingredient> ingredients = Pizza.IngredientsDisponibles;
    private static readonly List<Pate> pates = Pizza.PatesDisponibles; 
    private static readonly List<Pizza> pizzas = new();

    public List<Pizza> GetPizzas()
    {
        return pizzas;
    }

    public void AddPizza(Pizza pizza, int? pateId, List<int> ingredientsIds)
    {
        if (pizza.Id == 0 && pizzas.Any())
        {
            pizza.Id = pizzas.Max(p => p.Id) + 1;
        }
        else
        {
            pizza.Id = 1;
        }

        pizza.Pate = pates.First(p => p.Id == pateId);
        pizza.Ingredients = ingredientsIds.Select(id => ingredients.FirstOrDefault(i => i.Id == id)).ToList();

        pizzas.Add(pizza);
    }

    public void UpdatePizza(Pizza pizza, int? pateId, List<int> ingredientsIds)
    {
        var pizzaToEdit = pizzas.FirstOrDefault(p => p.Id == pizza.Id);

        var pate = pates.First(p => p.Id == pateId);

        var ingredientsSelectionnes 
            = ingredientsIds.Select(id => ingredients.FirstOrDefault(i => i.Id == id)).ToList();

        if (pizzaToEdit is not null)
        {
            pizzaToEdit.Nom = pizza.Nom;
            pizzaToEdit.Pate = pate;
            pizzaToEdit.Ingredients = ingredientsSelectionnes;
        }        
    }

    public Pizza? GetPizzaById(int id)
    {
        return pizzas.FirstOrDefault(p => p.Id == id);
    }

    public void RemovePizza(int id)
    {
        var pizzaToRemove = this.GetPizzaById(id);
        pizzas.Remove(pizzaToRemove);
    }

    public List<Pate> GetPates() 
        => pates;

    public List<Ingredient> GetIngredients() 
        => ingredients;

    public bool PizzaExists(string nom)
    {
        return pizzas.Any(p => string.Equals(p.Nom, nom, StringComparison.CurrentCultureIgnoreCase));
    }

    public bool PizzaSameIngredientsExists(List<int> ingredientsIds)
    {
        return pizzas.Any(p =>
            p.Ingredients.Select(i => i.Id).OrderBy(i => i)
            .SequenceEqual(ingredientsIds.OrderBy(i => i))
            );
    }
}
