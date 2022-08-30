namespace DemoLoading;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Personne
{
    public int Id { get; set; }
    public string Prenom { get; set; }
    public string Nom { get; set; }
    public List<Personne> Enfants { get; } = new List<Personne>();
}
