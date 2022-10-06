using System;

class InsertionSort {

	static void Imprimir(int[] Vetor) {
		
		for(int i = 0; i<Vetor.Length; i++)
			Console.Write($"{Vetor[i]} ");
		Console.WriteLine();
	}
	
	static void Main(string[] args) {
		
		int[] Vetor = new int[] {4, 7, 2, 5, 4, 0, 8, 3, 1};
			
		int chave, j;
		for(int i = 1; i<Vetor.Length; i++) {
			chave = Vetor[i];
			j = i - 1;
			while(j>=0 && Vetor[j]>chave) {
				Vetor[j+1] = Vetor[j];
				j--;
			
				Vetor[j+1] = chave;
			}
		}
			
		Console.WriteLine("Ordenado...!");
		Imprimir(Vetor);
	}
}
