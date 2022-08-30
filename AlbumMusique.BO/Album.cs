namespace AlbumMusique.BO;

using System.ComponentModel.DataAnnotations.Schema;

public class Album
{
    public int Id { get; set; }
    public string Titre { get; set; }
    public string Groupe { get; set; }

    [Column("AnneeSortie")]
    public int Annee { get; set; }

    [NotMapped]
    public int NombreDePistes => this.Pistes.Count;

    public List<Piste> Pistes { get; set; }

    public List<Artiste> Artistes { get; set; } = new List<Artiste>();
}
