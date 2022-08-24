using TPLinq.Live;
using TPLinq.Live.BO;

var (listeAuteurs, listeLivres) = Datas.InitialiserDatas();

/********************************* 1 ****************************************/
listeAuteurs
    .Where(a => a.Nom.StartsWith("g", StringComparison.CurrentCultureIgnoreCase))
    .Select(a => a.Prenom)
    .Afficher("1/ Afficher la liste des prénoms des auteurs dont le nom commence par \"G\" :");

/********************************* 2 ****************************************/

listeLivres
    .GroupBy(
        l => l.Auteur,
        (key, group) => new
        {
            Key = $"{key.Nom} {key.Prenom}",
            NombreLivres = group.Count()
        })
    .MaxBy(ano => ano.NombreLivres)
    .Afficher("2/ Afficher l’auteur ayant écrit le plus de livres");



dynamic TransformGroup(Auteur key, IEnumerable<Livre> livres)
{
    return new
    {
        Key = key,
        Count = livres.Count()
    };
}

var groupBy = listeLivres
    .GroupBy(l => l.Auteur, TransformGroup)
    .OrderByDescending(g => g.Count());

// Antoine
var auteurPlus = listeLivres.GroupBy(
    l => l.Auteur, 
    (key, group) => new
    {
        key = key,
        Count = group.Count()
    }).OrderByDescending(x => x.Count).FirstOrDefault()?.key;

/********************************* 3 ****************************************/
listeLivres
    .GroupBy(
        l => l.Auteur,
        (key, group) => new
        {
            Key = $"{key.Nom} {key.Prenom}",
            MoyenneDePages = group.Average(l => l.NbPages)
        })
    .Afficher("3/ Afficher le nombre moyen de pages par livre par auteur");


/********************************* 4 ****************************************/

// Maxime :  4/ Afficher le titre du livre avec le plus de pages
var livreMaxPages = listeLivres.OrderByDescending(o => o.NbPages).First();
Console.WriteLine("Livre ayant le plus de pages : " + livreMaxPages.Titre + "\n");

listeLivres
    .MaxBy(l => l.NbPages)
    .Afficher("4/ Afficher le titre du livre avec le plus de pages");

/********************************* 5 ****************************************/

listeAuteurs
    .SelectMany(a => a.Factures)
    .Average(f => f.Montant)
    .Afficher("5/ Afficher combien ont gagné les auteurs en moyenne (moyenne des factures)");


// Lucas 
var moyenneFacturesAuteurs = listeAuteurs
    .SelectMany(a => a.Factures.Select(f => f.Montant))
    .Average();
Console.WriteLine(moyenneFacturesAuteurs);

// Sylvain
var moyenneFacturesAuteurs2 = listeAuteurs
    .SelectMany(a => a.Factures)
    .Average(f =>f.Montant);
Console.WriteLine(moyenneFacturesAuteurs2);

/********************************* 6 ****************************************/
Console.WriteLine("6/ Afficher les auteurs et la liste de leurs livres");
foreach (var group in listeLivres.GroupBy(l => l.Auteur))
{
    Console.WriteLine($"Auteur : {group.Key.Nom} {group.Key.Prenom}");
    Console.WriteLine($"Livres :");
    foreach (var livre in group)
    {
        Console.Write("\t- ");
        Console.WriteLine(livre.Titre);
    }
}
Console.WriteLine();

/********************************* 7 ****************************************/
listeLivres
    .OrderBy(l => l.Titre)
    .Select(l => l.Titre)
    .Afficher("7/ Afficher les titres de tous les livres triés par ordre alphabétique");

// Olivier
var livresOrderedByAlphabet = listeLivres.OrderBy(livre => livre.Titre[0]);
foreach (var livre in livresOrderedByAlphabet)
{
    Console.WriteLine(livre);
}
Console.WriteLine();

// Christophe
var liste = listeLivres.Select(t => t.Titre).OrderBy(t => t);
foreach (var livre in liste)
{
    Console.WriteLine(livre);
}

/********************************* 8 ****************************************/
var moyenneDePages = listeLivres.Average(l => l.NbPages);
listeLivres
    .Where(l => moyenneDePages < l.NbPages)
    .Select(l => l.Titre)
    .Afficher("8/ Afficher la liste des livres dont le nombre de pages est supérieur à la moyenne");

/********************************* 9 ****************************************/
listeAuteurs
    .MinBy(a => listeLivres.Count(l => l.Auteur == a))
    .Afficher("9/ Afficher l'auteur ayant écrit le moins de livres");

Auteur auteurMin = null;
var tempCount = int.MaxValue;
foreach (var auteur in listeAuteurs)
{
    var nombreLivres = listeLivres.Count(l => l.Auteur == auteur);
    if (nombreLivres < tempCount)
    {
        tempCount = nombreLivres;
        auteurMin = auteur;
    }
}

Console.WriteLine(auteurMin);