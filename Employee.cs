using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Zaawansowane_programowanie_obiektowe_zadania_zaliczeniowe
{
    class Delegaty
    {
        public delegate string Info(string text);
        public string zmianaDanych(string text)
        {
            text = " Zmieniono imię i nazwisko: " + text;
            Console.WriteLine(text);
            return text;
        }
    }
    
    class Employee : Person
    {
        List<Operation> listaOperacji = new List<Operation>();

        int index;
        double sumaDochodu, x;

        public Employee(string imie, string nazwisko, int index) : base(imie, nazwisko)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            this.index = index;
        }

        enum Contract
        {
            FullTime,
            PartTime,
            Contract,
        }

        public void PokazOperacje()
        {
            foreach (Operation i in listaOperacji)
            {
                Console.WriteLine(i.ToString());
            }
            return;
        }

        public void DodajOperacje(Operation operacja)
        {
            listaOperacji.Add(operacja);
            sumaDochodu += operacja.Wyplata + operacja.Premia;

        }
        public double SumaOperacji()
        {

            foreach (Operation operacja in listaOperacji)
            {
                x += operacja.Wyplata + operacja.Premia;
            }
            return x;
        }

        public void OperacjeOdDo(DateTime Od, DateTime Do)
        {
            foreach (Operation operacja in listaOperacji)
            {
                if ((operacja.Data >= Od) && (operacja.Data <= Do))
                    Console.WriteLine(operacja.ToString());
            }
        }

        public static Boolean operator <(Employee employee1, Employee employee2)
        {
            if (employee1.sumaDochodu < employee2.sumaDochodu)
                return true;
            else
                return false;
        }
        public static Boolean operator >(Employee employee1, Employee employee2)
        {
            if (employee1.sumaDochodu > employee2.sumaDochodu)
                return true;
            else
                return false;
        }

        public static double operator +(Employee employee, double number)
        {
            employee.sumaDochodu += number;
            return employee.sumaDochodu;
        }
    }
}