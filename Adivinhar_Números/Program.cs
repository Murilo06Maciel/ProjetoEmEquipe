        int tentativas = 0; 
        Console.WriteLine("Tente adivinhar um número de 1 a 100:\n");
        while (true)
        {
			int aleatorio = 78;
			
            Console.Write("Digite o seu palpite: ");
            
            if (int.TryParse(Console.ReadLine(), out int palpite))
            {
                tentativas++; 

                if (palpite == aleatorio)
                {
                    Console.WriteLine($"Parabéns!!! Você acertou em {tentativas} tentativas!");
                    break; 
                }
                else if (palpite < aleatorio)
                {
                    if (palpite < aleatorio - 40)
                        Console.WriteLine("Muito baixo.\n");
                    else
                        Console.WriteLine("Baixo.\n");
                }
                else
                {
                    if (palpite > aleatorio + 40)
                        Console.WriteLine("Muito alto.\n");
                    else
                        Console.WriteLine("Alto.\n");
                }
            }
            else
            {
                Console.WriteLine("O que foi digitado não é um número. Por favor, insira um número.");
            }
        }