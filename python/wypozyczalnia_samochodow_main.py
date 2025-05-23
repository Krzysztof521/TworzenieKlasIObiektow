from Customer_plik import Customer # odwolanie 
from Car_plik import Car           # odwolanie
from Rental_plik import Rental     # odwolanie 

if __name__ == "__main__":
    car1 = Car("Skoda", "Rapid", "Hatchback", 500)    #car 1
    car2 = Car("Volkswagen", "Passat", "Sedan", 700)
    car3 = Car("Volkswagen", "Golf", "Hatchback", 1000)

    customer1 = Customer("Jan", "Kowalski", "jankowalski5@wp.pl")    #customer 1
    customer2 = Customer("Adrian", "Nowak", "adriannowak@gmail.com")
    customer3 = Customer("Kacper", "Kowalski", "kacperkowalski@interia.pl")

    rental1 = Rental(customer1, car1, 3)            # rental 1
    rental2 = Rental(customer2, car2, 4)
    rental3 = Rental(customer3, car3, 1)

    rental1.wyswietl_szczegoly_wypozyczenia()       
    rental2.wyswietl_szczegoly_wypozyczenia()
    rental3.wyswietl_szczegoly_wypozyczenia()
        

    
