using System; 

class Ordenacao {

	static void Imprimir(int[] Vetor) {
		
		for(int i = 0; i<Vetor.Length; i++)
			Console.Write($"{Vetor[i]} ");
		Console.WriteLine();
	}
	
	static void Troca(int[] Vetor, int x, int y) {
		
		int aux = Vetor[x];
		Vetor[x] = Vetor[y];
		Vetor[y] = aux;
	}

	static void InsertionSort(int[] Vetor) {
			
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

	static void Main(string[] args) {
		
		int[] Vetor = new int[10];
		Random aleatorio = new Random();

		for(int i = 0; i<Vetor.Length; i++) {
			Vetor[i] = aleatorio.Next(0, 100);
		}

		Imprimir(Vetor);
		InsertionSort(Vetor);	
	}
}
