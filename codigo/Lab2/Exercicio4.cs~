using System;

class Ocorrencias {
	
	static int Ocorre(string frase, char carac, int i) {
		
		int cont = 0;
		if (i>0) {
			if (frase[i]==carac)
				cont++;
		}

		if (i==0)
			return cont;
		else return cont+Ocorre(frase, carac, i-1);
	}

	static void Main(string[] args) {
		
		string frase;
		char carac;

		Console.Write("Informe frase: ");
		frase = Console.ReadLine();
		Console.Write("Informe caractere: ");
		carac = Console.ReadKey().KeyChar;

		int result = Ocorre(frase, carac, frase.Length-1);
		Console.WriteLine($"\nNa frase tem a ocorrencia de {result} caracteres {carac}");
	}
}
