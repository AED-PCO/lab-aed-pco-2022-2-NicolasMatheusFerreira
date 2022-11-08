using System;

class Questao5 {
	static int funcao(int a, int[] v) {
		
		if (a==1)
			return v[0];
		else {
			int x;
			x = funcao(a-1, v);

			if (x>v[a-1])
				return x;
			else return v[a-1];
		}
	}
	static void Main(string[] args) {
		Console.WriteLine(funcao(6, new int[] {10,5,7,15,22,9,30}));
	}
}
