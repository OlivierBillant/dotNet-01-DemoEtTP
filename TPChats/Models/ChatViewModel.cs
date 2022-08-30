using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP.Models
{
    public class ChatViewModel
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public int Age { get; set; }
        public string Couleur { get; set; }

        public static List<ChatViewModel> GetMeuteDeChats()
        {
            var i = 1;
            return new List<ChatViewModel>
            {
                new ChatViewModel{Id=i++,Nom = "Felix",Age = 3,Couleur = "Roux"},
                new ChatViewModel{Id=i++,Nom = "Minette",Age = 1,Couleur = "Noire"},
                new ChatViewModel{Id=i++,Nom = "Miss",Age = 10,Couleur = "Blanche"},
                new ChatViewModel{Id=i++,Nom = "Garfield",Age = 6,Couleur = "Gris"},
                new ChatViewModel{Id=i++,Nom = "Chatran",Age = 4,Couleur = "Fauve"},
                new ChatViewModel{Id=i++,Nom = "Minou",Age = 2,Couleur = "Blanc"},
                new ChatViewModel{Id=i,Nom = "Bichette",Age = 12,Couleur = "Rousse"}
            };
        }
    }
}