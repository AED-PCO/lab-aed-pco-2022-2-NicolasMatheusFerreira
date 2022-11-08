using System;

class Questao2 {

	static int funcRec1(int a) {

		if (a<=1)
			return 0;
		else return funcRec1((a-2)+5);
	}

	static void Main(string[] args) {
		
		Console.WriteLine(funcRec1(6));
	}
}
