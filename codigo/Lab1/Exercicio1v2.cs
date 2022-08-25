// See https://aka.ms/new-console-template for more information

static int Potencia(int valor, int expo) {
    int cont = 1;
    while(cont<expo) {
        valor*=valor;
        cont++;
    }
    return valor;
}

static void DivideValor(int valor, ref int a, ref int b) {
    a = valor % 100;
    b = valor / 100;
}

int valor, grupoA = 0, grupoB = 0;

for(int i = 1000; i<=9999; i++) {
    
    valor = i;
    DivideValor(valor, ref grupoA, ref grupoB);

    if (Potencia(grupoA+grupoB, 2)==valor)
        Console.WriteLine(valor);
}
