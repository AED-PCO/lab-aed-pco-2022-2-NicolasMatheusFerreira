using System;

namespace CalculadoraPolonesa
{
    class Program
    {
        static double Calculo(string expressao) {            
            PilhaEstatica operandos = new PilhaEstatica();

            int i = 0;
            double resultado = 0, parc1 = 0, parc2 = 0;
            while(i<expressao.Length) {                
                if (expressao[i]!='+' && expressao[i]!='-' && expressao[i]!='*' && expressao[i]!='/') {
                    operandos.Push(expressao[i].ToString());                    
                } else {                    
                    parc2 = double.Parse(operandos.Pop());
                    parc1 = double.Parse(operandos.Pop());                                                            
                    switch (expressao[i]) {
                        case '+':                            
                            resultado = parc1+parc2;
                        break;

                        case '-':
                            resultado = parc1-parc2;
                        break;

                        case '*':
                            resultado = parc1*parc2;
                        break;

                        case '/':
                            resultado = parc1/parc2;
                        break;                        
                    }                    
                    operandos.Push(resultado.ToString());                    
                }
                i = i + 1;
            }                                    
            return double.Parse(operandos.Pop());
        }

        static void NotacaoPosFixa(string expressao) {
            
            PilhaEstatica operadores = new PilhaEstatica();

            int i = 0;
            string saida = "";
            while(i<expressao.Length) {
                if (expressao[i]==')') {
                    while(operadores.Tam>1) {                                                                                                    
                            saida+=operadores.Pop();
                    }  
                } else if (expressao[i]!='+' && expressao[i]!='-' && expressao[i]!='*' && expressao[i]!='/' && expressao[i]!='(')                    
                        saida+= expressao[i];
                else {
                    if (expressao[i]!='(')
                        operadores.Push(expressao[i].ToString());
                }                
                i = i + 1;
            }            

            while(operadores.Tam>=1) {
                        saida+=operadores.Pop();
            }            
            Console.WriteLine(saida);            
            //return Calculo(saida);
        }
        static void Main(string[] args)
        {
            string entrada = Console.ReadLine();         
            NotacaoPosFixa(entrada);
        }
    }
}
