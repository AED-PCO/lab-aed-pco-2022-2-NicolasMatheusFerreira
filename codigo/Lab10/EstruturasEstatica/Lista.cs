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

    }

    public void Inserir() {

    }
/*
    public Automovel RemoverInicio() {                
    }

    public Automovel RemoverFim() {

    }

    public Automovel Remover() {

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