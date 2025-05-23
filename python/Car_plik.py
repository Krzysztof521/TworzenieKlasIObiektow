class Car:
    def __init__(self, marka: str, model: str, typ: str, cena: float):
        self.marka = marka
        self.model = model
        self.typ = typ
        self.cena = cena

    def wyswietl_info(self):
        print(f"Samochód: {self.marka}  {self.model}  {self.typ},  Cena za dzień: {self.cena} zł")
f