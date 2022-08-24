namespace DemoMVC1.Controllers;

using DemoMVC1.Models;
using Microsoft.AspNetCore.Mvc;

public class DemoController : Controller
{
    public IActionResult Index()
    {
        var vm = new MessageViewModel { Message = "Hello !" };
        return this.View(vm);
    }
}
