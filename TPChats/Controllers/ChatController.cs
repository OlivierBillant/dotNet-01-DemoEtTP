namespace TPChats.Controllers;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TP.Models;

public class ChatController : Controller
{
    private static readonly List<ChatViewModel> chats = ChatViewModel.GetMeuteDeChats();

    // GET: ChatController
    public ActionResult Index()
    {
        return this.View(chats);
    }

    // GET: ChatController/Details/5
    public ActionResult Details(int id)
    {
        var chatFound = chats.FirstOrDefault(chat => chat.Id == id);
        return this.View(chatFound);
    }

    // GET: ChatController/Delete/5
    public ActionResult Delete(int id)
    {
        var chatFound = chats.FirstOrDefault(chat => chat.Id == id);
        return this.View(chatFound);
    }

    // POST: ChatController/Delete/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Delete(int id, IFormCollection collection)
    {
        try
        {
            var chatFound = chats.FirstOrDefault(chat => chat.Id == id);
            chats.Remove(chatFound);
            return this.RedirectToAction(nameof(Index));
        }
        catch
        {
            return this.View();
        }
    }
}
