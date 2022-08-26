using System;

class SomaPares {

	static int SomaPar(int[] Vetor, int x) {
	
		int parc=0, soma;
		if (Vetor[x]%2==0) {
			parc = Vetor[x];
		} else parc = 0;

		if (x==0) {
			return parc;
		} else soma = parc+SomaPar(Vetor, --x);
		return soma;
	}

	static void Main(string[] args) {
		
		int[] Valores = new int[10];
		Random aleatorio = new Random();
		int entrada = 0;
	
		Console.WriteLine("Soma recursiva de valores pares.");
		
		for(int i = 0; i<Valores.Length; i++) {

			entrada = aleatorio.Next(0, 100);
			Console.WriteLine($"{i+1}. Informe valor: {entrada}");
			Valores[i] = entrada;
		}

		Console.WriteLine("A soma dos termos pares do vetor e igual a {0}", SomaPar(Valores, Valores.Length-1));
	}
}
