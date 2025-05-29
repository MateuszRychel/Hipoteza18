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
Anagram.check("Tom Marvolo Riddle", "I am Lord Voldemort")  # True
Anagram.check("Julian Tuwim", "Lutni, ujaw mi!")            # True
Anagram.check("Gregory House", "Huge ego, sorry")           # True
Anagram.check("Caster Semenya", "A secret man? Yes")        # True
