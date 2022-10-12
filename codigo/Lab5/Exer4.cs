using System;

class Exer4 {
	public double[] Soma(double[] dados) {
		
		double[] vet = new double[dados.Length];

		for(int i = 0; i<dados.Length; i++) {
			double soma = 0.0;
			for(int j=0; j<i; j++)
				soma+=dados[j];
			vet[i] = soma/(i+1);
		}
		return vet;
	}

	static void Main(string[] args) {
		
		Exer4 exer = new Exer4();
		double[] Vet = new double[] {5,4,3,2,1};
		
		for(int i = 0; i<Vet.Length; i++)
			Console.Write("{0} ", Vet[i]);
		Console.WriteLine();
		Vet = exer.Soma(Vet);

		for(int i = 0; i<Vet.Length; i++)
			Console.Write("{0} ", Vet[i]);
		Console.WriteLine();
	}
}
