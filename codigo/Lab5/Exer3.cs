using System;

class Exer3 {
	
	double[] Soma(double[] Vetor) {
		
		double[] res = new double[Vetor.Length];
		for(int i = 0; i<Vetor.Length; i++) {
			for(int j = 0; j<Vetor.Length; j++) {
				if (i!=j)
					res[j] = res[j]+Vetor[i]/Vetor[j];
			}
		}
		return res;
	}

	static void Main(string[] args) {
	
		Exer3 exer = new Exer3();
		double[] Vetor = new double[] {5, 4, 3, 2, 1};		

		for(int j = 0; j<Vetor.Length; j++)
			Console.Write("{0} ", Vetor[j]);
		Console.WriteLine();
		Vetor = exer.Soma(Vetor);
		for(int i = 0; i<Vetor.Length; i++)
			Console.Write("{0} ", Vetor[i]);
		Console.WriteLine();
	}
}
