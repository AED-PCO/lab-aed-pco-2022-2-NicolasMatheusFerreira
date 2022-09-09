# Exercícios práticos referênte a aula de introdução da disciplina de (AED) algorítimos e estrutura de dados

- Matéria: Recursividade
- Enunciado **(E.)** | Resposta **(R.)** | Execução **(Exe.)**

## Exercicio 01

- **(E.) Escreva um método recursivo que retorne o fatorial de um número.**
- **(R.)** Passando um valor para a função para cálcular o fatorial, o número é multiplicado pela chamada da própria função com o parametro diminuindo de 1, até que o caso base seja verdadeiro que é 2. Retornando o parametro para as demais chamadas das funções até a chamada de origem.
- **(Exe.)**

  | Entrada | Saída |
  |--- |--- |
  | row 1 | column 2 |
  
  ![exe1](https://user-images.githubusercontent.com/71523671/189456772-73611dcb-a63b-42d4-a4a5-c62cbd1071d8.png)

## Exercicio 02

- **(E.) Uma multiplicação pode ser vista como uma sequência de somas. Escreva um método recursivo que realize a multiplicação de dois números inteiros, A e B, recebidos por parâmetro.**
- **(R.)** Ao ler dois valores reais para multiplicacão, esses valores são passados para uma função recursiva, e se a valor b-1, for igual a 1 retorna para as demais funções empilhadas o valor de a somando com o próprio a e retornando até a chamada inicial da função.
- **(Exe.)**

  | Entrada | Saída |
  |--- |--- |
  | row 1 | column 2 |
  
  ![exe2](https://user-images.githubusercontent.com/71523671/189456774-755caebc-9216-4a22-b057-193122f59049.png)
  
## Exercicio 03

- **(E.)  Escreva um método recursivo que realize a potenciação entre dois números inteiros, A e B, recebidos por parâmetro. Seu método deve, portanto, retornar o resultado de A**
- **(R.)** Passando o expoente para a função rescursiva, se o expoente for igual a 1 retorna a base, senão chama novamente a própria função decrementando o expoente para que em uma nova instância da função o caso base seja verdadeiro e desempilhe a função multiplicando a base pelos retornos.
- **(Exe.)**

  | Entrada | Saída |
  |--- |--- |
  | row 1 | column 2 |
  
  ![exe3](https://user-images.githubusercontent.com/71523671/189456776-9f8a7a39-5a3f-4454-b073-cd6b9d10fab7.png)
  
## Exercicio 04

- **(E.) Escreva um método recursivo que receba uma frase e uma letra como parâmetros. Este método deve retornar a quantidade de ocorrências desta letra nesta frase.**
- **(R.)** A cada chamada da função, o caractere correspondente a posição atual do vetor é comparada com o caractere escolhido para contar, e se verdadeiro uma variável é icrementada, senão a variável continua como zero. Prosseguindo chama a própria função variándo a posição do vetor até que o caso  base seja verdadeiro que é a última posição do tamanho do vetor, retornando a quantidade de caracteres computados e retornando as somas até a chamada inicial da função.
- **(Exe.)**

  | Entrada | Saída |
  |--- |--- |
  | row 1 | column 2 |

![exe4](https://user-images.githubusercontent.com/71523671/189456777-e0658f06-38e8-44a1-9362-2f11fde29bfb.png)

## Exercicio 05

- **(E.) Escreva um método recursivo que calcule a soma dos elementos de valor par de um vetor de números inteiros positivos.**
- **(R.)** A função soma par recebe um vetor e uma variável de posição e a cada instância da função o valor baseado na posição no vetor é comparado para descobrir se o valor contido no arranjo é par ou ímpar. E sendo par retorna calculando a soma dos N Pares.
- **(Exe.)**

  | Entrada | Saída |
  |--- |--- |
  | row 1 | column 2 |

![exe5](https://user-images.githubusercontent.com/71523671/189456767-f30a924b-7751-443b-83d6-48bd20ee2e4a.png)

## Exercicio 06

- **(E.) Escreva um método recursivo que receba uma frase e retorne a mesma frase, sem nenhuma vogal.**
- **(R.)** A função Remove Vogal, recebe por parametros uma string ou arranjo de char e um pós, comparando a cada iteração se o caractere da instância atual é uma vogal utilizando um for() com um arranjo de "AEIOUaeiou". Se verdadeiro como vogal ele substitui o caractere por um espaço vazio retornando a string para a chamada da função.
- **(Exe.)**

  | Entrada | Saída |
  |--- |--- |
  | row 1 | column 2 |

![exe6](https://user-images.githubusercontent.com/71523671/189456769-b68a6c89-2f7d-4656-8d54-45fffed186e1.png)

## Exercicio 07

- **(E.) Exercício: definição recursiva da série de Fibonacci**
- **(R.)** A série de fibonacci soma os termos N-1 = 0 e N-2 = 1 somando assim o termo atual mais o anterior para definir seu próximo termo. O algorítimo chama a função passando uma variável i se ela for igual a zero ou um retorna o valor 1, senão realiza a chamada da função de forma composta (ou seja realizando duas chamadas da função), passando como i-1 e i-2 e retornando o 1 a cada instância, assim demontrando a sequência fibonacci.
- **(Exe.)**

  | Entrada | Saída |
  |--- |--- |
  | row 1 | column 2 |

![exe7](https://user-images.githubusercontent.com/71523671/189457038-20c61197-4b3d-45d4-8462-85b4a0462faa.png)
