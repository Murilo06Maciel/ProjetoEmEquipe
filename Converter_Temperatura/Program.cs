Console.WriteLine("Conversor de Temperatura");
Console.WriteLine("Escolha uma das opções de conversão:");
Console.WriteLine("1 - Celsius para Fahrenheit");
Console.WriteLine("2 - Celsius para Kelvin");
Console.WriteLine("3 - Fahrenheit para Celsius");
Console.WriteLine("4 - Fahrenheit para Kelvin");
Console.WriteLine("5 - Kelvin para Celsius");
Console.WriteLine("6 - Kelvin para Fahrenheit");

int opcao = int.Parse(Console.ReadLine());

Console.Write("Digite a temperatura que deseja converter: ");
double temperatura = double.Parse(Console.ReadLine());

double resultado;

switch (opcao)
{
    case 1:
    resultado = CelsiusParaFahrenheit(temperatura);
    Console.WriteLine($"{temperatura}°C é igual a {resultado}°F");
    break;
    case 2:
    resultado = CelsiusParaKelvin(temperatura);
    Console.WriteLine($"{temperatura}°C é igual a {resultado}K");
    break;
    case 3:
    resultado = FahrenheitParaCelsius(temperatura);
    Console.WriteLine($"{temperatura}°F é igual a {resultado}°C");
    break;
    case 4:
    resultado = FahrenheitParaKelvin(temperatura);
    Console.WriteLine($"{temperatura}°F é igual a {resultado}K");
    break;
    case 5:
    resultado = KelvinParaCelsius(temperatura);
    Console.WriteLine($"{temperatura}K é igual a {resultado}°C");
    break;
    case 6:
    resultado = KelvinParaFahrenheit(temperatura);
    Console.WriteLine($"{temperatura}K é igual a {resultado}°F");
    break;
    default:
    Console.WriteLine("Opção inválida. Tente novamente.");
    break;
}