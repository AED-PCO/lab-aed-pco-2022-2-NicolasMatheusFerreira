class Elemento {

    private int valor;
    private Elemento esquerda, direita;

    public Elemento(int atual) {       
        esquerda = null;
        direita = null; 
        this.Valor = atual;
    }    

    public int Valor {
        set { this.valor = value; } 
        get {return this.valor; }
    }
    public Elemento Esquerda {
        get { return this.esquerda; }
        set { this.esquerda = value; }
    }
    public Elemento Direita {
        get { return this.direita; }
        set { this.direita = value; }
    }
}