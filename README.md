# 🧩 Anagram Checker – Python + .NET MAUI

Projekt łączy dwa podejścia do tego samego problemu:
1. Implementacja klasy `Anagram` w Pythonie.
2. Aplikacja mobilna stworzona w .NET MAUI, umożliwiająca sprawdzanie anagramów na urządzeniu mobilnym lub komputerze.

---

## 📘 Część I – Python: Klasa `Anagram`

Anagram to ciąg znaków, który można utworzyć przez przestawienie liter innego ciągu znaków. Na przykład słowa **"listen"** i **"silent"** są anagramami.

### 🎯 Cel
Stworzenie klasy `Anagram` z metodą statyczną porównującą dwa napisy i sprawdzającą, czy są anagramami, ignorując:
- wielkość liter
- spacje
- interpunkcję (.,!?)

### ✅ Przykłady użycia:

```python
test = Anagram("Tom Marvolo Riddle", "I am Lord Voldemort")  # True
test = Anagram("Julian Tuwim", "Lutni, ujaw mi!")            # True
test = Anagram("Gregory House", "Huge ego, sorry")           # True
test = Anagram("Caster Semenya", "A secret man? Yes")        # True
```


## 📱 Część II – Aplikacja mobilna (MAUI)

Aplikacja mobilna stworzona z użyciem frameworka .NET MAUI umożliwia użytkownikowi sprawdzenie, czy dwie wprowadzone frazy są anagramami.

### ✨ Funkcje aplikacji:

- Dwa pola tekstowe do wpisania fraz.
- Przycisk "Sprawdź".
- Komunikat z informacją, czy frazy są anagramami.
