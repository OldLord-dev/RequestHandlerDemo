# Zadanie rekrutacyjne

## Wstęp

Zawartość służy jako test rekrutacyjny dla studentów do projektu informatycznego na stanowisko "programista .net".

Wymagane umiejętności by ukończyć zadanie:

1. znajomość języka programowania C#
2. pozytywne nastawienie

Dystrybucja:

* wszystkie zadania należy umieścić w publicznym repo kandydata i przesłać link w odpowiedzi na maila rekrutacyjnego

Informacje dodatkowe:

* nie trzeba przynosić komputera na rozmowę rekrutacyjną (jeśli odbędzie się w biurze ze względu na wyjątkową sytuację w kraju)
* podczas rozmowy rekrutacyjnej pojawią się dodatkowe pytania w sprawie wykonanego zadania

## Zadanie 1 - co to jest (analiza kodu źródłowego)

W tym zadaniu należy słownie, opisać kod źródłowy którego dotyczy rekrutacja (patrz zadanie 2 i 3)

1. co ten kod robi
  - Ten kod wysyła asynchroniczne zapytanie do serwera HTTP, które pobiera wszystkie headery z witryny podanej w metodzie Handle(). 
  Poza headerami ten kod pobiera cały payload - czyli razem całe HttpResponse
2. jakie widać problemy
  - Zduplikowana liczba biblioteki, niepotrzebna zmienna statyczna Variable1, abstrakcyjna klasa HttpRequestHandler ,niepełny konstruktor klasy(brak httpClientProxy), instrukcje warukowe if można zapisać prościej. Wszystko powyżej zostało poprawione podczas refactoringu kodu.
3. co jest fajnego?
  - Możliwość wpinania różnych Parserów do różnych stron / serwerów czyli uniwersalność.
4. jakie widzimy niebezpieczeństwa używając tej metody?
  - Słaba obsługa błędów; mylące, nieużywane paramterty (TRequest request) oraz niektóre argumenty w metodzie Handle().
## Zadanie 2 - refactoring & unit test

W tym zadaniu należy:

1. zrobić refactoring klasy **HttpRequestHandler.cs**, aby była:
   * bardziej przejrzysta do czytania
   * lepsza w używaniu
2. zaimplementować wszystkie interfejsy, przygotować konkretną implementację klasy bazowej, itd.
3. napisać unit testy do przykładowej klasy aby pokazać "że działa"
  **-gotowe 3 unit testy**

**Uwaga:**

* niniejsza klasa została zmodyfikowana celowo aby uzyskać efekt "bad design" / "bad quality" na potrzeby zadania rekrutacyjnego
* _"wszystkie chwyty dozwolone"_
* można w dowolny sposób zmieniać zawartość klasy, jej konstruktory, sygnatury metod, itp.

## Zadanie 3 - demo (sposób użycia)

W tym zadaniu należy przygotować, w dowolny sposób, krótką prezentację wykorzystania klasy **HttpRequestHandler.cs** z poprzednich zadań. Może to być zrobione w formie aplikacji konsolowej (zalecane), webowej lub dowolnej innej formie.

**Uwaga:**

demo powinno być przygotowane i wrzucone do repozytorium GitHub kandydata

## Podsumowanie

To już koniec "zadania domowego" :) Czy na koniec, możemy uprzejmie prosić o jedno zdanie komentarza na temat powyższych trzech zadań?

 ~Moim zdaniem zadanie było bardzo ciekawe oraz rozwojowe, zmuszało do myślenia jak i zweryfikowania napisanego kodu. Co najważniejsze -zrozumienia i sprawdzenia jak on działa, by móc dalej kontynuować pracę w programie.
