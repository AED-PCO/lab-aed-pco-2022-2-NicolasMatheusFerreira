using System;

class Exercicio4 {
	static void Main(string[] args) {
		
		int[,] Mat = new int[5,3];
		int soma;
					
		for(int i = 0; i<Mat.GetLength(0); i++) {
			for(int j = 0; j<Mat.GetLength(1); j++) {
				Console.Write("[{0},{1}]. Informe valor: ", i, j);
				Mat[i,j] = int.Parse(Console.ReadLine());
			}
		}
	
		for(int i = 0; i<Mat.GetLength(0); i++) {
			soma = 0;
			for(int j = 0; j<Mat.GetLength(1); j++) {
				soma +=Mat[i,j];		
			}
			Console.WriteLine($"A soma dos elementos da linha {i} e igual a {soma}");
		}

	}
}
