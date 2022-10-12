using System;
using System.Diagnostics;

class MergeSort {
	
	static void Merge(int[] Vetor, int inicio, int meio, int fim) {
		int p1, p2, tamanho, i, j, k;

		tamanho = fim-inicio+1;
		p1 = inicio;
		p2 = meio+1;
		
	}

	static void Sort(int[] Vetor, int inicio, int fim) {
	
		int meio;

		if (inicio<fim) {
			meio = (inicio+fim)/2;
			Sort(Vetor, inicio, meio);
			Sort(Vetor, meio, fim);
			Merge(Vetor, inicio, meio, fim);
		}
	}

	static void Main(string[] args) {
		
		int[] Valores = new int[] {88, 54, 23, 67, 43, 2, 5, 15, 25, 10};

		Console.WriteLine("Vetor de tamanho {0}", Valores.Length);
		Console.WriteLine("Entrada...");
		for(int i = 0; i<Valores.Length; i++) {
			Console.Write("{0} ", Valores[i]);
		}
		Console.WriteLine();

		// Ordenação
		Sort(Valores, 0, Valores.Length);

		// Saída
		
		Console.WriteLine("Saida...");
		for(int i = 0; i<Valores.Length; i++) {
			Console.Write("{0} ", Valores[i]);
		}
		Console.WriteLine();
	}
}
