using System;
class Lista {

    Celula inicio, ultimo;
    public Lista() {
        inicio = null;                
        ultimo = inicio;
    }

    public void InserirInicio(Automovel carro) {        
        Celula aux = new Celula(carro);        
        aux.proximo = inicio;
        inicio = aux;
        aux = null;
    }

    public void InserirFim(Automovel carro) {                        
        Celula i = new Celula(carro);
        i.proximo = null;
        if (inicio==null)
            inicio = i;
        else {
            Celula aux = inicio;
            while(aux.proximo!=null) {
                aux = aux.proximo;
            }
            aux.proximo = i;            
            aux = null;        
        }
        i = null;        
    }

    public void RemoverInicio() {
        if (inicio==null)
            Console.WriteLine("Lista vazia!");
        else {
            inicio = inicio.proximo;            
        }
    }

    public void RemoverFinal() {
        if (inicio==null)
            Console.WriteLine("Lista vazia!");
        else {
            Celula aux = inicio;
            while(aux.proximo.proximo!=null) {
                aux = aux.proximo;
            }            
            aux.proximo = null;
        }    
    }

    public void Inserir(Automovel carro, int pos) {
        Celula aux = inicio;
        Celula tmj = new Celula(carro);
        tmj.proximo = null;

        int i = 1;
        while(i<=pos && aux!=null) {
            aux = aux.proximo;         
        }        
    }
    public void Listar() {
        Celula aux = inicio;
        int i = 1;
        while(aux!=null) {
            Console.WriteLine($"{i++}. Marca: {aux.carro.Marca} Modelo: {aux.carro.Modelo} Cor: {aux.carro.Cor} Km: {aux.carro.KmRodados} QtdPortas: {aux.carro.QtdPortas}");
            aux = aux.proximo;
        }                        
    }
}