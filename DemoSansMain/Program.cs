using DemoSansMain.Extensions;
using DemoSansMain.Generique;

/*  Generics 
Fourmi fourmi1 = new();
var fruit = new Fruit { DateCeuilette = DateTime.Now.AddDays(-5) };

Zoo.Nourrir(fourmi1, fruit);


Chat chat = new Chat();
Pate pate = new() { DatePeremption = DateTime.Now.AddYears(1) };

Zoo.Nourrir(chat, pate);

*/

var list = new List<int>(100);

HashSet<int> visited = new HashSet<int>();

Dictionary<string, int> keyValuePairs = new Dictionary<string, int>();

Console.WriteLine(list.Count);
Console.WriteLine(list.Capacity);

list.Add(1);
list.Remove(1);
list.Add(2);
list.AddRange(list);

Console.WriteLine(list.Count);

foreach (var n in list)
{
    Console.WriteLine(n);
}

22.Aout(2022);

TestExtensions.Aout(22, 2022);


Func<DateTime, int> jourAvantNoel = date =>
{
    var noel = new DateTime(date.Year, 12, 25);
    return (noel - date).Days;
};

jourAvantNoel(DateTime.Now);