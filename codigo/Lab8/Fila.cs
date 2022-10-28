using System;
using System.IO;

class Fila {

	static int Menu() {
		
		Console.WriteLine();
		Console.WriteLine("1. Inserir elemento");
		Console.WriteLine("2. Remover elemento");
		Console.Write("Opcao: ");
		int op = int.Parse(Console.ReadLine());
		return op;
	}

	static void Exporta(string caminho, string[] X, int n) {
	
		StreamWriter arquiv = new StreamWriter(caminho, false);

		for(int z = 0; z<n; z++)
			arquiv.WriteLine(X[z]);
		arquiv.Close();
	}
	static bool Entrada(string caminho, string[] Palavras, ref int j) {
	
		if (File.Exists(caminho)) {
			
			StreamReader arquiv = new StreamReader(caminho);
			j = 0;
	
			while(!arquiv.EndOfStream) {
				Palavras[j++] = arquiv.ReadLine();
			}
			arquiv.Close();
			return true;
		} 	
		return false;
	}

	static void RemoverElemento(string[] X, ref int n) {					

		if (n<=0)
			Console.WriteLine("A lista esta vazia!");
		else {
			Console.WriteLine("{0} foi removido!", X[0]);		
			for(int a = 0; a<n-1; a++)
				X[a] = X[a+1];
			n--;
		}
			
	}

	static void InserirElemento(string[] X, ref int n, string elemento) {
				
		if (X.Length<=n)
			Console.WriteLine("A lista esta cheia!");
		else X[n++] = elemento;			
		
	}

	static void Main(string[] args) {
				

		int n, op;
		char continuar;
		string palavra;
		string[] Palavras = new string[10];

		n = 0;				

		do {		
			if (Entrada("entrada.txt", Palavras, ref n)) {
			
				for(int i = 0; i<n; i++)
					Console.Write($"{i}. {Palavras[i]}  ");

				op = Menu();

				if (op==1) {
					Console.Write("Inserir...Palavra: ");
					palavra = Console.ReadLine();

					InserirElemento(Palavras, ref n, palavra);
				} else if (op==2)			
					RemoverElemento(Palavras, ref n);									
				Exporta("entrada.txt", Palavras, n);		
			} else { 
				Console.WriteLine("Arquivo inexistente!");
				Console.WriteLine();
			}

			for(int i = 0; i<n; i++)
				Console.Write($"{i}. {Palavras[i]}  ");

			Console.WriteLine();
			Console.Write("Deseja continuar (S) Sim ou (N) Nao: ");			
			continuar = Console.ReadLine()[0];
			Console.WriteLine();

		} while(continuar!='N' && continuar!='n');

		Console.WriteLine("Fim do programa!");
	}
}
