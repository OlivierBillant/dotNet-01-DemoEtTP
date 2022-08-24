namespace TPLinq.Live;

using System.Collections.Generic;
using System.Linq;
using TPLinq.Live.BO;

internal static class Datas
{
    public static (List<Auteur> auteurs, List<Livre> livres) InitialiserDatas()
    {
        var listeAuteurs = new List<Auteur>
        {
            new Auteur("GROUSSARD", "Thierry"),
            new Auteur("GABILLAUD", "Jérôme"),
            new Auteur("HUGON", "Jérôme"),
            new Auteur("ALESSANDRI", "Olivier"),
            new Auteur("de QUAJOUX", "Benoit")
        };

        var listeLivres = new List<Livre>
        {
            new Livre(1, "C# 4", "Les fondamentaux du langage", listeAuteurs[0], 533),
            new Livre(2, "VB.NET", "Les fondamentaux du langage", listeAuteurs[0], 539),
            new Livre(3, "SQL Server 2008", "SQL, Transact SQL", listeAuteurs[1], 311),
            new Livre(4, "ASP.NET 4.0 et C#", "Sous visual studio 2010", listeAuteurs[3], 544),
            new Livre(5, "C# 4", "Développez des applications windows avec visual studio 2010", listeAuteurs[2], 452),
            new Livre(6, "Java 7", "les fondamentaux du langage", listeAuteurs[0], 416),
            new Livre(7, "SQL et Algèbre relationnelle", "Notions de base", listeAuteurs[1], 216)
        };

        listeAuteurs[0].AddFacture(3500);
        listeAuteurs[0].AddFacture(3200);
        listeAuteurs[1].AddFacture(4000);
        listeAuteurs[2].AddFacture(4200);
        listeAuteurs[3].AddFacture(3700);

        return (listeAuteurs, listeLivres);
    }

    public static void Afficher<T>(this IEnumerable<T> source, string title)
    {
        Console.WriteLine(title);
        source
            .ToList()
            .ForEach(e =>
        {
            Console.Write("\t- ");
            Console.WriteLine(e);
        });
        Console.WriteLine();
    }

    public static void Afficher<T>(this T source, string title)
    {
        Console.WriteLine(title);
        Console.Write("\t- ");
        Console.WriteLine(source);
        Console.WriteLine();
    }
}
