using System;

namespace Zaawansowane_programowanie_obiektowe_zadania_zaliczeniowe
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee("Adrian","Adriański",1);
            employee1.DodajOperacje(new Operation(1500.20, 1, 60, new DateTime(2020, 05, 10)));
            employee1.DodajOperacje(new Operation(1300.23, 7, 1000, new DateTime(2020, 04, 11)));
            employee1.DodajOperacje(new Operation(399.99, 3, 500, new DateTime(2020, 05, 22)));
            Employee employee2 = new Employee("Daniel", "Piwosz", 2);
            employee2.DodajOperacje(new Operation(2890.70, 1, 460, new DateTime(2020, 02, 01)));
            employee2.DodajOperacje(new Operation(3024.32, 1, 460, new DateTime(2020, 03, 23)));
            employee2.DodajOperacje(new Operation(500, 2, 600, new DateTime(2020, 05, 14)));
            Console.WriteLine(" ---------------------------------------------------------------------------------------");
            Console.WriteLine(" Dodawanie Employee");
            Console.WriteLine(" ---------------------------------------------------------------------------------------");
            Console.WriteLine(" Dodano Employee1: {0} {1}", employee1.Imie, employee1.Nazwisko);
            Console.WriteLine(" Dodano Employee2: {0} {1}", employee2.Imie, employee2.Nazwisko);
            Console.WriteLine(" ");
            Console.WriteLine(" ---------------------------------------------------------------------------------------");
            Console.WriteLine(" Wypisanie wszystkich operacji");
            Console.WriteLine(" ---------------------------------------------------------------------------------------");
            Console.WriteLine(" >_ Suma operacji Employee1: " + (employee1.SumaOperacji()));
            Console.WriteLine(" >_ Suma operacji Employee2: " + (employee2.SumaOperacji()));
            Console.WriteLine(" ");
            Console.WriteLine(" ---------------------------------------------------------------------------------------");
            Console.WriteLine(" Suma operacji dla Employee1 od 2020,05,01 do 2020,05,30.");
            Console.WriteLine(" ---------------------------------------------------------------------------------------");
            employee1.OperacjeOdDo(new DateTime(2020, 05, 01), new DateTime(2020, 05, 30));
            Console.WriteLine("");
            Console.WriteLine(" ---------------------------------------------------------------------------------------");
            Console.WriteLine(" Suma operacji dla Employee1 od 2020,03,01 do 2020,05,30.");
            Console.WriteLine(" ---------------------------------------------------------------------------------------");
            employee2.OperacjeOdDo(new DateTime(2020, 03, 01), new DateTime(2020, 05, 30));
            Console.WriteLine(" ");
            Console.WriteLine(" ---------------------------------------------------------------------------------------");
            Console.WriteLine(" Sprawdzenie działania przeciążeń");
            Console.WriteLine(" ---------------------------------------------------------------------------------------");
            Console.WriteLine(" Employee1 < Employee2: " + (employee1 < employee2));
            Console.WriteLine(" Employee1 > Employee2: " + (employee1 > employee2));
            Console.WriteLine(" Employee1 + 9999: " + (employee1 + 9999));
            Console.WriteLine(" Employee1 < Employe2 po zmianie: " + (employee1 < employee2));
            Console.WriteLine(" ");
            Console.WriteLine(" ---------------------------------------------------------------------------------------");
            Console.WriteLine(" Zmiana imienia i nazwiska Employee1 wraz z delegatorem.");
            Console.WriteLine(" ---------------------------------------------------------------------------------------");
            employee1.zmienImieNazwisko("Waldemar", "Pawlak");
            Console.ReadKey(true);
        }
    }
}
