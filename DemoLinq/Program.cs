var nombres = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

var personnes = new List<Personne>
{
    new Personne(32, "Marc"),
    new Personne(33,"Jean"),
    new Personne(28,"Mélanie"),
    new Personne(32,"Simon"),
    new Personne(33,"Hélène"),
    new Personne(17, "Francis")
};

var listeDeRues = new List<Rue>
{
    new Rue("Rue des Lilas", 1),
    new Rue("Rue des Monts", 3),
    new Rue("Rue des Monts", 24),
    new Rue("Rue des Lilas", 50),
    new Rue("Rue des Lilas", 110),
    new Rue("Rue des Asperges", 5),
    new Rue("Rue des Xylophones", 48)
};


var firstPerson = personnes.FirstOrDefault();

var vieux = personnes.Where(p => p.Age > 30);

if (true)
{
    vieux = vieux.Where(p => p.Prenom[0] == 'C');
}

foreach (var p in vieux)
{
    Console.WriteLine(p);
}

var listeRueOrdonnees = listeDeRues.OrderBy(r => r.Numero);
var listeRueOrdonneesNom = listeDeRues.OrderByDescending(r => r.Nom).ThenBy(r => r.Numero);


var allPersonnesMajeures = personnes.All(p => p.Age >= 18);
var auMoinsUnePersonneMajeure = personnes.Any(p => p.Age >= 18);

var firstMajeure = personnes.FirstOrDefault(firstPerson => firstPerson.Age >= 18);
// Equivalent : var firstMajeure = personnes.Where(firstPerson => firstPerson.Age >= 18).FirstOrDefault();

var nombrePersonnesMajeures = personnes.Count(p => p.Age >= 18);


var listeAge = personnes.Select(p => p.Age);
var listeNomDeRue = listeDeRues.Select(p => p.Nom);

var listeIdentifiants = personnes.Select(p => $"{p.Prenom[0]}{p.Age}");

var listeInitiales = personnes.Select(p => new
{
    Age = p.Age,
    Initiale = p.Prenom[0..1]
});

(int X, int Y) = (5, 5);

var listeInitialesTuples = personnes.Select(p => (p.Age, p.Prenom[0..1]));

var appartements = new List<Appartement>
            {
                new Appartement
                {
                    Numero = 1,
                    Pieces = new List<Piece>
                    {
                        new Piece{ TypePiece = "Cuisine",Surface = 5},
                        new Piece{ TypePiece = "Salon",Surface = 15},
                        new Piece{ TypePiece = "Chambre",Surface = 10}
                    }
                },
                new Appartement
                {
                    Numero = 2,

                    Pieces = new List<Piece>
                    {
                        new Piece{ TypePiece = "Cuisine",Surface = 4},
                        new Piece{ TypePiece = "Salon",Surface = 21},
                        new Piece{ TypePiece = "Chambre",Surface = 9}
                    }
                },
                new Appartement
                {
                    Numero = 3,
                    Pieces = new List<Piece>
                    {
                        new Piece{ TypePiece = "Cuisine",Surface = 6},
                        new Piece{ TypePiece = "Salon",Surface = 19},
                        new Piece{ TypePiece = "Chambre",Surface = 8}
                    }
                },
                new Appartement
                {
                    Numero = 4,
                    Pieces = new List<Piece>
                    {
                        new Piece{ TypePiece = "Cuisine",Surface = 8},
                        new Piece{ TypePiece = "Salon",Surface = 30},
                        new Piece{ TypePiece = "Chambre",Surface = 12}
                    }
                }
            };

var listePieces = appartements.SelectMany(a => a.Pieces);

var piecesParType = listePieces.GroupBy(p => p.TypePiece);

// Parcours de chaque groupe
foreach (var pt in piecesParType)
{
    Console.WriteLine(pt.Key); // Affichage de la clé
    foreach (var piece in pt) // Parcours d'un groupe
    {
        Console.WriteLine(piece);
    }
}


var nombreDepiecesParType = listePieces.GroupBy(p => p.TypePiece, (key, group) => new
{
    Key = key,
    Count = group.Count()
});


public class Appartement
{
    public int Numero { get; set; }

    public List<Piece> Pieces { get; set; }
}

public class Piece
{
    public string TypePiece { get; set; }

    public int Surface { get; set; }

    public override string ToString()
    {
        return $"{TypePiece}, Surface: {Surface}m²";
    }
}

public record Personne(int Age, string Prenom);
public record Rue(string Nom, int Numero);
