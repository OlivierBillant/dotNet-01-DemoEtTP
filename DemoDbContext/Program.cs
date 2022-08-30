using DemoDbContext;
using DemoDbContext.Entities;
using Microsoft.EntityFrameworkCore;

var context = new DemoContext();

foreach (var personne in context.Personnes)
{
    Console.WriteLine($"Nom:{personne.Nom}, Prenom:{personne.Prenom}");
}

if (!context.Personnes.Any())
{
    context.Personnes.Add(new Personne { Nom = "PACCIO", Prenom = "Oscar" });
    context.SaveChanges();
    Console.WriteLine("Une personne ajoutée");
}
Console.ReadKey();

/*
async Task<int> GetNombresPersonnes()
{
    return await context.Personnes.CountAsync();
}*/