using System;
using System.Diagnostics;

class SelectionSort {

	static void Ordenacao(int[] Vetor, char[] Carc) {
		int menorInt = 0;

		for(int i = 0; i<Vetor.Length; i++) {
			menorInt = i;
			for(int j = i; j<Vetor.Length; j++) {
				if (Vetor[j]<Vetor[menorInt]) {
					menorInt = j;
				}
			}
			int aux = Vetor[i];
			Vetor[i] = Vetor[menorInt];
			Vetor[menorInt] = aux;
		}
		

		int menorChar = 0;
		for(int i = 0; i<Carc.Length; i++) {
			menorChar = i;
			for(int j = i; j<Carc.Length; j++) {
				if (Carc[j]<Carc[menorChar])
					menorChar = j;
			}
			char aux = Carc[i];
			Carc[i] = Carc[menorChar];
			Carc[menorChar] = aux;
		}

	}
	static void Main(string[] args) {

		int[] Vetor = new int[] {45, 6, 12, 32, 2, 1, 67, 28, 5, 64};
		char[] Carc = new char[] {'n', 'h', 'o', 'w', 'a', 'v', 'b', 's', 'c'};
		var stopwatch = new Stopwatch();

		stopwatch.Start();
		Ordenacao(Vetor, Carc);
		stopwatch.Stop();

		for(int i = 0; i<Vetor.Length; i++) {
			Console.Write("{0} ", Vetor[i]);		
		}
		Console.WriteLine();
		for(int i = 0; i<Carc.Length; i++) {
			Console.Write("{0} ", Carc[i]);			
		}
		Console.WriteLine();	
		Console.WriteLine("{0} Mil. Seg.", stopwatch.ElapsedMilliseconds);

	}
}
