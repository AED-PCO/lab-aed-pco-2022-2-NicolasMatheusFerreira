using System;

class Exercicio6 {

	static void Potencia(double bas, int expoente, ref double resultado) {
		
		while(expoente>=1) {
			resultado*=bas;
			expoente = expoente - 1;
		}
	}
	static void Main(string[] args) {
		
		double bas, resultado = 1;
		int expo;
		Console.WriteLine("Potenciacao por referencia");
		Console.Write("Informe valor de base: ");
		bas = double.Parse(Console.ReadLine());
		Console.Write("Informe expoente: ");
		expo = int.Parse(Console.ReadLine());
		Potencia(bas, expo, ref resultado);

		Console.WriteLine("A potencia de {0} elevado a {1} e igual a {2}", bas, expo, resultado);
	}
}
