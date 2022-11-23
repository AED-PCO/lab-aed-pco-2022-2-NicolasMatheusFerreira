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
        Celula aux = inicio.proximo;
        int i = 1;
        while(aux!=null) {
            Console.WriteLine($"{i++}. Marca: {aux.carro.Marca} Modelo: {aux.carro.Modelo} Cor: {aux.carro.Cor} Km: {aux.carro.KmRodados} QtdPortas: {aux.carro.QtdPortas}");
            aux = aux.proximo;
        }      
    }
}