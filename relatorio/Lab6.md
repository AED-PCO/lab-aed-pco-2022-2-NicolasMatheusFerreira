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
![BubbleSort](https://user-images.githubusercontent.com/71523671/195409233-5dc90cf1-8073-4487-8b8d-3ebb6666ec38.png)

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

![Insertion Sort](https://user-images.githubusercontent.com/71523671/195409268-2b8db607-e196-4e9f-926d-5617be9dcd46.png)

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
A ordenação por seleção é um algoritmo de ordenação baseado em se passar sempre o menor valor do vetor para a primeira posição, depois o de segundo menor valor para a segunda posição, e assim é feito sucessivamente com os n-1 elementos restantes, até os últimos dois elementos.

![Selection Sort](https://user-images.githubusercontent.com/71523671/195409329-61ae7c94-1860-4761-8a2e-b8ea2031f66d.png)

# Merge Sort

	 Exemplo
Merge Sort, é um dos algorítimos de ordenação mais eficazes sendo capaz de ordenar grandes quantidades de dados através de dividir para conquistar. O algorítimo divide o vetor em dois até chegar em seu caso base e reconstruir já ordenado. Sua complexidade é de O (N*Log N).
![Merge Sort](https://user-images.githubusercontent.com/71523671/195409353-abf182ce-f95f-4e55-a2ed-05d035fed6bc.png)

# Quick Sort

	 Exemplo
# Shell Sort

	 Exemplo
![Shell Sort](https://user-images.githubusercontent.com/71523671/195409449-ebdc7519-887d-4fe8-b3b1-d6363fd0e95a.png)

# Couting Sort

 	static void Couting(int[] Valores) {
		int i, j, k;
		int[] Aux = new int[100];
		for(i = 0; i<Aux.Length; i++) {
			Aux[i] = 0;
		}
		for(i = 0; i<Valores.Length; i++) {
			Aux[Valores[i]]++;
		}

		for(i = 0, j = 0; j<Aux.Length; j++)
			for(k = Aux[j]; k>0; k--)
				Valores[i++] = j;
	}
Ordenação por contagem é um algorítimo de ordenação estável, baseado em armazenar os valores a serem ordenados em outro vetor auxíliar. Sua complexidade é
de O(N+K). Onde K é o tamanho do arranjo auxíliar.


