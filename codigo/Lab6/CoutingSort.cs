using System;

class CoutingSort {

	static void Couting(int[] Valores) {
		int i, j, k;
		int[] Aux = new int[100];
		for(i = 0; i<Aux.Length; i++) {
			Aux[i] = 0;
		}
		for(i = 0; i<Valores.Length; i++) {
			Aux[Valores[i]]++;
		}

		for(i = 0, j = 0; j<Aux.Length; j++)
			for(k = Aux[j]; k>0; k--)
				Valores[i++] = j;
	}

	static void Main(string[] args) {
		
		int[] Vetor = new int[] {45, 32, 22, 56, 11, 4, 2, 7, 9, 100};
		for(int i = 0; i<Vetor.Length; i++)
			Console.Write("{0} ", Vetor[i]);
		Console.WriteLine();
		Couting(Vetor);
		for(int j = 0; j<Vetor.Length; j++)
			Console.Write("{0} ", Vetor[j]);
	}
}
