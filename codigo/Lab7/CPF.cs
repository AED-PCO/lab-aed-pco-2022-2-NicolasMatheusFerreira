using System;

class CPF {
	static string GerarCpf() {
		
		Random aleatorio = new Random();
		int[] Digitos = new int[11];
		int[] Sequencia = new int[] {10,9,8,7,6,5,4,3,2};
		int soma = 0, resto;
		string cpf = "";

		for(int i = 0; i<Digitos.Length-3; i++)
			Digitos[i] = aleatorio.Next(0,10); //Gerando números pseudo-aleatórios
		Digitos[8] = aleatorio.Next(0,10); // Definindo região fiscal emissora do cpf
		
		for(int i = 0; i<Sequencia.Length-1; i++)
			soma += Digitos[i]*Sequencia[Sequencia.Length-1-i];
		resto = soma%11;

		if (resto==1 || resto==0)
			Digitos[9] = 0;
		else Digitos[9] = 11 - resto;
		
		soma = 0;
		for(int i = 1; i<Sequencia.Length-1; i++)
			soma += Digitos[i]*Sequencia[Sequencia.Length-1-i];
		resto = soma%11;

		if (resto==1 || resto==0)
			Digitos[10] = 0;
		else Digitos[10] = 11 - resto;

		for(int i = 0; i<Digitos.Length; i++)
			cpf+=Digitos[i];

		return cpf;
	}

	static void Main(string[] args) {

		Console.WriteLine(GerarCpf());
	}
}
