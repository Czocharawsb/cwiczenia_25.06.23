namespace Zadanie_2
{
    internal class Program
    {
        struct Student
        {
            public string Imie;
            public string Nazwisko;
            public int NumerIndeksu;
            public string Kierunek;
        }

        struct Przedmiot
        {
            public string Nazwa;
            public string Kod;
            public int PunktyECTS;
            public string Prowadzacy;
        }

        struct NauczycielAkademicki
        {
            public string Imie;
            public string Nazwisko;
            public string StopienNaukowy;
            public string Katedra;
        }
        static void Main(string[] args)
        {   
            Console.WriteLine("");
        }
    }
}