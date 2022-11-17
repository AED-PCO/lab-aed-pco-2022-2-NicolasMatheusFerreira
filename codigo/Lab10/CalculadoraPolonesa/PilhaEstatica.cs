using System;

class PilhaEstatica {

    private string[] expressao;
    private int i;
    public PilhaEstatica() {
        expressao = new string[100];
        i = 0;
    }
    
    public int Tam {
        get {
            return this.i;
        }

        set {
            this.i = value;
        }
    }

    public string[] Expressao {
        get {
            return this.expressao;
        }

        set {
            this.expressao = value;
        }
    }
    public void Push(string caracter) {
        if (i==Expressao.Length)
            Console.WriteLine("A pilha esta cheia");
        else {
            expressao[i] = caracter.ToString();
            i++;
        }
    }

    public string Pop() {
        string aux="";
        if (i==0)
            Console.WriteLine("A pilha esta vazia!");
        else {
            aux = expressao[i-1];
            i--;
        }
        return aux;
    }


    public void Listar() {
        if (Tam>0)
           for(int j = 0; j<i; j++) {
                Console.WriteLine(expressao[j]);
            }
        else Console.WriteLine("Pilha vazia!");
    }
}