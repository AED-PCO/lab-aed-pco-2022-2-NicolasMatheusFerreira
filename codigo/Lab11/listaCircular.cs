using System;

namespace ListaCircular
{
    public class listaCircular
    {
        public Elemento primeiro;
        public Elemento atual;

        public listaCircular()
        {
            primeiro = new Elemento();
            primeiro.proximo = primeiro;
            primeiro.anterior = primeiro;
            atual = primeiro;
        }

        public bool isVazia()
        {
            return primeiro.proximo == primeiro ? true : false;
        }

        public void inserir(int nota, int pos = -1)
        {
            int cont = 1;
            Elemento novo = new Elemento();
            novo.aluno.nota = nota;
            if (isVazia())
            {
                primeiro.proximo = novo;
                atual = novo;
                novo.proximo = novo;
                novo.anterior = novo;
            }
            else
            {
                if (pos == -1)      //vai inserir no final da lista
                {
                    Elemento aux = primeiro.proximo;
                    while (aux.proximo != primeiro.proximo)
                    {
                        aux = aux.proximo;

                    }
                    atual = novo;
                    atual.proximo = primeiro.proximo;
                    novo.anterior = aux;
                    novo.proximo = primeiro.proximo;
                    aux.proximo = novo;
                    primeiro.proximo.anterior = atual;
                }
                else                //vai inserir em uma posição específica
                {

                    Elemento aux = primeiro.proximo;
                    while (cont < pos && aux != atual)
                    {
                        cont++;
                        aux = aux.proximo;

                    }
                    
                    if (aux == atual && cont < pos)
                    {
                        
                        atual = novo;
                        atual.proximo = primeiro.proximo;
                        novo.anterior = aux;
                        novo.proximo = primeiro.proximo;
                        aux.proximo = novo;
                        primeiro.proximo.anterior = atual;
                    }
                    else
                    {
                        
                        atual.proximo = primeiro.proximo;
                        novo.proximo = aux;
                        aux.anterior.proximo = novo;
                        aux.anterior = novo;
                        novo.anterior = aux.anterior;

                        if (primeiro.proximo == aux)
                        {

                            primeiro.proximo = novo;
                            primeiro.proximo.anterior = atual;
                        }
                    }
                        
                }

             }

        }
        public void retirar()
        {
            if (isVazia())
            {
                Console.WriteLine("Não há elementos na lista para serem retirados!");
            }
            else
            {
                Elemento aux = primeiro.proximo;
                Elemento auxRet;
                bool achou = false;
                
                Console.WriteLine($"\nElemento {atual.aluno.nota} retirado da lista com sucesso!");
                atual.anterior.proximo = primeiro.proximo;
                atual = atual.anterior;
                primeiro.proximo.anterior = atual;   
            }
        }
        public void imprimir()
        {
            Elemento dado = primeiro.proximo;
            Console.WriteLine("\nElementos da lista:");
            while (dado != atual)
            {
                Console.Write("\t" + dado.aluno.nota);
                dado = dado.proximo;
            }
            Console.Write("\t" + atual.aluno.nota);
        }