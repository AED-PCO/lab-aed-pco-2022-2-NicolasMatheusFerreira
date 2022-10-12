using System;
using System.Diagnostics;

class SelectionSort {

	static void Ordenacao(int[] Vetor) {
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
	}
	static void Main(string[] args) {

		int[] Vetor = new int[] {45, 6, 12, 32, 2, 1, 67, 28, 5, 64};
		var stopwatch = new Stopwatch();

		stopwatch.Start();
		Ordenacao(Vetor);
		stopwatch.Stop();

		for(int i = 0; i<Vetor.Length; i++) {
			Console.Write("{0} ", Vetor[i]);		
		}
		Console.WriteLine();
		Console.WriteLine("{0} Mil. Seg.", stopwatch.ElapsedMilliseconds);

	}
}
