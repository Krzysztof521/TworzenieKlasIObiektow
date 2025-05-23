namespace Customer_plik; // by zainicjowac w Program.cs

public class Customer
{
    public string Imie { get; }
    public string Nazwisko { get; }
    public string Email { get; }

    public Customer(string imie, string nazwisko, string email)     // customer1, customer2 czy odwolanie później do pliku Rental_plik.cs do wyliczeń
    {
        Imie = imie;
        Nazwisko = nazwisko;
        Email = email;
    }

    public void klient()    // wyswietla info o kliencie
    {
        Console.WriteLine($"Klient: {Imie} {Nazwisko}, {Email}");
    }
}