using System;

class RadixSort {

	static void Imprimir(string[,] C) {

		for(int i = 0; i<C.GetLength(0); i++) {
			Console.Write("[{0}] - ", i);
			for(int j = 0; j<C.GetLength(1); j++)
				Console.Write("{0}", C[i,j]);
			Console.Write("\n");
		}

	}

	static string[,] Sort(string[] A) {
		
		int x = 0, y = 0;
		string[,] B = new string[10,A.Length];

		for(int i = 0; i<B.GetLength(0); i++) {
			for(int j = 0; j<B.GetLength(1); j++) {
				if (int.Parse(A[j].Substring(A[j].Length-1-y,1))==i) {
					B[i,x++] = A[j];					
				}					
			}						
		}	
		return B;
	}

	static void Main(string[] args) {
		Random aleatorio = new Random();
		string[] A = new string[3];
		string[,] C = new string[10,A.Length];

		for(int i = 0; i<A.Length; i++)
			A[i] = aleatorio.Next(0,100).ToString();
		C = Sort(A);
		Imprimir(C);
	}
}
