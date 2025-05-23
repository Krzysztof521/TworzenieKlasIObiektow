class Customer:
    def __init__(self, imie: str, nazwisko: str, email: str):
        self.imie = imie
        self.nazwisko = nazwisko
        self.email = email

    def klient(self):
        print(f"Klient: {self.imie} {self.nazwisko}, {self.email}")
