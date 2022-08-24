namespace DemoSansMain;

internal class Personne
{
    private string prenom;
    private int age;

    public Personne()
    {
    }

    public Personne(string prenom)
    {
        this.prenom = prenom;
    }

    public string? Nom { get; set; }

    public int Age
    {
        get
        {
            return this.age;
        }
        set
        {
            this.age = value;
        }
    }
}
