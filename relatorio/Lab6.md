## Ordenações

# Bubble Sort

	static void BubbleSort(int[] Vetor) {

	    for(int i = 0; i<Vetor.Length; i++) {
	        for(int j = 0; j<Vetor.Length-1; j++) {
	            if (Vetor[j]>Vetor[j+1])
	                Troca(Vetor, j, j+1);
	        }
	    }
	}
Buble sort é um algorítimo de ordenção de ordem de complexidade O(N²), o algorítimo é composto por dois laços de looping que itera um em função do outro comparando a posição atual mais a posição N+1, e realizando as trocas de posições para assim ordena-lás.
# Insertion Sort

	static void Ordenacao(int[] Vetor, char[] Carc) {
		int menorInt = 0;

		for(int i = 0; i<Vetor.Length; i++) {
			menorInt = i;
			for(int j = i; j<Vetor.Length; j++) {
				if (Vetor[j]<Vetor[menorInt]) {
					menorInt = j;
				}
			}
			int aux = Vetor[i];
			Vetor[i] = Vetor[menorInt];
			Vetor[menorInt] = aux;
		}
	}

Insertion Sort é um algorítimo de ordenção de ordem de complexidade O(N²), o algorítimo percorre um laço de looping para encontrar o menor valor do vetor assim que é encontrado ele troca com a posição que está em função do laço externo e assim o laço interno vai alterando seu limite inferior.
	
# Selection Sort

	static void SelectSort(int[] Vetor) {
		int chave, j;
		for(int i = 1; i<Vetor.Length; i++) {
			chave = Vetor[i];
			j = i - 1;
			while(j>=0 && Vetor[j]>chave) {
				Vetor[j+1] = Vetor[j];
				j--;			
				Vetor[j+1] = chave;
			}
		}					
	}
	
# Merge Sort

	 Exemplo
# Quick Sort

	 Exemplo
# Couting Sort

	 Exemplo
# Radix Sort

	 Exemplo
