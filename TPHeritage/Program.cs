
var formes = new List<Forme>
{
    new Cercle { Rayon = 3 },
    new Rectangle { Largeur = 3, Longueur = 4 },
    new Carre { Largeur = 3 },
    new Triangle { A = 4, B = 5, C = 6 }
};

foreach (var forme in formes)
{
    Console.WriteLine(forme);
}
Console.ReadKey();


var carre = new Carre { Largeur = 3 };
var doubleCarre = carre + carre;

Console.WriteLine(doubleCarre);

var rectangle = new Rectangle { Largeur = 3, Longueur = 3 };

Console.WriteLine(rectangle == carre);
