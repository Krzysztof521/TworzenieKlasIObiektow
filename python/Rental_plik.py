from Car_plik import Car            #odwolanie
from Customer_plik import Customer  #odwolanie

class Rental:
    def __init__(self, customer: Customer, samochod: Car, dni: int):
        self.customer = customer
        self.samochod = samochod
        self.dni = dni

    def wyliczenie_kosztu(self):                # oblicza koszta za pomocą Dni z tego pliku * Cena z klasy Car
        return self.dni * self.samochod.cena    
    
    def wyswietl_szczegoly_wypozyczenia(self):
        print("Szczegóły Wypozyczenia")
        self.customer.klient()          #odnosi się do customer - Customer, a w nim do klient
        self.samochod.wyswietl_info()   #odnosi sie do samochod - Car, a w nim do wyswietl_info
        print(f"Liczba dni: {self.dni}")
        print(f"Koszt całkowity: {self.wyliczenie_kosztu():.2f} zł")
        print("----")
        