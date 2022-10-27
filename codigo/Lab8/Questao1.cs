using System;
using System.IO;

class Questao1 {

	static void LerArquivo(string[] Entrada, int i, string path) {
		
		if (!File.Exists(path))
			Console.WriteLine("Arquivo nao existe!");
		else {
			StreamReader arquivo = new StreamReader(path);		
			i = 0;

			while(!arquivo.EndOfStream) {
				Entrada[i++] = arquivo.ReadLine();
			}
		}
	}

	static void Main(string[] args) {
		
		string[] entradaArquivo = new string[5];
		string[] Entrada = new string[5];
		int iguais, diferentes;

		LerArquivo(entradaArquivo, 0, "arq1.txt");

		iguais = 0;
		diferentes = 0;

		for(int i = 0; i<Entrada.Length; i++) {
			Console.Write("Informe um texto: ");
			Entrada[i] = Console.ReadLine();

			if (Entrada[i].Equals(entradaArquivo[i]))
				iguais++;
			else diferentes++;
		}			
	
		Console.WriteLine($"Existem {iguais} palavras IGUAIS e {diferentes} diferentes.");
	}
}
