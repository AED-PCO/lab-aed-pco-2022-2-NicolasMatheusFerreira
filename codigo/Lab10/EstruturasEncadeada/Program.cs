using System;

namespace PilhaEncadeada
{
    class Program
    {
        static void Main(string[] args)
        {
            Lista lista = new Lista();                                    
            lista.InserirInicio(new Automovel("Lamborghini", "Aventador", "Laranja", 0, 2));
            lista.InserirInicio(new Automovel("Ferrari", "Spider", "Vermelho", 0, 2));
            lista.Listar();
            
            
        }
    }
}
