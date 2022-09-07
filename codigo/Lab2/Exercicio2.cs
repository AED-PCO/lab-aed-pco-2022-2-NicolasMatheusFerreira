using System;

class Exercicio2 {
	static double MultiRec(double a, double b) {

	    double result;
	    if (b==1)
        	return a;
	    else result = a + MultiRec(a, b-1);
	    return result;
	}

	static void Main(string[] args) {
		double a, b;
		Console.WriteLine("Multiplicacao recursiva.");
		Console.WriteLine("Informe o primeiro valor: ");
		a = double.Parse(Console.ReadLine());
		Console.WriteLine("Informe o segundo valor: ");
		b = double.Parse(Console.ReadLine());

		double resultado = MultiRec(a,b);
		Console.WriteLine($"A multiplicacao entre {a} e {b} e igual a {resultado}");
	}
}
