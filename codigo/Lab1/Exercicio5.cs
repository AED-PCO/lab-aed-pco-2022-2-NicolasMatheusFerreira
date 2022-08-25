using System;

class Exercicio5 {
	
	static int Fat(int x) {
		int fat = 1;
		while(x>1) {
			fat*=x;
			x--;
		}
		return fat;
	}

	static void Main(string[] args) {
		
		Console.Write("Calcular fatorial de um numero. \n\n");
		Console.Write("Informe um valor: ");
		int vlr = int.Parse(Console.ReadLine());
		Console.WriteLine(Fat(vlr));
	}
}
