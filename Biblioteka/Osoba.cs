using System.Runtime.CompilerServices;

namespace Biblioteka
{
    public class Osoba : object
    {
        public string? Nazwisko; // znak ? pozwala na wartość null
        public DateTime DataUrodzenia;
        public List<Osoba> Dzieci = new();
        public int CompareTo(Osoba? inna)
        {
            if(Nazwisko is null) return 0;
            return Nazwisko.CompareTo(inna.Nazwisko);
            throw new NotImplementedException();
        }

        public void WypiszWKonsoli()
        {
            Console.WriteLine($"{Nazwisko}, data urodzenia {DataUrodzenia:dddd}.");
        }
        public static Osoba Prokreacja(Osoba o1, Osoba o2)
        {
            Osoba dziecko = new()
            {
                Nazwisko = $"Dziecko osób {o1.Nazwisko} i {o2.Nazwisko}"
            };

            o1.Dzieci.Add(dziecko);
            o2.Dzieci.Add(dziecko);

            return dziecko;
        }
        public Osoba ProkreacjaZ(Osoba partner)
        {
            return Prokreacja(this, partner);
        }
        public static Osoba operator *(Osoba o1, Osoba o2)
        {
            return Osoba.Prokreacja(o1, o2);
        }
        public static int Silnia(int liczba)
        {
            if (liczba < 0)
            {
                throw new ArgumentException($"{nameof(liczba)} nie może być mniejsza od zera.");
            }
            return lokalnaSilnia(liczba);

            int lokalnaSilnia(int lokalnaLiczba)
            {
                if (lokalnaLiczba < 1) return 1;
                return lokalnaLiczba * lokalnaSilnia(lokalnaLiczba - 1);
            }
        }

        public event EventHandler Krzycz;
        public int PoziomZlosci;
        public void Szturchnij()
        {
            PoziomZlosci++;
            if (PoziomZlosci >= 3)
            {
                if (Krzycz != null)
                {
                    Krzycz(this, EventArgs.Empty);
                }
            }
        }
    }
}