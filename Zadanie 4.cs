using System;

namespace Zadanie_4
{
    enum Plec
    {
        Kobieta,
        Mezczyzna
    }

    struct Student
    {
        public string Nazwisko;
        public int NumerAlbumu;
        public float Ocena;
        public Plec Pleć;
    }

    class Program
    {
        static void WypelnijStudenta(ref Student student, string nazwisko, int numerAlbumu, float ocena, Plec plec)
        {
            student.Nazwisko = nazwisko;
            student.NumerAlbumu = numerAlbumu;

            if (ocena < 2.0f)
                student.Ocena = 2.0f;
            else if (ocena > 5.0f)
                student.Ocena = 5.0f;
            else
                student.Ocena = ocena;

            student.Pleć = plec;
        }

        static float ObliczSrednia(Student[] grupa)
        {
            float sumaOcen = 0;
            foreach (var student in grupa)
            {
                sumaOcen += student.Ocena;
            }
            return sumaOcen / grupa.Length;
        }

        static void WyswietlStudenta(Student student)
        {
            Console.WriteLine($"Nazwisko: {student.Nazwisko}, Numer albumu: {student.NumerAlbumu}, Ocena: {student.Ocena}, Płeć: {student.Pleć}");
        }

        static void Main(string[] args)
        {
            Student[] grupa = new Student[5];

            WypelnijStudenta(ref grupa[0], "Kowalski", 12345, 4.5f, Plec.Mezczyzna);
            WypelnijStudenta(ref grupa[1], "Nowak", 23456, 3.8f, Plec.Kobieta);
            WypelnijStudenta(ref grupa[2], "Smith", 34567, 5.5f, Plec.Mezczyzna);
            WypelnijStudenta(ref grupa[3], "Johnson", 45678, 1.7f, Plec.Kobieta);
            WypelnijStudenta(ref grupa[4], "Garcia", 56789, 4.2f, Plec.Mezczyzna);

            Console.WriteLine("Studenci w grupie:");
            foreach (var student in grupa)
            {
                WyswietlStudenta(student);
            }

            float srednia = ObliczSrednia(grupa);
            Console.WriteLine($"Średnia ocen w grupie: {srednia}");
        }
    }
}
