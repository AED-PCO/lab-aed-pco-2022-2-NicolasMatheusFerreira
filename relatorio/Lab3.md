# Exercícios práticos referênte a aula de introdução da disciplina de (AED) algorítimos e estrutura de dados

- Matéria: Buscas e ordenação
- Enunciado **(E.)** | Resposta **(R.)** | Execução **(Exe.)**

## Exercicio 01 - Busca Binária

- **(E.) Faça um método recursivo para pesquisa binária sem utilizar o pós (Posição).**
- **(R.)** O método recusivo para pesquisa binária, consiste em chamar a função passando para ela um arranjo, 
um valor chave para a pesquisa, mais dois valores de inicio e final do vetor. A cada instância da 
chamada recursiva uma variável criada chamada de meio cálcula se o valor do meio do conjunto de valores já ordenados contidas 
no vetor é maior ou menor o valor chave. Se for menor que o valor chave o fim do vetor é a partir disso chave valores -1.
Se for maior que o valor chave o início do conjunto passa a ser chave + 1 e assim o programa realiza as chamadas recursivas partindo o arranjo ao meio a cada vez que é executado o algorítimo, até que reste apenas um elemento no vetor ou nenhum, retornando o valor resultante para chamada de origem.
Complexidade
Melhor Caso O(1)
Pior e Caso médio O (Log N)

- **(Exe.)**

| Entrada | Saída |
  |--- |--- |
  | row 1 | column 2 |
  
![Captura de tela de 2022-09-13 22-30-04](https://user-images.githubusercontent.com/71523671/190038777-23191c3d-669c-4472-8fcc-d77eba0d0cbd.png)

![Captura de tela de 2022-09-13 22-31-22](https://user-images.githubusercontent.com/71523671/190038802-572a42b5-74b1-4fb9-b457-c4ab38e0a847.png)

## Exercicio 02

- **(E.) Faça um método recursivo para ordenação binária sem utlizar a pós (Posição).**
- **(R.)**
- **(S.)**
