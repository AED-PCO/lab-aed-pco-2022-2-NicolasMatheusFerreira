// See https://aka.ms/new-console-template for more information
static int Fatorial(int num) {

    int result;
    if (num==2)
        return num;
    else result = num*Fatorial(num-1);
    return result;
}

int valor;
Console.Write("Informe valor para fatorial: ");
valor = int.Parse(Console.ReadLine());
Console.WriteLine($"O fatorial de {valor} e igual a {Fatorial(valor)}");
Console.WriteLine("Fim do programa!");