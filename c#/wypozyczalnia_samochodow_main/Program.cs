using System;

using Customer_plik; // odwolanie do pliku Customer_plik.cs
using Car_plik;      // odwolanie do pliku Car_plik.cs
using Rental_plik;   // odwolanie do pliku Rental_plik.cs


class Program
{
    static void Main()
    {
        var car1 = new Car("Skoda", "Rapid", "Hatchback", 500.1); // samochod 1
        var car2 = new Car("Volkswagen", "Passat", "Sedan", 700);
        var car3 = new Car("Volkswagen", "Golf", "Hatchback", 1000);


        var customer1 = new Customer("Jan", "Kowalski", "jankowalski5@wp.pl");  // klient/customer 1
        var customer2 = new Customer("Adrian", "Nowak", "adriannowak@gmail.com");
        var customer3 = new Customer("Kacper", "Kowalski", "kacperkowalski@interia.pl");

        var rental1 = new Rental(customer1, car1, 3);   // rental 1
        var rental2 = new Rental(customer2, car2, 4);
        var rental3 = new Rental(customer3, car3, 1);

        rental1.wyswietl_szczegoly_wypozyczenia();
        rental2.wyswietl_szczegoly_wypozyczenia();  
        rental3.wyswietl_szczegoly_wypozyczenia(); 
f

    }
}