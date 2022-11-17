using System;

class Lista {

    Celula primeiro, ultimo;
    public Lista() {
        primeiro = new Celula();
        ultimo = primeiro;
    }

    public void InserirInicio(Automovel carro) {
        Celula aux = new Celula(carro);
        aux.proximo = primeiro.proximo;
        primeiro.proximo = aux;
        if (primeiro==ultimo) {
            ultimo = aux;
        }
        primeiro = ultimo;
        aux = null;
    }

    public void InserirFim() {
	Automovel elemento;
	if (inicio==fim)
		Console.WriteLine("Erro!");
	else {
		Celula aux;
		for(aux = inicio; aux.prox!=fim; aux = aux.prox);
		elemento = fim.carro;
		fim = aux;
		aux = fim.prox = null;
	}
	return elemento;
    }

    public void Inserir(int pos, Automovel carro) {
	if (pos<0 || pos>tam) {
		Console.WriteLine("Erro");
	} else if (pos==0) {
		InserirInicio(carro);
	} else if (pos==tam) {
		InserirFim(carro);
	} else {
		Celula aux = inicio;
		for(int j=0; j<pos; j++, aux = aux.prox);
		Celula tmp = new Celula(carro);
		tmp.prox = aux.prox;
		aux.prox = tmp;
		tmp = null;
		aux = null;
	}
    }
/*
    public Automovel RemoverInicio() {                
    }

    public Automovel RemoverFim() {
	Automovel elemento;
	if (inicio==fim)
		Console.WriteLine("Erro!");
	else {
		Celula aux;
		for(aux = inicio; aux.prox!=fim; aux = aux.prox);
		elemento = fim.carro;
		fim = aux;
		aux = fim.prox = null;
	}
	return elemento;	
    }

    public Automovel Remover() {
	int tam;
	Automovel elemento;
		if (pos<0 || pos>tam) {
		Console.WriteLine("Erro");
	} else if (pos==0) {
		RemoverInicio(carro);
	} else if (pos==tam-1	) {
		RemoverFim(carro);
	} else {
		Celula aux = inicio;
		for(int j=0; j<pos; j++, aux = aux.prox);
		Celula tmp = aux.prox;
		elemento = tmp.elemento;
		tmp.prox = null;
		aux.prox = tmp.prox;
	}
    }
*/
    public void Listar() {
        Celula aux = primeiro;
        while(aux.proximo!=null) {
            Console.WriteLine(aux.carro.Marca+" "+aux.carro.Modelo+" "+aux.carro.Cor+" "+aux.carro.KmRodados+" "+aux.carro.QtdPortas);            
            aux = aux.proximo;
        }
        Console.WriteLine(aux.carro.Marca+" "+aux.carro.Modelo+" "+aux.carro.Cor+" "+aux.carro.KmRodados+" "+aux.carro.QtdPortas);            
    }
}