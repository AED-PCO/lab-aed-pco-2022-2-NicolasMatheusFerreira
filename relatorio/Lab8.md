# Exercícios práticos referênte a aula de introdução da disciplina de (AED) algorítimos e estrutura de dados

- Matéria: Análise de complexidade algorítimica
- Enunciado **(E.)** | Resposta **(R.)** | Execução **(Exe.)**

# Correção da prova de AED.

## Exercicio 01

R.
Criar método para ler o arquivo e armazenar em um vetor qualquer, criar outro vetor e ler pelo console e comparar 
cada string com o vetor referênte arquivo.
(Exe.)

## Exercicio 02

R.
Quando você passa para a função funcRec1() o passo de 6, a função tende
se afastar cada vez mais do caso base, assim estourando a pilha de instruções.
Porém se o passo for <=1 contando com a expressão "a-2+5" o resultado é igual
a zero.

(Exe.)

## Exercicio 03

R.
Criar uma função para realizar a leitura do arquivo, e salvar em uma variável a string. Depois 
criar um outro método para inverter a palavra e por fim passar novamente para uma nova função a
palavra para escrever em um outro arquivo de saída.

Complexidade: O(N) // Por que é necessário percorrer todo o vetor de trás para frente atribuindo cada caractere.

As operações relevantes são somas e atribuições.

(Exe.)

## Exercicio 04

a. Não. Pois o algorítimo insertion sort tanto no melhor e pior caso ambos são de O(n²);
b. Merge sort.
c. Atribuição, divisão e comparações.

{56, 32, 12, 6, 3, 66, 43, 21, 11, 6}
{56, 32, 12, 6, 3} {66, 43, 21, 11, 6}
{56, 32, 12} {6, 3} {66, 43, 21} {11, 6}
{12, 32, 56} {3, 6} {21, 43, 66} {6, 11}
{12, 32, 56, 3, 6} {21, 43, 66, 6, 11}
{3, 6, 12, 32, 56} {6, 11, 21, 43, 66}
{3, 6, 12, 32, 56, 6, 11, 21, 43, 66}
{3, 6, 6, 11, 12, 21, 32, 43, 56, 66}

(Exe.)

## Exercicio 05

R.
O algorítimo funcao() Vai começar empilhando na chamada da função o 6 elemento do vetor e a cada nova instância chama a própria função novamente até que chegue
no caso base. Logo após chegar ao caso base retorna um valor desencadeando as
demais operações até a chamada do método inicial.

(Exe.)
