class Automovel {

    public Automovel() {}
    public Automovel(string a, string b, string c, double d, int e) {
        Marca = a;
        Modelo = b;
        Cor = c;
        KmRodados = d;
        QtdPortas = e;
    }

    private string marca, modelo, cor;
    private double kmRodados;
    private int qtdPortas;

    public string Marca {
        get {
            return this.marca;
        }

        set {
            this.marca = value;
        }
    }    

    public string Modelo {
        get {
            return this.modelo;
        }

        set {
            this.modelo = value;
        }
    }

    public string Cor {
        get {
            return this.cor;
        }

        set {
            this.cor = value;
        }
    }

    public double KmRodados {
        get {
            return this.kmRodados;
        }

        set {
            this.kmRodados = value;
        }
    }

    public int QtdPortas {
        get {
            return this.qtdPortas;
        }

        set {
            this.qtdPortas = value;
        }
    }
}