using TPLinq;

var (listeAuteurs, listeLivres) = Datas.InitialiserDatas();

listeAuteurs
    .Where(a => a.Nom.StartsWith("g", StringComparison.CurrentCultureIgnoreCase))
    .Select(a => a.Prenom)
    .Afficher("1/ Afficher la liste des prénoms des auteurs dont le nom commence par \"G\" :");

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

listeAuteurs
    .MaxBy(a => listeLivres.Count(l => l.Auteur == a))
    .Afficher("2/ Afficher l'auteur ayant écrit le plus de livres");

listeLivres
    .GroupBy(
        l => l.Auteur,
        (key, group) => new
        {
            Key = $"{key.Nom} {key.Prenom}",
            MoyenneDePages = group.Average(l => l.NbPages)
        })
    .Afficher("3/ Afficher le nombre moyen de pages par livre par auteur");

listeLivres
    .MaxBy(l => l.NbPages)
    .Afficher("4/ Afficher le titre du livre avec le plus de pages");

listeAuteurs
    .SelectMany(a => a.Factures)
    .Average(f => f.Montant)
    .Afficher("5/ Afficher combien ont gagné les auteurs en moyenne (moyenne des factures)");



var g = listeAuteurs.GroupBy(a => a, (key , group) => new
{
    Key = key,
    MoyennesDesFactures = group.SelectMany(a => a.Factures).Average(f => f.Montant)
});

listeAuteurs.Select(a => new
{
    Auteur = $"{a.Nom} {a.Prenom}",
    MoyenneDesFactures = a.Factures.Any() ?  a.Factures.Average(f => f.Montant) : 0
}).Afficher("5/ Afficher combien ont gagné les auteurs en moyenne (moyenne des factures)");


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


listeLivres
    .OrderBy(l => l.Titre)
    .Select(l => l.Titre)
    .Afficher("7/ Afficher les titres de tous les livres triés par ordre alphabétique");

listeLivres
    .Where(l => listeLivres.Average(l => l.NbPages) < l.NbPages)
    .Select(l => l.Titre)
    .Afficher("8/ Afficher la liste des livres dont le nombre de pages est supérieur à la moyenne");

var moyenneDePages = listeLivres.Average(l => l.NbPages);
listeLivres
    .Where(l => moyenneDePages < l.NbPages)
    .Select(l => l.Titre)
    .Afficher("8/ Afficher la liste des livres dont le nombre de pages est supérieur à la moyenne");

listeAuteurs
    .MinBy(a => listeLivres.Count(l => l.Auteur == a))
    .Afficher("9/ Afficher l'auteur ayant écrit le moins de livres");