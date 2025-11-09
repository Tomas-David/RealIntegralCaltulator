# Kalkulačka plochy pomocí reálného integrálu

Tento program počítá plochu pod křivkou funkce **f(x) = xⁿ** na intervalu **⟨a; b⟩** pomocí:



1. **Dolního součtu (Lower Sum)**  
2. **Horního součtu (Upper Sum)**  
   Tyto přibližné metody počítají plochu pomocí obdélníků s daným krokem.

Program také určuje:
- nejnižší hodnotu funkce na intervalu,
- nejvyšší hodnotu funkce na intervalu,
- rozdíl mezi horním a dolním součtem (přesnost aproximace).

---

## **Vstupy uživatele**

Program si z konzole vyžádá tyto hodnoty:

| Název | Význam | Příklad | Poznámka |
|------|--------|---------|---------|
| **n** | exponent funkce \( f(x)=x^n \) | 2 | může být i záporný nebo desetinný |
| **a** | dolní mez integrálu | 1 | může být větší než b (počítá se korektně) |
| **b** | horní mez integrálu | 5 |  |
| **krok** | rozdělení intervalu pro součty | 0.1 | čím menší krok, tím přesnější součty |

Pozn.: U desetinných čísel používej **čárku**, ne tečku (např. `0,5`).

---

## **Výstup programu**

Po zadání vstupů program vypíše například:
Výpočet určitého integrálu f(x)=x^2

Interval: <1; 5>
Krok dělení (step): 0,1

PŘESNÁ PLOCHA F(b)-F(a): 41,3333333333333
Dolní součet: 40,95
Horní součet: 41,75
Rozdíl (horní - dolní): 0,8

Minimum f(x): 1
Maximum f(x): 25



---

## **Použití**

1. Spusť program (`F5` nebo `dotnet run`)
2. Zadej požadované hodnoty podle pokynů v konzoli.
3. Program vypíše výsledky.

---

## **Poznámky**

- Pokud je **n = -1**, používá se správná primitivní funkce \(\ln|x|\).
- Pokud **interval obsahuje 0**, nelze integrovat \(1/x\) → program vypíše chybu.
- Dolní a horní součet jsou **aproximace** — při zmenšení kroku se přesnost zvyšuje.

---

## Licence
Volné použití pro studijní účely.

