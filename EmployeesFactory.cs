using System;
using System.Collections.Generic;
using System.Text;

namespace Zaawansowane_programowanie_obiektowe_zadania_zaliczeniowe
{
    class EmployeesFactory
    {
        public static Employee stworzEmployee(string imie, string nazwisko, int index)
        {
            return new Employee(imie, nazwisko, index);
        }

        public static Employee stworzEmployee2(string imie, string nazwisko, int index)
        {
            return new Employee(imie, nazwisko, index);
        }
    }
}
