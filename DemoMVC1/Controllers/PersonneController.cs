namespace DemoMVC1.Controllers;

using DemoMVC1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

public class PersonneController : Controller
{
    private static List<PersonneViewModel> listePersonne = new List<PersonneViewModel>
        {
            new() { Id= 1, Nom = "Avonde", Prenom ="Romain", Age = 35},
            new() { Id= 2, Nom = "Doe", Prenom ="John", Age = 85}
        };


    // GET: PersonneController
    public ActionResult Index()
    {
        return this.View(listePersonne);
    }

    // GET: PersonneController/Details/5
    public ActionResult Details(int id)
    {
        var personFound = listePersonne.FirstOrDefault(p => p.Id == id);
        return this.View(personFound);
    }

    // GET: PersonneController/Create
    public ActionResult Create()
    {
        return this.View(new PersonneViewModel() { Id = 1, Nom = "Avonde", Prenom = "Romain", Age = 35 });
    }

    // POST: PersonneController/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Create(IFormCollection collection)
    {
        try
        {
            return this.RedirectToAction(nameof(Index));
        }
        catch
        {
            return this.View();
        }
    }

    // GET: PersonneController/Edit/5
    public ActionResult Edit(int id)
    {
        var personFound = listePersonne.FirstOrDefault(p => p.Id == id);
        return this.View(personFound);
    }

    // POST: PersonneController/Edit/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Edit(PersonneViewModel personne)
    {
        try
        {
            if (this.ModelState.IsValid)
            {
                if (listePersonne
                    .Any(p => p.Nom.ToUpper() == personne.Nom.ToUpper()
                    && p.Prenom.ToUpper() == personne.Prenom.ToUpper()))
                {
                    this.ModelState.AddModelError("", "Il existe déjà une personne portant ce nom et ce prénom");
                    return this.View();
                }


                var personneDb = listePersonne.FirstOrDefault(p => p.Id == personne.Id);
                personneDb.Nom = personne.Nom;
                personneDb.Prenom = personne.Prenom;
                personneDb.Age = personne.Age;
            }

            

            return this.RedirectToAction(nameof(Index));
        }
        catch
        {
            return this.View();
        }
    }

    // GET: PersonneController/Delete/5
    public ActionResult Delete(int id)
    {
        var personFound = listePersonne.FirstOrDefault(p => p.Id == id);
        return this.View(personFound);
    }

    // POST: PersonneController/Delete/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Delete(int id, IFormCollection collection)
    {
        try
        {
            return this.RedirectToAction(nameof(Index));
        }
        catch
        {
            return this.View();
        }
    }
}
