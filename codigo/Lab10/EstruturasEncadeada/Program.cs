using System;

namespace PilhaEncadeada
{
    class Program
    {
        static Automovel Entrada() {

            Automovel obj = new Automovel();
            Console.Write("Marca: ");
            obj.Marca = Console.ReadLine();
            Console.Write("Modelo: ");
            obj.Modelo = Console.ReadLine();
            Console.Write("Cor: ");
            obj.Cor = Console.ReadLine();
            Console.Write("Km Rodados: ");
            obj.KmRodados = double.Parse(Console.ReadLine());
            Console.Write("Qtd. Portas: ");
            obj.QtdPortas = int.Parse(Console.ReadLine());
            return obj;
        }
        static void Main(string[] args)
        {
            Fila fila = new Fila();
            Pilha pilha = new Pilha();
            Lista lista = new Lista();
            int op;

            do {
                Console.WriteLine("[1]. Lista | [2]. Pilha | [3]. Fila");
                Console.Write("Opcao: ");
                op = int.Parse(Console.ReadLine());

                do {
                    Console.Clear();
                    switch (op) {
                        case 1:
                            Console.WriteLine("[1] Inserir no inicio | [2] Inserir no final | [3] Inserir");
                            Console.WriteLine("[4] Remover no inicio | [5] Remover no final | [6] Remover");
                            Console.Write("Opcao: ");
                            op = int.Parse(Console.ReadLine());

                            if (op==1) {
                                lista.InserirInicio(Entrada());                       
                                lista.Listar();
                            } else if (op==2) {
                                lista.InserirFim(Entrada());                       
                                lista.Listar();
                            } else if (op==3) {
                                lista.Inserir(Entrada(), 2);                       
                                lista.Listar();
                            } else if (op==4) {
                                lista.RemoverInicio();
                                lista.Listar();
                            } else if (op==5) {
                                lista.RemoverFinal();
                                lista.Listar();
                            } else Console.WriteLine("Opcao invalida!");
                        break;

                        case 2:
                            Console.WriteLine("[1] Inserir | [2] Remover");
                            Console.Write("Opcao: ");
                            op = int.Parse(Console.ReadLine());

                            if (op==1) {
                                pilha.Push(Entrada());
                                pilha.Listar();
                            } else if (op==2) {
                                pilha.Pop();
                                pilha.Listar();
                            } else Console.WriteLine("Opcao invalida!");
                        break;

                        case 3:
                            Console.WriteLine("[1] Inserir | [2] Remover");
                            Console.Write("Opcao: ");
                            op = int.Parse(Console.ReadLine());

                            if (op==1) {
                                fila.Push(Entrada());
                                fila.Listar();
                            } else if (op==2) {
                                fila.Pop();
                                fila.Listar();
                            } else Console.WriteLine("Opcao invalida!");
                        break;
                    }
                    op = 1;
                } while(op<1 || op>3);
            } while(op>=1 && op<=3);     
        }
    }
}