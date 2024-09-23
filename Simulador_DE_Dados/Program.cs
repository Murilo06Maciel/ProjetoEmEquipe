Random random = new Random();
string opcao;

do
    {
		Console.Clear();
        int resultado = random.Next(1, 7);
        Console.WriteLine($"Você lançou o dado e o resultado foi: {resultado}");
        Console.Write("Deseja lançar o dado novamente? (s/n): ");
        opcao = Console.ReadLine().ToLower();

    } while (opcao == "s");

        Console.WriteLine("Encerrando o programa. Até a próxima!");