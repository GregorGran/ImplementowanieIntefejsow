using Biblioteka;
using static System.Console;


var henryk = new Osoba { Nazwisko = "Henryk" };
var maria = new Osoba { Nazwisko = "Maria" };
var julia = new Osoba { Nazwisko = "Julia" };

var dziecko1 = maria.ProkreacjaZ(henryk);
dziecko1.Nazwisko = "Grzegorz";

var dziecko2 = Osoba.Prokreacja(henryk,julia);

WriteLine($"{maria.Nazwisko} ma {maria.Dzieci.Count} dzieci.");
WriteLine($"{henryk.Nazwisko} ma {henryk.Dzieci.Count} dzieci.");
WriteLine($"{julia.Nazwisko} ma {julia.Dzieci.Count} dzieci.");
WriteLine(format: $"pierwsze dziecko {maria.Nazwisko} nazywa sie \"{maria.Dzieci[0].Nazwisko}\".");

var dziecko3 = henryk * maria;

WriteLine($"5! to {Osoba.Silnia(5)}");

static void Henryk_Krzyk(object? sender, EventArgs e)
{
    if (sender is null) return;
    Osoba o = (Osoba)sender;
    WriteLine($"{o.Nazwisko} złości sie na poziomie: {o.PoziomZlosci}.");
}
henryk.Krzycz += Henryk_Krzyk;
henryk.Szturchnij();
henryk.Szturchnij();
henryk.Szturchnij();
henryk.Szturchnij();

System.Collections.Hashtable wyszukiwanieObiektow = new();
wyszukiwanieObiektow.Add(key: 1, value: "Alpha");
wyszukiwanieObiektow.Add(key: 2, value: "Beta");
wyszukiwanieObiektow.Add(key: 3, value: "Gamma");
wyszukiwanieObiektow.Add(key: henryk, value: "Delta");

int klucz = 2;
WriteLine(format: $"klucz {klucz} ma wartość {wyszukiwanieObiektow[klucz]}");

WriteLine(format: $"klucz {henryk} ma wartość {wyszukiwanieObiektow[henryk]}");

Osoba[] osoby = { new Osoba { Nazwisko = "Kleoptra" }, new Osoba { Nazwisko = "Ramzes" }, new Osoba { Nazwisko = "Apofis" } };
WriteLine("Początkowa lista osób:");
foreach (var osoba in osoby)
{
    WriteLine($"{osoba.Nazwisko}");
}
WriteLine("Do posortowania użyto zaimplementowanego interfejsu IComparable:");
//Array.Sort(osoby);
foreach (var osoba in osoby)
{
    WriteLine($"{osoba.Nazwisko}");
}

WriteLine("Do posortowania użyto implementacji interfejsu IComparer w klasie OsobaComparer:");
Array.Sort(osoby, new OsobaComparer());
foreach (var osoba in osoby)
{
    WriteLine($"{osoba.Nazwisko}");
}