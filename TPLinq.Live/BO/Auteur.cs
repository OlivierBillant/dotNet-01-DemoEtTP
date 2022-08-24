namespace TPLinq.Live.BO;

using System.Collections.Generic;

public record Auteur(string Nom, string Prenom)
{
    private readonly List<Facture> factures = new();

    public string Nom { get; set; } = Nom;

    public string Prenom { get; set; } = Prenom;

    public IReadOnlyList<Facture> Factures => this.factures;
    public void AddFacture(int montant)
        => this.factures.Add(new Facture(montant, this));
}
