using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Zaawansowane_programowanie_obiektowe_zadania_zaliczeniowe
{
    class Operation
    {
        double wyplata, premia;
        int nadgodziny;
        DateTime data;

        public Operation(double wyplata, int nadgodziny, double premia, DateTime data)
        {
            this.wyplata = wyplata;
            this.nadgodziny = nadgodziny;
            this.premia = premia;
            this.data = data;
        }

        public double Wyplata 
        {
            get => wyplata;
            set => wyplata = value;
        }
        public double Premia 
        {
            get => premia;
            set => premia = value;
        }
        public DateTime Data
        {
            get => data;
            set => data = value;
        }
        public int Nadgodziny
        {
            get => nadgodziny;
            set => nadgodziny = value;
        }

        public override string ToString()
        {
            return string.Format(" Wypłata : {0}, ilość nadgodzin: {1}, premia: {2}, data: {3}", wyplata, nadgodziny, premia, data);
        }

    }
}
