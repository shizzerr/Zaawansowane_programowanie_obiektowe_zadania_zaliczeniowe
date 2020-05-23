using System;
using System.Security.Cryptography.X509Certificates;

namespace Zaawansowane_programowanie_obiektowe_zadania_zaliczeniowe
{  
    class Person
    {
        Delegaty d = new Delegaty();
        private string imie, nazwisko;
        public string Imie 
        {
            get => imie;
            set => imie = value; 
        }

        public string Nazwisko 
        {
            get => nazwisko;
            set => nazwisko = value;
        }

        public Person(string imie, string nazwisko)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
        }

        public void zmienImieNazwisko(string noweImie, string noweNazwisko)
        {
            imie = noweImie;
            nazwisko = noweNazwisko;
            Delegaty.Info text = new Delegaty.Info(d.zmianaDanych);
            text(Imie + " " + Nazwisko);
        }


        public override string ToString()
        {
            return string.Format("Imie i nazwisko: {0} {1}",imie,nazwisko);
        }
    }
}
