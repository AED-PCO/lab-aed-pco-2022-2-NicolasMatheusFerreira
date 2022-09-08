# Exercícios práticos referênte a aula de introdução da disciplina de (AED) algorítimos e estrutura de dados.

- Matéria: Recursividade
- Enunciado **(E.)** | Resposta **(R.)** | Saída **(S.)**

## Exercicio 01

- **(E.) Escreva um método recursivo que retorne o fatorial de um número.**
- **(R.)** Passando um valor para a função para cálcular o fatorial, o número é multiplicado pela chamada da própria função com o parametro diminuindo de 1, até que o caso base seja verdadeiro que é 2. Retornando o parametro para as demais chamadas das funções até a chamada de origem.
- **(S.)** 

## Exercicio 02

- **(E.) Uma multiplicação pode ser vista como uma sequência de somas. Escreva um método recursivo que realize a multiplicação de dois números inteiros, A e B, recebidos por parâmetro.**
- **(R.)** Ao ler dois valores reais para multiplicacão, esses valores são passados para uma função recursiva, e se a valor b-1, for igual a 1 retorna para as demais funções empilhadas o valor de a somando com o próprio a e retornando até a chamada inicial da função.
- **(S.)** 

## Exercicio 03

- **(E.)  Escreva um método recursivo que realize a potenciação entre dois números inteiros, A e B, recebidos por parâmetro. Seu método deve, portanto, retornar o resultado de A**
- **(R.)** Passando o expoente para a função rescursiva, se o expoente for igual a 1 retorna a base, senão chama novamente a própria função decrementando o expoente para que em uma nova instância da função o caso base seja verdadeiro e desempilhe a função multiplicando a base pelos retornos.
- **(S.)** 

## Exercicio 04

- **(E.) Escreva um método recursivo que receba uma frase e uma letra como parâmetros. Este método deve retornar a quantidade de ocorrências desta letra nesta frase.**
- **(R.)** A cada chamada da função, o caractere correspondente a posição atual do vetor é comparada com o caractere escolhido para contar, e se verdadeiro uma variável é icrementada, senão a variável continua como zero. Prosseguindo chama a própria função variándo a posição do vetor até que o caso  base seja verdadeiro que é a última posição do tamanho do vetor, retornando a quantidade de caracteres computados e retornando as somas até a chamada inicial da função.
- **(S.)** 

## Exercicio 05

- **(E.) Escreva um método recursivo que calcule a soma dos elementos de valor par de um vetor de números inteiros positivos.**
- **(R.)** A função soma par recebe um vetor e uma variável de posição e a cada instância da função o valor baseado na posição no vetor é comparado para descobrir se o valor contido no arranjo é par ou ímpar. E sendo par retorna calculando a soma dos N Pares.
- **(S.)** 

## Exercicio 06

- **(E.) Escreva um método recursivo que receba uma frase e retorne a mesma frase, sem nenhuma vogal.**
- **(R.)** A função Remove Vogal, recebe por parametros uma string ou arranjo de char e um pós, comparando a cada iteração se o caractere da instância atual é uma vogal utilizando um for() com um arranjo de "AEIOUaeiou". Se verdadeiro como vogal ele substitui o caractere por um espaço vazio retornando a string para a chamada da função.
- **(S.)** 

## Exercicio 07

- **(E.) Exercício: definição recursiva da série de Fibonacci**
- **(R.)** A série de fibonacci soma os termos N-1 = 0 e N-2 = 1 somando assim o termo atual mais o anterior para definir seu próximo termo. O algorítimo chama a função passando uma variável i se ela for igual a zero ou um retorna o valor 1, senão realiza a chamada da função de forma composta (ou seja realizando duas chamadas da função), passando como i-1 e i-2 e retornando o 1 a cada instância, assim demontrando a sequência fibonacci.
- **(S.)** 
