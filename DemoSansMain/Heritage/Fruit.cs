using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSansMain.Heritage
{
    internal class Fruit : Aliment
    {
        public Fruit() : this("Tomate")
        {
            
        }

        public Fruit(string nom)
        {
            Nom = nom;
        }

        public string Nom { get; set; }

        public override void Conserver()
        {
            this.RangerDansLeFrigo();
        }

        private void RangerDansLeFrigo()
        {
            throw new NotImplementedException();
        }

        public void Composter()
        {
            this.Jeter();
            // this.Compost();
        }
    }
}
