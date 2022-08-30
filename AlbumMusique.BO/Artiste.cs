namespace AlbumMusique.BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Artiste
{
    public int Id { get; set; }
    public string Nom { get; set; }
    public string Prenom { get; set; }

    public List<Album> Albums { get; set; }
}
