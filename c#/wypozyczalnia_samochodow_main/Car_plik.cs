namespace Car_plik; // by zainicjowac w Program.cs
public class Car
{
    public string Marka { get; }
    public string Model { get; }
    public string Typ { get; }
    public double Cena { get; }

    public Car(string marka, string model, string typ, double cena)   // car1, car2 czy odwolanie później do pliku Rental_plik.cs do wyliczeń
    {
        Marka = marka;
        Model = model;
        Typ = typ;
        Cena = cena;
    }

    public void wyswietl_info()         // wyswietla info o samochodzie
    {
        Console.WriteLine($"Samochód: {Marka}  {Model}  {Typ},  Cena za dzień: {Cena} zł");
    }

}f