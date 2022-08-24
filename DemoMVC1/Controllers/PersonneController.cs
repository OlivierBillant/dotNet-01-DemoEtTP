namespace DemoMVC1.Controllers;

using DemoMVC1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

public class PersonneController : Controller
{
    // GET: PersonneController
    public ActionResult Index()
    {
        var listePersonne = new List<PersonneViewModel>
        {
            new() { Id= 1, Nom = "Avonde", Prenom ="Romain", Age = 35},
            new() { Id= 2, Nom = "Doe", Prenom ="John", Age = 85}
        };
        return View(listePersonne);
    }

    // GET: PersonneController/Details/5
    public ActionResult Details(int id)
    {
        return View();
    }

    // GET: PersonneController/Create
    public ActionResult Create()
    {
        return View();
    }

    // POST: PersonneController/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Create(IFormCollection collection)
    {
        try
        {
            return RedirectToAction(nameof(Index));
        }
        catch
        {
            return View();
        }
    }

    // GET: PersonneController/Edit/5
    public ActionResult Edit(int id)
    {
        return View();
    }

    // POST: PersonneController/Edit/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Edit(int id, IFormCollection collection)
    {
        try
        {
            return RedirectToAction(nameof(Index));
        }
        catch
        {
            return View();
        }
    }

    // GET: PersonneController/Delete/5
    public ActionResult Delete(int id)
    {
        return View();
    }

    // POST: PersonneController/Delete/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Delete(int id, IFormCollection collection)
    {
        try
        {
            return RedirectToAction(nameof(Index));
        }
        catch
        {
            return View();
        }
    }
}
