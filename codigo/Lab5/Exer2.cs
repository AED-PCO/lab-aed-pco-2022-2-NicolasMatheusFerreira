using System;

class Exer2 {

	static int alg2(int[] arr, int x) {
		for(int i = 0; i<arr.Length; i++) {
			if (arr[i]==x)
				return x;
		}
		return -1;
	}

	static void Main(string[] args) {
		Console.WriteLine(alg2(new int[] {5,4,3,2,1}, 1));
	}
}
