internal class Rectangle : Forme
{
    public int Largeur { get; set; }

    public virtual int Longueur { get; set; }

    public override double Aire => Largeur * Longueur;

    public override double Perimetre => 2 * Largeur + 2 * Longueur;

    public override string ToString()
    {
        return this.ToString(false);
    }

    public string ToString(bool isCarre)
    {
        if (isCarre)
            return base.ToString();

        return $"Rectangle de longueur={Longueur} et largeur={Largeur}" + Environment.NewLine + base.ToString();
    }
}