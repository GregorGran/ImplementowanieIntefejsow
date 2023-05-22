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
