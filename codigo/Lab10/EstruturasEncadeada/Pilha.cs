using System;

class Pilha {

    public Celula inicio;
    public Pilha() {
        inicio = null;
    }

    // Push, Pop e listar

    public void Push(Automovel carro) {

        Celula aux = new Celula(carro);
        aux.proximo = inicio;
        inicio = aux;
        aux = null;
    }

    public void Listar() {
        Celula aux = inicio;        
        while(aux.proximo!=null) {            
            Console.WriteLine(aux.carro.Marca+" "+aux.carro.Modelo+" "+aux.carro.Cor+" "+aux.carro.KmRodados+" "+aux.carro.QtdPortas);
            aux = aux.proximo;
        }        
        if (aux.carro!=null)
            Console.WriteLine(aux.carro.Marca+" "+aux.carro.Modelo+" "+aux.carro.Cor+" "+aux.carro.KmRodados+" "+aux.carro.QtdPortas);
    }

    public Automovel Pop() {
        Automovel obj = null;
        Celula aux = inicio;
        if (inicio.proximo!=null) {
            inicio = inicio.proximo;    
            obj = aux.carro;
            aux.proximo = null;
            aux = null;
        } else if (inicio.carro!=null) {
            obj = inicio.carro;
            inicio.carro = null;
        } else Console.WriteLine("Pilha esta vazia");
        
        return obj;
    }
}