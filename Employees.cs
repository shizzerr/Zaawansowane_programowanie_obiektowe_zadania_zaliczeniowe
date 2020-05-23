using System;
using System.Collections.Generic;
using System.Text;

namespace Zaawansowane_programowanie_obiektowe_zadania_zaliczeniowe
{
    class Employees
    {
        List<Employee> employeeList = new List<Employee>();

        public Employee employeeIndex(int index)
        {
            return employeeList[index];
        }

        public Employee employeeImieNazwisko(string imie, string nazwisko)
        {
            foreach(Employee employee in employeeList)
            {
                if((employee.Imie== imie)&&(employee.Nazwisko==nazwisko))
                        return employee;
            } return null;
        }

        public void dodajEmployee(Employee employee)
        {
            if (!employeeList.Contains(employee))
            {
                employeeList.Add(employee);
            }
        }

        public void usunEmployee(Employee employee)
        {
            if (!employeeList.Contains(employee))
            {
                employeeList.Remove(employee);
            }
        }
    }
}
