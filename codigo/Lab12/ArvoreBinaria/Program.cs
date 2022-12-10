using System;

namespace ArvoreBinaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Arvore arvore = new Arvore();

            int no;
            while(true) {
                Console.Write("Informe no: ");
                no = int.Parse(Console.ReadLine());
                if (no>=0)
                    arvore.Inserir(no);
                else break;
            }

            Console.WriteLine("Arvore BB em ordem...");
            arvore.InOrdem(arvore.Raiz);
            Console.WriteLine();

            Console.WriteLine("Arvore BB em pré-ordem...");
            arvore.PreOrdem(arvore.Raiz);

            Console.WriteLine();
            Console.WriteLine("Arvore BB em pós-ordem...");            
            arvore.PosOrdem(arvore.Raiz);

            Console.WriteLine();
            Console.WriteLine(arvore.Search(5));
        }
    }
}
