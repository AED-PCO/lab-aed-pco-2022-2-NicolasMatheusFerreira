using System;
using System.Diagnostics;

class BubbleSort {

	static void BubbleSort(int[] Vetor) {

	    for(int i = 0; i<Vetor.Length; i++) {
	        for(int j = 0; j<Vetor.Length-1; j++) {
	            if (Vetor[j]>Vetor[j+1])
	                Troca(Vetor, j, j+1);
	        }
	    }
	}


	static void Main(string[] args) {
		
		Random aleatorio = new Random();
		int[] Valores = new int[10];
		var stopwatch = new Stopwatch();
		stopwatch.Start();

		for(int z = 0; z<Valores.Length; z++)
		    Valores[z] = aleatorio.Next(0,1000);

		Imprimir(Valores);
		//SelectSort(Valores);
		BubbleSort(Valores);
		Imprimir(Valores);
		stopwatch.Stop();
		Console.WriteLine("Quant. MiliSeg.: {0}", stopwatch.ElapsedMilliseconds);	
	}
}
