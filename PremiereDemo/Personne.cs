using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremiereDemo
{
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

        public int Age {
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
}
