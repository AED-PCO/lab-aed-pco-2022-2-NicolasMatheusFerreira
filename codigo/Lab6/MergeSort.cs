using System;
using System.Diagnostics;

class MergeSort {
	
	static void Merge(int[] Vetor, int inicio, int meio, int fim) {
		 var leftArrayLength = middle - left + 1;
		 var rightArrayLength = right - middle;
		 var leftTempArray = new int[leftArrayLength];
		 var rightTempArray = new int[rightArrayLength];
		 int i, j;
		 for (i = 0; i < leftArrayLength; ++i)
    		 	leftTempArray[i] = array[left + i];
		 for (j = 0; j < rightArrayLength; ++j)
		    	rightTempArray[j] = array[middle + 1 + j];
		 i = 0;
		 j = 0;
		 int k = left;
		 while (i < leftArrayLength && j < rightArrayLength) {
		    if (leftTempArray[i] <= rightTempArray[j]) {
		      array[k++] = leftTempArray[i++];
		    } else {
		      array[k++] = rightTempArray[j++];
		    }
		  }
		  while (i < leftArrayLength) {
		    array[k++] = leftTempArray[i++];
		  }
		  while (j < rightArrayLength) {
		    array[k++] = rightTempArray[j++];
		  }
		}		
	}

	static void Sort(int[] Vetor, int inicio, int fim) {
	
		int meio;

		if (inicio<fim) {
			meio = (inicio+fim)/2;
			Sort(Vetor, inicio, meio);
			Sort(Vetor, meio, fim);
			Merge(Vetor, inicio, meio, fim);
		}
	}

	static void Main(string[] args) {
		
		int[] Valores = new int[] {88, 54, 23, 67, 43, 2, 5, 15, 25, 10};

		Console.WriteLine("Vetor de tamanho {0}", Valores.Length);
		Console.WriteLine("Entrada...");
		for(int i = 0; i<Valores.Length; i++) {
			Console.Write("{0} ", Valores[i]);
		}
		Console.WriteLine();

		// Ordenação
		Sort(Valores, 0, Valores.Length);

		// Saída
		
		Console.WriteLine("Saida...");
		for(int i = 0; i<Valores.Length; i++) {
			Console.Write("{0} ", Valores[i]);
		}
		Console.WriteLine();
	}
}
