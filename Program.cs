using System;
using System.Collections.Generic;
using System.Linq;
using Hotel;

class Program
{
    List<Suite> suites = new List<Suite>
    {
        new Suite("Standard", 100m),
        new Suite("Deluxe", 200m),
        new Suite("Family", 250m, 4)
    };

    List<Reserva> reservas = new List<Reserva>();

    static void Main()
    {
        var program = new Program();
        program.CreateReservation();
    }

    void CreateReservation()
    {
        try
        {
            Console.WriteLine("Bem-vindo ao Hotel Sol e Lua!");
            Console.Write("Para quantas pessoas será a reserva? ");

            if (!int.TryParse(Console.ReadLine(), out int numGuests) || numGuests <= 0)
            {
                Console.WriteLine("Número de hóspedes inválido.");
                return;
            }

            Console.WriteLine("\nQuartos disponíveis:");

            var bestSuite = suites
                .Where(s => s.Capacity >= numGuests)
                .OrderBy(s => s.PricePerNight)
                .FirstOrDefault();

            if (bestSuite == null)
            {
                Console.WriteLine("Nenhuma suíte disponível para essa quantidade de pessoas.");
                return;
            }

            for (int i = 0; i < suites.Count; i++)
            {
                var suite = suites[i];

                Console.Write($"{i + 1} - {suite.Name} | Capacidade: {suite.Capacity} | R${suite.PricePerNight}");

                if (suite == bestSuite)
                    Console.Write(" ⭐ Recomendado");

                Console.WriteLine();
            }

            Console.Write("\nEscolha o número do quarto: ");
            if (!int.TryParse(Console.ReadLine(), out int suiteChoice) || suiteChoice < 1 || suiteChoice > suites.Count)
            {
                Console.WriteLine("Escolha inválida.");
                return;
            }

            var selectedSuite = suites[suiteChoice - 1];

            var guests = new List<Pessoa>();

            Console.WriteLine($"\nInforme {(numGuests > 1 ? "os nomes dos hóspedes" : "seu nome")}:");

            for (int i = 0; i < numGuests; i++)
            {
                while (true)
                {
                    Console.Write($"Hóspede {i + 1}: ");
                    var name = Console.ReadLine();

                    if (!string.IsNullOrWhiteSpace(name))
                    {
                        guests.Add(new Pessoa(name));
                        break;
                    }

                    Console.WriteLine("Nome inválido.");
                }
            }

            int nights;
            while (true)
            {
                Console.Write("\nQuantas noites? ");

                if (int.TryParse(Console.ReadLine(), out nights) && nights > 0)
                    break;

                Console.WriteLine("Valor inválido.");
            }

            decimal total = selectedSuite.PricePerNight * nights;

            Console.WriteLine($"\nResumo:");
            Console.WriteLine($"- Suíte: {selectedSuite.Name}");
            Console.WriteLine($"- Hóspedes: {guests.Count}");
            Console.WriteLine($"- Noites: {nights}");
            Console.WriteLine($"- Total: R${total}");

            Console.Write("Confirmar reserva? (s/n): ");
            var confirm = Console.ReadLine()?.ToLower();

            if (confirm == "s")
            {
                var reserva = new Reserva(guests, selectedSuite, nights);
                reservas.Add(reserva); // ✔ agora salva

                Console.WriteLine("Reserva confirmada!");
            }
            else
            {
                Console.WriteLine("Reserva cancelada.");
            }
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }
    }
}