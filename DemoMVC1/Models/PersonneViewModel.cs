namespace DemoMVC1.Models;

using System.ComponentModel.DataAnnotations;

public class PersonneViewModel
{
    public int Id { get; set; }

    [StringLength(10, MinimumLength = 2)]
    [Required]
    public string Nom { get; set; }

    [Required]
    public string Prenom { get; set; }

    [Range(18, 150)]
    public int Age { get; set; }
}
