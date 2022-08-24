namespace TPLinq.BO;

public record Livre(int Id, string Titre, string Synopsis, Auteur Auteur, int NbPages)
{
    public int Id { get; set; } = Id;

    public string Titre { get; set; } = Titre;

    public string Synopsis { get; set; } = Synopsis;

    public Auteur Auteur { get; set; } = Auteur;

    public int NbPages { get; set; } = NbPages;
}
