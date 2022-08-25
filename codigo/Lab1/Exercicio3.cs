using System;

class Exercicio3 {

	static int TAM = 5;

	static void Exibe(string[] C) {

		int a = 0;
		while(C[a]!=null) {
			Console.WriteLine(C[a++]);
		}
	}

	static void Existe(string[] A, string[] B, string[] D) {
		
		int w = 0, h = 0;
		for(int x = 0; x<TAM; x++) {
			w =0;
			for(int z = 0; z<TAM; z++)
				if (A[x]==B[z])
					w++;
			if (w==0)
				D[h++] = A[x];						
		}
	}

	static void Comum(string[] A, string[] B, string[] C) {
		
		int k = 0;
		for(int i = 0; i<TAM; i++) {
			for(int j = 0; j<TAM; j++)
				if (A[i].Equals(B[j]))
					C[k++] = A[i];
		}
	}

	static void Leitura(string[] C, string[] D) {

		Console.WriteLine("Vetor 1...");
		for(int i = 0; i<TAM; i++) {
			Console.Write($"{1+i}. Informe palavra: ");
			C[i] = Console.ReadLine();
		}	

		Console.WriteLine("Vetor 2...");
		for(int k = 0; k<TAM; k++) {
			Console.Write($"{1+k}. Informe palavra: ");
			D[k] = Console.ReadLine();
		}
	}

	static void Main(string[] args) {
				
		string[] A = new string[TAM];
		string[] B = new string[TAM];
		string[] C = new string[TAM];
		string[] D = new string[TAM];
	
		Leitura(A, B);
			
		for(int z = 0; z<C.Length; z++) {
			C[z] = null;
			D[z] = null;
		}

		Comum(A, B, C);
		Existe(A, B, D);
		Exibe(D);		
	}
}
