using System;
class Lista {

    Celula inicio, ultimo;
    public Lista() {
        inicio = new Celula();                
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
    public int Tamanho() {
         int tam = 0;
        Celula aux = inicio;
        while(aux != null){
            tam++;
            aux = aux.proximo;
        }
        return tam;
    }
    public void Inserir(Automovel carro, int pos) {
        
        if (pos>=0 && pos<=Tamanho()) {
            Celula aux = inicio;
            int i = 0;
            while(i<pos) {
                aux = aux.proximo;
            }
            Celula aux2 = new Celula(carro);
            aux2.proximo = aux.proximo;
            aux.proximo = aux2;
            aux = null;
            aux2 = null;           
        } else Console.WriteLine("Posicao invalida!");
    }

     public Automovel Remover(int pos){
        if(pos<0){
            Console.WriteLine("O elemento não existe na lista.");
            return null;
        } else{
            Celula aux = inicio;
            int i = 0;
            while(i<pos) {
                aux = aux.proximo;
                i++;
            }
            Celula aux2 = aux.proximo; 
            Automovel elemento = aux2.carro;
            aux.proximo = aux2.proximo;
            aux2.proximo = null;
            aux = null;
            aux2 = null;
            return elemento;
        }  
    }
    public void Listar() {
        Celula aux = ultimo.proximo;
        int i = 1;
        while(aux!=null) {
            Console.WriteLine($"{i++}. Marca: {aux.carro.Marca} Modelo: {aux.carro.Modelo} Cor: {aux.carro.Cor} Km: {aux.carro.KmRodados} QtdPortas: {aux.carro.QtdPortas}");
            aux = aux.proximo;
        }                        
    }
}