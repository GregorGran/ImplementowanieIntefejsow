using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    public class OsobaComparer : IComparer<Osoba>
    {
        public int Compare(Osoba x, Osoba y)
        {
            if (x == null || y == null) return 0;
            int wynik = x.Nazwisko.Length.CompareTo(y.Nazwisko.Length);
            if (wynik == 0)
            {
                return x.Nazwisko.CompareTo(y.Nazwisko);
            }
            else
            {
                return wynik;
            }
        }
    }
}
