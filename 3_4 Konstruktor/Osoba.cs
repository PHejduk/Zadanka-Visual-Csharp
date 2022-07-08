using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_4_Konstruktor
{
    internal class Osoba
    {
        string imie;
        string nazwisko;
        string miasto;
        string ulica;
        int wiek;

        public Osoba()
        {
            imie = "Default";
            nazwisko = "Default";
            miasto = "Default";
            ulica = "Default";
            wiek = 10;
            Console.WriteLine("Zadziałał konstruktor domyslny");
        }

        public Osoba(string imie, string nazwisko, string miasto, string ulica, int wiek)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.miasto = miasto;
            this.ulica = ulica;
            this.wiek = wiek;
            Console.WriteLine("Zadziałał konstruktor 5 parametrowy");
        }

        public Osoba(string imie, string nazwisko, string miasto)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.miasto = miasto;
            Console.WriteLine("Zadziałał konstruktor 3 parametrowy");
        }

        public Osoba(string imie, string nazwisko) : this(imie, nazwisko, "Katowice", "Mila 16", 18)
        {
            Console.WriteLine("Zadziałał konstruktor 2 parametrowy");
        }
    }
}
