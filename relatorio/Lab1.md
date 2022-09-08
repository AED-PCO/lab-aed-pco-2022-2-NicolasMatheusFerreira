# Exercícios práticos referênte a aula de introdução da disciplina de (AED) algorítimos e estrutura de dados.

- Matéria: Nivelamento (Lógica de programação)
- Enunciado **(E.)** | Resposta **(R.)** | Saída **(S.)**

## Exercicio 01.
- **(E.) Alguns números de quatro algarismos possuem uma característica particular. Se separamos 
esse número em dois grupos e os somarmos encontramos um outro número cujo quadrado 
é exatamente igual ao número fornecido anteriormente. Veja o exemplo:
Número = 3025 
Separando o número em dois grupos de dois algarismos temos o 30 e o 25 . 
A soma de 30 com 25 é igual a 55
O Quadrado de 55 é igual a 3025. Faça um programa que mostre os números de 1000 a 9999 que possuem essa característica.**
- **(R.)** Nesse primeiro exercício, transformei o número inteiro em uma cadeia de caracteres e dividindo a em duas strings. Assim depois de divididas transformei novamente ambos em inteiro realizei a adição e elevei ao quadrado comparando se o número possui ou não a característica em perticular.
- **(S.)**

	| Input | Output |
	|--- |--- |
	| row 1 | column 2 |

## Exercicio 02.
- **(E.) Um Número é dito Primo se possui como divisores o número 1 e ele mesmo. Em outras 
palavras, um Número Primo possui dois divisores de 1 até ele.
Faça um programa que mostre se um determinado número inteiro, lido pelo teclado, é 
Primo.
Um Número é dito Perfeito se a soma de seus divisores menores que ele é igual a ele. Por 
exemplo, o número 6 possui os  divisores 1, 2 e 3, cuja soma é igual a 6.
Faça um programa que liste os números perfeitos de 1 a 1000.**
- **(R.)** (Primo) - Variei entre o número dois até o próprio testando seus múltiplos, e caso tenha dois multiplos significa que são primos assim validando com teste lógico se são primos e exibindo na tela.
	(Perfeito) - Variei em uma estrutura de repetição (looping) de 1 até menor que o número e fui validando seus múltiplos e somando assim ao final testando se é um número perfeito, e caso fosse mostrando na tela.
- **(S.)** 

	| Input | Output |
	|--- |--- |
	| row 1 | column 2 |

## Exercicio 03.
- **(E.) Faça um programa que receba os elementos de dois vetores, A e B, cada um com 5 posições. 
Considere que nenhum dos vetores possui elementos repetidos.
Crie um vetor resultante C que possua os elementos comuns entre A e B.
Crie um vetor resultante D que contenha os elementos de A que não existam em B.**
- **(R.)** 
- **(S.)** 
	
	| Input | Output |
	|--- |--- |
	| row 1 | column 2 |

## Exercicio 04.
- **(E.) Faça um programa que receba os elementos de uma matriz de 5 linhas por 3 colunas. 
Mostre a soma dos elementos de cada uma das linhas e das colunas da matriz.**
- **(R.)** Ao realizar a leitura da matriz somei os valores em uma variável e fui exibindo a medida que foi alternando de linhas.
- **(S.)** 

	| Input | Output |
	|--- |--- |
	| row 1 | column 2 |

## Exercicio 05.
- **(E.) Faça um programa que chame uma função capaz de calcular o Fatorial de um número inteiro.**
- **(R.)** A função fat recebe como parâmetro uma variáve inteira x, e varia em um looping de x até a zero, logo multiplicando por seu x*x-1.
- **(S.)** 

	| Input | Output |
	|--- |--- |
	| row 1 | column 2 |

## Exercicio 06.
- **(E.) Faça um programa que chame uma função capaz de calcular x^y, sendo x e y inteiros. Utilize passagem de parâmetros de referência.**
- **(R.)** A função potencia() recebe a base e o expoente como parâmetro e o expoente variá entre n a zero, multiplicando a base * base, assim retornando o valor contido em base da função.
- **(S.)** 

	| Input | Output |
	|--- |--- |
	| row 1 | column 2 |
