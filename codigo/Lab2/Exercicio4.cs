// Ocorrencia de caracteres em uma frase

static int Ocorrencia(string frase, char caractere, int i) {

    int cont;
    if (i==1) {
        return i;
    } else {
         cont = Ocorrencia(frase, caractere, --i);
        Console.WriteLine(cont);
         return cont;
    }
}

    string frase;
    char caractere;

    Console.Write("Informe uma frase: ");
    frase = Console.ReadLine();
    Console.Write("Informe um caractere: ");
    caractere = Console.ReadKey().KeyChar;
    Console.WriteLine($"Existem {Ocorrencia(frase, caractere, frase.Length)} do caractere {caractere} na frase.");
