using System;
using System.IO;

class Questao3 {

	static string Inverter(string x) {

		string aux = "";
		for(int i = x.Length-1; i>=0; i--)
			aux = aux + x[i];
		return aux;
	}

	static bool EscreverArquivo(string caminho, char x, string mensagem) {
		
		bool permissao;

		if (x=='a')
			permissao = true;
		else permissao = false;

		StreamWriter arquivo = new StreamWriter(caminho, permissao);

		arquivo.WriteLine(mensagem);
		arquivo.Close();
		return true;
	}

	static bool LerArquivo(string caminho, ref string x) {

		if (!File.Exists(caminho)) {
			Console.WriteLine("Arquivo inexistente.");
			return false;
		} else {
			StreamReader arquivo = new StreamReader(caminho);
			x = arquivo.ReadLine();
			arquivo.Close();
		}
		return true;
	}

	static void Main(string[] args) {

		string palavra="";
		LerArquivo("entrada.txt", ref palavra);				
		palavra = Inverter(palavra);		
		EscreverArquivo("saida.txt", 'w', palavra);	
	}
}
