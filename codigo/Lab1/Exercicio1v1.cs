using System;

class Exercicio1v1 {

	static int Potencia(int num, int expo) {
		
		int cont = 1;

		while(cont<expo) {
			num*= num;
			cont = cont + 1;
		}
		return num;
	}

	static void SeparaNumeros(int valor, ref int a, ref int b) {
		
		string num = Convert.ToString(valor);
		string grupoA = "", grupoB = "";
		int comp=0, soma=0, atrib=0;

		for(int i = 0; i<num.Length; i++) {
			if (i<num.Length/2.0) {				
				grupoA += num[i];
			} else grupoB += num[i];
			Console.WriteLine("Comp.: "+comp);			
			soma++;
			atrib++;
			Console.WriteLine("Soma.: "+soma);
			Console.WriteLine("Atrib.: "+atrib);

		}

		a = int.Parse(grupoA);
		b = int.Parse(grupoB);
	}

	static void Main(string[] args) {

		int numero, grupoA = 0, grupoB = 0;

		
		for(int i = 1000; i<=9999; i++) {
			numero = i;
			SeparaNumeros(numero, ref grupoA, ref grupoB);	
			if (numero==Potencia(grupoA+grupoB, 2))
				Console.Write("{0} ", numero);
		}
		Console.WriteLine();
	}
}
