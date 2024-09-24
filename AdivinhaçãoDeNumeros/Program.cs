Random random = new Random();
		int numeroSecreto = random.Next(1, 101);
		int palpite = 0;
		int tentativas = 0;
		Console.WriteLine("Tente adivinhar o número entre 1 e 100!");
		while (palpite != numeroSecreto)
		{
			Console.Write("Digite seu palpite: ");
			string entrada = Console.ReadLine();
			if (int.TryParse(entrada, out palpite))
			{
				tentativas++;
				if (palpite < numeroSecreto)
				{
					Console.WriteLine("Muito baixo! Tente novamente.");
				}

				if (palpite > numeroSecreto)
				{
					Console.WriteLine("Muito alto! Tente novamente.");
				}
				else if (palpite == numeroSecreto)
				{
					Console.WriteLine($"Parabéns! Você adivinhou em {tentativas} tentativas.");
				}
			}
			else
			{
				Console.WriteLine("Por favor, insira um número válido!");
			}
		}
