using System;

class Fila {

    public Celula inicio, ultimo;
    public Fila() {
        inicio = new Celula();
        ultimo = inicio;
    }

    public void Push(Automovel carro) {                               
        ultimo.proximo = new Celula(carro);
        ultimo = ultimo.proximo;
    }

    public Automovel Pop() {
        Automovel obj = null;
        if (inicio==ultimo) {
            Console.WriteLine("Fila esta vazia!");
        } else {
            Celula aux = inicio.proximo;
            inicio.proximo = inicio.proximo.proximo;
            obj = aux.carro;
            aux.proximo = null;
            aux = null;            
        }
        return obj;
    }
    public void Listar() {
        Celula aux = ultimo;
        while(aux.proximo!=null) {
                        Console.WriteLine(aux.carro.Marca+" "+aux.carro.Modelo+" "+aux.carro.Cor+" "+aux.carro.KmRodados+" "+aux.carro.QtdPortas);            
            aux = aux.proximo;                    
        }
        if (aux.carro!=null)
            Console.WriteLine(aux.carro.Marca+" "+aux.carro.Modelo+" "+aux.carro.Cor+" "+aux.carro.KmRodados+" "+aux.carro.QtdPortas);
    }
    
}