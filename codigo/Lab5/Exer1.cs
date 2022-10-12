using System;

class Exer1 {

	static int alg1(int n) {
		int res = 1;

		for(int i = n; i>1; i--) {
			res = res*i;
		}
		return res;
	}
	static void Main(string[] args) {
		
		Console.WriteLine(alg1(int.Parse(Console.ReadLine())));
	}
}
