internal abstract class Forme : IEquatable<Forme>
{
    public abstract double Aire { get; }
    public abstract double Perimetre { get; }

    public override bool Equals(object obj)
    {
        return this.Equals(obj as Forme);
    }

    public bool Equals(Forme? other)
    {
        return other != null &&
               this.Perimetre == other.Perimetre;
    }

    public override string ToString()
    {
        return $"Aire = {Aire}" + Environment.NewLine + $"Périmètre = {Perimetre}" + Environment.NewLine;
    }

    public static bool operator ==(Forme left, Forme right)
    {
        return EqualityComparer<Forme>.Default.Equals(left, right);
    }

    public static bool operator !=(Forme left, Forme right)
    {
        return !(left == right);
    }


}