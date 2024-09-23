Console.Write("Insira o número de segundos para o cronômetro: ");
int segundos = int.Parse(Console.ReadLine());

Console.WriteLine($"Cronômetro iniciado para {segundos} segundos...");

for (int i = segundos; i >= 0; i--)
{
    Console.Clear();
    Console.WriteLine($"Tempo restante: {i} segundos");
    Thread.Sleep(1000);
}

Console.WriteLine("Tempo esgotado!");