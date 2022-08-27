using System;

class Questao2 {

	static bool ehPerfeito(int valor) {
		
		int soma = 0;

		for(int i = 1; i<valor; i++)					
			if (valor%i==0)
				soma += i;

		if (soma==valor)
			return true;
		return false;
	}

	static bool ehPrimo(int valor) {
		
		int cont = 0;
		for(int i = 2; i<=valor; i++)
			if (valor%i==0)
				cont++;
		if (cont==1)
			return true;
		return false;
	}

	static void Main(string[] args) {
		
		int valor;

		Console.Write("Informe um valor: ");
		valor = int.Parse(Console.ReadLine());
		
		if (ehPrimo(valor))
			Console.WriteLine("{0} E primo!", valor);
		else Console.WriteLine("{0} Nao e primo!", valor);
		if (ehPerfeito(valor))
			Console.WriteLine("{0} E perfeito!", valor);
		else Console.WriteLine("{0} Nao e perfeito!", valor);
	}
}
