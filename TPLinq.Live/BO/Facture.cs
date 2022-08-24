namespace TPLinq.Live.BO;
public record Facture(decimal Montant, Auteur Auteur)
{
    public decimal Montant { get; set; } = Montant;

    public Auteur Auteur { get; set; } = Auteur;
}
