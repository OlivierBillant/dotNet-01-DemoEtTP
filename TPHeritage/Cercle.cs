internal class Cercle : Forme
{
    public int Rayon { get; set; }

    public override double Aire => Math.PI * this.Rayon * this.Rayon;

    public override double Perimetre => 2 * Math.PI * this.Rayon;

    public override string ToString()
    {
        return $"Cercle de rayon {this.Rayon}" + Environment.NewLine + base.ToString();
    }
}