# Zaawansowane_programowanie_obiektowe_zadania_zaliczeniowe

1. Utwórz klasę Person z kilkoma polami, konstruktorem, metodą ToString. Utwórz klasę
Employee, dziedziczącą z Person. W klasie Employee dodaj jako pole listę obiektów
Operation. Klasa Operation przechowuje pojedyńczą operację finansową, dotyczącą
pracownika: wypłatę, nadgodziny, premię itd. Klasa Operation oprócz kwoty zawiera też datę
operacji.
W klasie Employee dodaj pole o nazwie Umowa (Contract). Pole powinno pozwolić wyłącznie
na wartości: FullTime, PartTime, Contract (wykorzystaj enum, zapoznaj się z tym jeśli nie
znasz)
2. Dodaj do klasy Employee metody umożliwiające przeglądanie jego operacji finansowych,
dodawanie nowej operacji, obliczanie sumy wszystkich operacji, pobieranie operacji z
podanego przedziału dat.
3. W klasie Employee utwórz indeksator dla listy operacji finansowych. Utwórz klasę
Employees, z polem jako listą pracowników, i dodaj w tej klasie indeksator zwracający
jednego pracownika na podstawie podanego indeksu. W tej samej klasie utwórz też drugi
indeksator, który zwraca pracownika na podstawie jego imienia i nazwiska.
4. Dodaj do klasy Employees metody pozwalające na dodawanie, usuwanie oraz pobieranie
obiektów klasy Employee. Dla dodawania i usuwania dodaj walidację, że dany obiekt istnieje.
Nie dodawaj już istniejących obiektów w liście. Utwórz klasę EmployeesFactory z dwoma
metodami statycznymi tworzącymi pracowników.
5. Dla klasy Employee przeciąż domyślne działanie operatorów < i > pozwalające na porównanie
dwóch pracowników, jako porównanie ich wynagrodzeń. Dodaj wcześniej w klasie Employee
pole przechowujące wynagrodzenie. Dla klasy Employee przeciąż domyślne działanie
operatora + jako pozwalające na dodanie do pracownika liczby. Jako wynik zwracana jest
suma pensji pracownika i podanej liczby.
6. Zdefiniuj w klasie Employee delegację pozwalającą podczepiać metody wywoływane, jeśli
zmieni się imię lub nazwisko pracownika. Napisz kod wywołujący delegację, jeśli nastąpi
zmiana imienia lub nazwiska. Innymi słowy w klasie Employee dodaj delegację np.:
class Employee {
public delegate Delegacja(string s); //to delegator
public Delegate zmiana; //to zmienna typu delegatora
//metoda, gdzie zmienia się imię i nazwisko, wywołuje delegację czyli: zmiana(„zmieniono
imie i nazwisko”)
}
Oczywiście to tylko fragment klasy Employee, opócz tego zawiera ona pola i metody z
wcześniejszych zajęć.
