// See https://aka.ms/new-console-template for more information
using DemoLoading;
using Microsoft.EntityFrameworkCore;

using var context = new LoadingContext();
await context.Database.EnsureCreatedAsync();

Initialisation();


var parent = context.Personnes.Include(p => p.Enfants).ThenInclude(e => e.Enfants).FirstOrDefault();
// context.Entry(parent).Collection(p => p.Enfants).Load();

Console.ReadLine();
static void Initialisation()
{
    using var context = new LoadingContext();

    var parent = new Personne { Nom = "Taplane", Prenom = "Adèle" };
    var enfant1 = new Personne { Nom = "Khan", Prenom = "Jerry" };
    var enfant2 = new Personne { Nom = "Aire", Prenom = "Axel" };
    var petitEnfant1 = new Personne { Nom = "Clette", Prenom = "Lara" };
    var petitEnfant2 = new Personne { Nom = "Joute", Prenom = "Sarah" };
    var petitEnfant3 = new Personne { Nom = "Atomie", Prenom = "Anne" };
    var petitEnfant4 = new Personne { Nom = "Ibou", Prenom = "oscar" };

    parent.Enfants.Add(enfant1);
    parent.Enfants.Add(enfant2);

    enfant1.Enfants.Add(petitEnfant1);
    enfant1.Enfants.Add(petitEnfant2);
    enfant2.Enfants.Add(petitEnfant3);
    enfant2.Enfants.Add(petitEnfant4);

    context.Personnes.Add(parent);
    context.SaveChanges();
}
