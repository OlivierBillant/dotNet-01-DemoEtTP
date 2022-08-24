internal class Triangle : Forme
{
    public int A { get; set; }
    public int B { get; set; }
    public int C { get; set; }

    private double P => (A + B + C) / 2d;

    public override double Aire => Math.Sqrt(P * (P - A) * (P - B) * (P - C));

    public override double Perimetre => A + B + C;
    public override string ToString()
    {
        return $"Triangle de coté A={A}, B={B}, C={C}" + Environment.NewLine + base.ToString();
    }
}