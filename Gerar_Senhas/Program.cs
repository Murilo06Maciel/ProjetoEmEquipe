static void Main()
{
const string caracteresPermitidos = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
Console.Write("Insira o comprimento da senha desejada: ");
int comprimento = int.Parse(Console.ReadLine());
string senhaGerada = GerarSenhaAleatoria(comprimento, caracteresPermitidos);
Console.WriteLine($"Senha gerada: {senhaGerada}");
}
static string GerarSenhaAleatoria(int comprimento, string caracteres)
{
StringBuilder senha = new StringBuilder();
Random random = new Random();

for (int i = 0; i < comprimento; i++)
    {
    int indiceAleatorio = random.Next(caracteres.Length);
    senha.Append(caracteres[indiceAleatorio]);
    }

    return senha.ToString();
}