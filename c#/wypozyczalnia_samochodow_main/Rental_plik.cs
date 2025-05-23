namespace Rental_plik;   // by zainicjowac w Program.cs

using Car_plik;          // odwolanie do pliku Car_plik.cs
using Customer_plik;    // odwolanie do pliku Customer_plik.cs

public class Rental
{
    public Customer Customer { get; }    // deklaracja Customer z jego danymi typu imie, nazwisko, mail
    public Car Car { get; }             // deklaracja Car z jego danymi typu marka, model, typ, cena
    public int Dni { get; }


    public Rental(Customer customer, Car car, int dni)
    {
        Customer = customer;
        Car = car;
        Dni = dni;
    }

    public double wyliczenie_kosztu()       // oblicza koszta za pomocą Dni z tego pliku * Cena z klasy Car
    {
        return Math.Round(Dni * Car.Cena, 2);
    }

    public void wyswietl_szczegoly_wypozyczenia()       // wyswietla info o wypozyczeniach
    {
        Console.WriteLine("Szczegóły Wypozyczenia");
        Customer.klient();
        Car.wyswietl_info();
        Console.WriteLine($"Liczba dni: {Dni}");
        Console.WriteLine($"Koszt całkowity: {wyliczenie_kosztu()} zł");
        Console.WriteLine("----");
    }
}f