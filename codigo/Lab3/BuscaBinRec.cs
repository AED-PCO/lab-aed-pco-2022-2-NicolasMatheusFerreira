class BuscaBinRec {

	static int BuscaBinariaRec(int alvo, int[] Vetor, int inicio, int fim) {
		
			int meio = (inicio+fim)/2;
			if (inicio<=fim) {
				if (alvo==Vetor[meio]) {
					return meio;
				} else if (alvo<Vetor[meio]) {							
					return BuscaBinariaRec(alvo, Vetor, inicio, meio-1);
				} else if (alvo>Vetor[meio]) {						
					return BuscaBinariaRec(alvo, Vetor, meio+1, fim);
				}
			}
			return -1;
	}

	static void Main(string[] args) {
		
	}
}