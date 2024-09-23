decimal peso;
		Console.WriteLine("Insira o seu peso em kilogramas: ");
		while (!decimal.TryParse(Console.ReadLine(), out peso) || peso <= 0)
		{
			Console.WriteLine("\nPor favor, insira um número válido.");
		}

		decimal altura;
		Console.WriteLine("Insira a sua altura em metros: ");
		while (!decimal.TryParse(Console.ReadLine(), out altura) || altura <= 0)
		{
			Console.WriteLine("\nPor favor, insira um número válido.");
		}

		decimal imc = peso / (altura * altura);
		Console.WriteLine($"O seu imc é de: {imc}.\n\n");
        if(imc < 18,5)
        {
		Console.WriteLine($"Baixo peso.\n\n");

        }
        else if(imc > 18,5 && imc <= 24,9)
        {
		Console.WriteLine($"Peso normal.\n\n");

        }
        else if(imc > 25 && imc <= 29,9)
        {
		Console.WriteLine($"Sobrepeso.\n\n");
        }
        else if(imc > 30)
        {
    	Console.WriteLine($"Obesidade.\n\n");
        }
