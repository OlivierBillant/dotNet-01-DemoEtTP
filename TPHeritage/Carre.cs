internal class Carre : Rectangle
{
    public override int Longueur => this.Largeur;

    public override string ToString()
    {
        return $"Carré de coté={Longueur}" + Environment.NewLine + base.ToString(true);
    }

    public static Carre operator +(Carre left, Carre right)
    {
        return new Carre { Largeur = left.Largeur + right.Largeur };
    }
}