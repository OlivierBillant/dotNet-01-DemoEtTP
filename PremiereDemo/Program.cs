namespace PremiereDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var p = new Personne() { Age = 87 };

            var pPrime = new Personne();
            pPrime.Age = 87;

            Personne p1 = new("Romain");

            var i = p1.Nom.Length;
        }
    }
}