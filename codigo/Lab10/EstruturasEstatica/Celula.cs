using System;

class Celula {
    public Automovel carro;
    public Celula proximo;    

    public Celula(Automovel carro) {
        this.carro = carro;
    }

    public Celula() {}
}