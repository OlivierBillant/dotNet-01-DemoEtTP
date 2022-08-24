using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSansMain.Extensions
{
    internal static class TestExtensions
    {
        public static DateTime Aout(this int day, int annee)
        {
            return new DateTime(annee, 8, day);
        }
    }
}
