using System;

class BuscaBinRec {

	static int BuscaBinariaRec(int alvo, int[] Vetor, int inicio, int fim) {
		
			int meio = (inicio+fim)/2;
			if (inicio<=fim) {
				if (alvo==Vetor[meio]) {
					return meio;
				} else if (alvo<Vetor[meio]) {							
					return BuscaBinariaRec(alvo, Vetor, inicio, meio-1);
				} else if (alvo>Vetor[meio]) {						
					return BuscaBinariaRec(alvo, Vetor, meio+1, fim);
				}
			}
			return -1;
	}

	static void Main(string[] args) {
		
		int[] Vetor = new int[] {10, 34, 45, 65, 77, 101, 235, 665};
		int posic = BuscaBinariaRec(int.Parse(Console.ReadLine()), Vetor, 0, Vetor.Length-1);

		if (posic>0)
			Console.WriteLine(Vetor[posic]+" Esta contido na posicao "+posic);
		else Console.WriteLine("\aValor nao encontrado no vetor!");
	}
}
