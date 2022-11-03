using System;

class Lista {

	static void InserirElementoFinal(string[] Vetor, string elemento, ref int qtd) {
		
		Vetor[qtd++] = elemento;		
	}

	static void InserirElemento(string[] Vetor, int posicao, string elemento, ref int qtd) {
		
		if (posicao<Vetor.Length) {
			Vetor[posicao] = elemento;
			qtd++;
		} else Console.WriteLine("Posicao fora dos limites da lista!");					
	}

	static void Main(string[] args) {
	
		string[] Palavras = new string[10];
		string elemento;
		int i = 0, op, posicao;
		char continuar;

		do {
			for(int z = 0; z<i; z++)
				Console.Write($"{z+1}.{Palavras[z]} ");

			Console.Clear();
			Console.WriteLine("(1). Inserir no incio");
			Console.WriteLine("(2). Inserir no fim");
			Console.WriteLine("(3). Inserir");
			Console.WriteLine("(4). Remover do incio");
			Console.WriteLine("(5). Remover do fim");
			Console.WriteLine("(6). Remover");
			Console.Write("Opcao: ");
			op = int.Parse(Console.ReadLine());

			Console.Write("Informe elemento: ");
			elemento = Console.ReadLine();
			Console.Write("Posicao: ");
			posicao = int.Parse(Console.ReadLine());

			switch (op) {
				case 1:
				break;

				case 2:
					 InserirElementoFinal(Palavras, elemento, ref i);
				break;

				case 3:
					InserirElemento(Palavras, posicao, elemento, ref i);
				break;

				case 4:
				break;

				case 5:
				break;

				case 6:
				break;

				default:
					Console.WriteLine("Opcao invalida!");
				break;
			}
		
			for(int z = 0; z<i; z++)
				Console.WriteLine($"{z+1}.{Palavras[z]} ");

			Console.Write("Deseja continuar? S/N: ");
			continuar = Console.ReadLine()[0];

		} while(continuar!='n' && continuar!='N');
		Console.WriteLine("Fim");

	}
}
