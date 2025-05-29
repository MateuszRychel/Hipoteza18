import string

class Anagram:
    def __init__(self, wyraz1, wyraz2):
        self.wyraz1 = wyraz1
        self.wyraz2 = wyraz2

    def alg_ver1(self):
        word1 = self.wyraz1.lower()
        word2 = self.wyraz2.lower()

        for char in string.punctuation:
            word1 = word1.replace(char, '')
            word2 = word2.replace(char, '')

        word1 = word1.replace(" ", "")
        word2 = word2.replace(" ", "")

        word1 = ''.join(sorted(word1))
        word2 = ''.join(sorted(word2))

        return word1 == word2


    def alg_ver2(self):
        word1 = self.wyraz1.lower()
        word2 = self.wyraz2.lower()

        for char in string.punctuation:
            word1 = word1.replace(char, '')
            word2 = word2.replace(char, '')

        word1 = word1.replace(" ", "")
        word2 = word2.replace(" ", "")

        dictionary_word1 = {}
        dictionary_word2 = {}

        for letter in word1.lower():
            dictionary_word1[letter] = word1.count(letter)

        for letter in word2.lower():
            dictionary_word2[letter] = word2.count(letter)

        return dictionary_word1 == dictionary_word2

test = Anagram("Caster Semenya","A secret man? Yes")

print(test.alg_ver1())

print(test.alg_ver2())