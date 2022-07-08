using System;

namespace _3_4_Konstruktor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Osoba osoba1 = new Osoba();
            Osoba osoba2 = new Osoba("Jan", "Kowal");
            Osoba osoba3 = new Osoba("Tomek", "Kowal", "Katowice");
            Osoba osoba4 = new Osoba("Adam", "Kowal", "Katowice", "Mila 15", 18);
        }
    }
}
