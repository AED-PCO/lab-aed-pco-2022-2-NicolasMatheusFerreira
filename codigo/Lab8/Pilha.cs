using System;
using System.IO;

class Pilha {
	
	static void ExportaSaida(string path, string[] Vetor, ref int n) {
		
		StreamWriter arquivo = new StreamWriter(path, false);

		int j = 0;
		while(j<n) {
			arquivo.WriteLine(Vetor[j++]);			
		}
		arquivo.Close();
	}

	static bool ImportaEntrada(string path, string[] Vetor, ref int i) {
		
		if (File.Exists(path)) {			
			StreamReader arquivo = new StreamReader(path);

			i = 0;

			while(!arquivo.EndOfStream) {
				Vetor[i++] = arquivo.ReadLine();
			}
			arquivo.Close();
			return true;
		} else Console.WriteLine("Arquivo nao existe!");
		return false;
	}

	static void RemoverElemento(string[] Palavras, ref int n) {
		
		if (n<=0)
			Console.WriteLine("Pilha esta vazia!");
		else n--;
	}

	static void InserirElemento(string[] Palavras, ref int n, string elemento) {
		
		if (n>=Palavras.Length)
			Console.WriteLine("Pilha esta cheia!");
		else Palavras[n++] = elemento;					
	}

	static void Main(string[] args) {
		
		string[] entrada = new string[10];
		string elemento;
		int n = 0, op;
		char continuar;

		do {
			Console.Clear();
			ImportaEntrada("entrada.txt", entrada, ref n);

			for(int i = 0; i<n; i++)
				Console.Write($"{i}.{entrada[i]}  ");
			Console.Write("\n");
		
			Console.WriteLine("(1). Inserir");
			Console.WriteLine("(2). Remover");
			Console.Write("Operacao: ");
			op = int.Parse(Console.ReadLine());
			

			if (op==1) {
				Console.Clear();
				Console.Write("Informe elemento: ");
				elemento = Console.ReadLine();

				InserirElemento(entrada, ref n, elemento);

			} else if (op==2) {
				Console.Clear();	
				RemoverElemento(entrada, ref n);
			}

			ExportaSaida("entrada.txt", entrada, ref n);

			for(int i = 0; i<n; i++)
				Console.Write($"{i}.{entrada[i]}  ");
			Console.WriteLine();
			
			Console.Write("Deseja continuar? (S). Sim ou (N). Nao: ");
			continuar = Console.ReadLine()[0];			
			Console.Write("\n\n");
		} while(continuar=='S' || continuar=='s');		
		Console.WriteLine("Fim do programa!");
	}
}
