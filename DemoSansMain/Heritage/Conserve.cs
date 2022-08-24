using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSansMain.Heritage
{
    internal class Conserve : Aliment
    {
        public override void Conserver()
        {
            this.RangerDansLePlacard();
        }

        private void RangerDansLePlacard()
        {
            throw new NotImplementedException();
        }
    }
}
