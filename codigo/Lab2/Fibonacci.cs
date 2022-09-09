using System;

class Fibonacci {
	
	static int FibonacciRec(int termo) {
	
		if (termo==1 || termo==0)
			return 1;
		else return FibonacciRec(termo-1)+FibonacciRec(termo-2);
	}

	static void Main(string[] args) {

		Console.WriteLine("Sequencia fibonacci.");
		for(int i = 0; i<10; i++) 
			Console.Write(FibonacciRec(i)+" ");
	}
}
