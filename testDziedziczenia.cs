using System;
using System.Collections.Generic;
class Uczen{
    public string Imie{get;}
    public string Nazwisko{get;}

    public Uczen(string imie, string nazwisko){
        Imie = imie;
        Nazwisko = nazwisko;
    }
    public virtual string DaneUcznia()
    {
        return $"{Imie} {Nazwisko}";
    }
}
class Klasa : Uczen{
    public string NumerKlasy{get;}

    public Klasa(string imie, string nazwisko, string numerKlasy)
    :base(imie, nazwisko)
    {
        NumerKlasy = numerKlasy;
    }
    public override string DaneUcznia()
    {
        return $"{NumerKlasy} - {Imie} {Nazwisko}";
    }
}
class Program{
    static void Main(){
        var uczniowie = new List<Uczen>{
            new Klasa("Anna", "Kowalska", "3A"),
            new Klasa("Piotr", "Nowak", "2B"),
            new Klasa("Marta", "Wiśniewska", "3A")
        };
        foreach (var u in uczniowie){
            Console.WriteLine(u.DaneUcznia());
            }
    }
}