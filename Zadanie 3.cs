using System.Diagnostics;

namespace Zadanie_3
{
    internal class Program
    {   enum Klasa_rz
        {
            Powszechny,
            Rzadki,
            Unikalny,
            Epicki
        }
        enum Typ_przedmiotu
        {
            Bron,
            Zbroja,
            Amulet,
            Pierscien,
            Helm,
            Tarcza,
            Buty
        }
        struct Przedmiot
        {
            public float waga;
            public int wartosc;
            public string nazwa;
            public Klasa_rz rzadkosc;
            public Typ_przedmiotu typ;
            
              
           
        }
        static void Main(string[] args)
        {
            
        }
   static void Wypelniacz(ref Przedmiot przedmiot,float Waga,int Wartosc,string Nazwa)
        {
            if (Waga>=0)
            {

            }



        }
    static Przedmiot Losuj_Przedmiot(Przedmiot[] Skrzynka)
        {
            Random random = new Random();

            Array.Sort(Skrzynka,Porownaj_Przedmioty);

        }
    

    }
    static  int Porownaj_Przedmioty(Przedmiot p1,Przedmiot p2)
    {
        if (p1.Rzadkosc < p2.Rzadkosc)
            return -1;
        else if (p1.Rzadkosc == p2.Rzadkosc)
            return 0;
        else
            return 1;

    }
}