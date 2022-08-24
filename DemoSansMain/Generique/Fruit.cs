using DemoSansMain.Generique.Abstractions;


namespace DemoSansMain.Generique
{
    internal class Fruit : INourriture
    {
        public DateTime DateCeuilette { get; set; }

        public bool EstPerime() 
            => (DateTime.Now - this.DateCeuilette).Days > 10;
    }
}
