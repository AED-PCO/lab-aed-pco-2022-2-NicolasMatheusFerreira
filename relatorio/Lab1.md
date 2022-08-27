# Exercícios práticos referênte a aula de introdução da disciplina de (AED) algorítimos e estrutura de dados.

- Matéria: Nivelamento (Lógica de programação)
- Enunciado **(E.)** | Resposta **(R.)** | Saída **(S.)**

## Exercicio 01.
- **(E.)** Alguns números de quatro algarismos possuem uma característica particular. Se separamos 
esse número em dois grupos e os somarmos encontramos um outro número cujo quadrado 
é exatamente igual ao número fornecido anteriormente. Veja o exemplo:
Número = 3025 
Separando o número em dois grupos de dois algarismos temos o 30 e o 25 . 
A soma de 30 com 25 é igual a 55
O Quadrado de 55 é igual a 3025. Faça um programa que mostre os números de 1000 a 9999 que possuem essa característica.
- **(R.)** Nesse primeiro exercício, transformei o número inteiro em uma cadeia de caracteres e dividindo a em duas strings. Assim depois de divididas transformei novamente ambos em inteiro realizei a adição e elevei ao quadrado comparando se o número possui ou não a característica em perticular.
- **(S.)** 
![exer1](https://user-images.githubusercontent.com/71523671/187045270-4bc9bfb8-e2a9-4442-8aef-5e367d8ac4f4.png)
## Exercicio 02.
- **(E.)** Um Número é dito Primo se possui como divisores o número 1 e ele mesmo. Em outras 
palavras, um Número Primo possui dois divisores de 1 até ele.
Faça um programa que mostre se um determinado número inteiro, lido pelo teclado, é 
Primo.
Um Número é dito Perfeito se a soma de seus divisores menores que ele é igual a ele. Por 
exemplo, o número 6 possui os  divisores 1, 2 e 3, cuja soma é igual a 6.
Faça um programa que liste os números perfeitos de 1 a 1000.
- **(R.)** (Primo) - Variei entre o número dois até o próprio testando seus múltiplos, e caso tenha dois multiplos significa que são primos assim validando com teste lógico se são primos e exibindo na tela.
	(Perfeito) - Variei em uma estrutura de repetição (looping) de 1 até menor que o número e fui validando seus múltiplos e somando assim ao final testando se é um número perfeito, e caso fosse mostrando na tela.
- **(S.)** 


## Exercicio 03.
- **(E.)** Faça um programa que receba os elementos de dois vetores, A e B, cada um com 5 posições. 
Considere que nenhum dos vetores possui elementos repetidos.
Crie um vetor resultante C que possua os elementos comuns entre A e B.
Crie um vetor resultante D que contenha os elementos de A que não existam em B.
- **(R.)** 
- **(S.)**
![exer2](https://user-images.githubusercontent.com/71523671/187045315-b92208ed-2b99-400e-8548-7f9b73852917.png)

## Exercicio 04.
- **(E.)** Faça um programa que receba os elementos de uma matriz de 5 linhas por 3 colunas. 
Mostre a soma dos elementos de cada uma das linhas e das colunas da matriz.
- **(R.)** Ao realizar a leitura da matriz somei os valores em uma variável e fui exibindo a medida que foi alternando de linhas.
- **(S.)** 
![exer3](https://user-images.githubusercontent.com/71523671/187045351-e5d6aaae-fda2-465d-9b4d-54aceb22f886.png)

## Exercicio 05.
- **(E.)** Faça um programa que chame uma função capaz de calcular o Fatorial de um número inteiro.
- **(R.)** Variei em um looping até o número e fui multiplicando a base pelo variável auxíliar que varia.
- **(S.)**
![exer4](https://user-images.githubusercontent.com/71523671/187045366-86b9c43c-6bd4-4dad-8f9c-1b67090015da.png)
## Exercicio 06.
- **(E.)** Faça um programa que chame uma função capaz de calcular x^y, sendo x e y inteiros. Utilize passagem de parâmetros de referência.
- **(R.)** 
	Ao ler a base e expoente passo para minha função ambos valores, assim iteragindo a quantidade de meu expoente e multiplicando a base por si próprio n (expoente) vezes.
- **(S.)**
![exer5](https://user-images.githubusercontent.com/71523671/187045383-fe665e33-e4eb-42c2-962b-91c080560ac1.png) 
