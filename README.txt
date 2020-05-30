Ścieżka do pliku exe z bieżącego katalogu APO\APO\bin\Debug\APO.exe 

!!! W przypadku niedziałania czasami niektórych przycisków (głównie Apply w okienku PosterizeWindow) należy uruchomić aplikację od nowa, powinno pomóc !!!

LABORATORIUM nr 1 i 2

Funkcjonalności:

Główne:
Histogram - pasek MenuStrip: histogram rgb/gray
Negacja - Negation
Redukcja poziomów szarości - thresholding - gray levels 
Progowanie - thresholding
Rozciąganie histogramu - Stretch
Wyrównanie histogramu - equalization
Wyrównanie histogramu poprzez equalizatian - Selective Equalization
Posteryzacja - Posterize

Dodatkowe:
Klonowanie obrazu (duplikowanie) - Clone Window
Zapisywanie histogramu i obrazu - Save Histogram/Picture
Resetowanie zmian w grafice (przy pomocy button-ów Reset itp) - uwaga, działa do jednej zmiany
(do jednego nowego okienka wstecz)

LABORATORIUM 3 

Poprawione błędy z Lab 1 i 2:
-Pola wprowadzania wartości progowania zostały zabezpieczone przed wprowadzaniem np ciągu znaków

Główne:
-Operacje dwuargumentowe:
Przy ponownym wyborze zdjęć przy operacjach dwuargumentowych wykresy wariują, 
ponieważ przyjmują skalę pierwszego wyboru
tzn. jeśli np zdjęcie pierwsze ma wartości maks 2000 i wykres przyjmie skalę 3000 to w 
przypadku wyboru zdjęcia gdzie przyjmuje ono momentami wartosci np 10000, wykres nie zaktualizuje
się. Niestety nie wiem jak to zrobić, aby się aktualizował.
a)Add
b)Blend
c)AND
d)OR
e)XOR
f)NOT W przypadku operacji NOT nie wyświetla się wynik w oknie Result


Dodatkowe:
-Dodano okno "About program" zawierające informacje o autorze programu itp