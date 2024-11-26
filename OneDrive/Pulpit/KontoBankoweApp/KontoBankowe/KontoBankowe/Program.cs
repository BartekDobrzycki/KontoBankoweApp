using System;

class KontoBankowe
{
    public string NumerKonta;
    public double Saldo;

    public void Wpłata(double kwota)
    {
        Saldo += kwota;
        Console.WriteLine($"Wpłata {kwota} PLN. Nowe saldo {Saldo} PLN.");
    }

    public void Wypłata(double kwota)
    {
        if (kwota <= Saldo)
        {
            Saldo -= kwota;
            Console.WriteLine($"Wypłata {kwota} PLN. Nowe saldo {Saldo} PLN");
        }
        else
        {
            Console.WriteLine("Brak wystarczających środków na kącie");
        }
    }
    public void sprawdzsaldo()
    {
        Console.WriteLine($"Aktualne saldo wynosi {Saldo} PLN.");
    }
}


class Program
{
    static void Main(string[] args)
    {
        KontoBankowe mojeKonto = new KontoBankowe();

        mojeKonto.NumerKonta = "123456789";
        mojeKonto.Saldo = 1000.00;

        int wybor = 0;

        while (true)
        {
            Console.WriteLine("\n Co chcesz zrobić - Wybierz opcje (1 - 4)\n 1 - Sprawdź saldo\n 2 - Wpłać pieniądze\n 3 - Wypłąć pieniądze\n 4 - Zakończ");

            wybor = Convert.ToInt32(Console.ReadLine());

            switch (wybor)
            {
                case 1:
                    mojeKonto.sprawdzsaldo();
                    break;
                case 2:
                    Console.WriteLine("Podaj kwote do wpłaty: ");
                    double kwotawpłaty = Convert.ToDouble(Console.ReadLine());
                    mojeKonto.Wpłata(kwotawpłaty);
                    break;
                case 3:
                    Console.WriteLine("Podaj kwote do wypłaty: ");
                    double kwotawypłaty = Convert.ToDouble(Console.ReadLine());
                    mojeKonto.Wypłata(kwotawypłaty);
                    break;
                case 4:
                    Console.WriteLine("Dziekujemy za skorzystanie z naszej aplikacji! Do zobaczenia!");
                    return;
                default:
                    Console.WriteLine("Nieprawidłowy wybór. Spróbój ponownie");
                    break;
            }
        }
    }
}