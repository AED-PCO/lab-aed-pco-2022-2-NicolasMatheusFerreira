// Potenciação recursiva

static double PotenciaRec(double a, int expo) {

    if (expo==1)
        return a;
    else return a*PotenciaRec(a,--expo);
}

double a;
int expo;

Console.WriteLine("Potenciação recursiva.");
Console.Write("Informe um valor para base: ");
a = double.Parse(Console.ReadLine());
Console.Write("Informe um valor para expoente: ");
expo = int.Parse(Console.ReadLine());

double result = PotenciaRec(a, expo);
Console.WriteLine($"A potencia entre {a} e {expo} e igual a {result}");
