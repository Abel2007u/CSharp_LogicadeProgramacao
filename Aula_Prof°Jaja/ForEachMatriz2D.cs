using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercLPAulasJaja
{
    internal class ForEachMatriz2D
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Revendo Foreach na Matriz \n");

            int[,] numbers = { { 2, 5, 7 }, { 3, 4, 8 } };

            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }

            //Revimos essa parte

            //Lista passada durante a aula
            /*Exercícios para Fixação de Conteúdo: Arrays
                Assuntos Abordados: Array, Loop Through an Array, Sort Arrays, Multidimensional Arrays.
                    Exercício 1: Criando e Exibindo seu Primeiro Array
                    Crie um array chamado frutas que contenha os seguintes elementos (strings): "Maçã", "Banana", "Laranja", "Uva", "Abacaxi".
                    Utilize um loop para percorrer este array e exibir cada fruta em uma linha separada no console.


                    Exercício 2: Calculando a Soma de Elementos Numéricos
                    Crie um array chamado numeros com os seguintes valores inteiros: [10, 25, 30, 5, 15, 20].
                    Utilize um loop para calcular a soma de todos os elementos deste array.
                    Exiba o resultado da soma no console.
                    
                    Exercício 3: Encontrando o Maior Valor em um Array
                    Reutilize o array numeros do Exercício 2.
                    Utilize um loop para encontrar o maior valor presente no array.
                    Exiba o maior valor encontrado no console.
                    
                    Exercício 4: Invertendo a Ordem dos Elementos
                    Crie um array chamado letras com as seguintes letras (strings): "A", "B", "C", "D", "E".
                    Utilize um loop para percorrer este array e exibir os elementos na ordem inversa (ou seja, "E", "D", "C", "B", "A").
                    
                    Exercício 5: Ordenando Números em Ordem Crescente
                    Crie um array chamado desordenados com os seguintes valores inteiros: [45, 12, 78, 3, 90, 21].
                    Utilize uma função ou método de ordenação (presente na maioria das linguagens de programação) para ordenar este array em ordem crescente.
                    Exiba o array ordenado no console.
                    
                    Exercício 6: Ordenando Nomes em Ordem Alfabética
                    Crie um array chamado nomes com os seguintes nomes (strings): "Carlos", "Ana", "Bruno", "Daniela", "Eduardo".
                    Utilize uma função ou método de ordenação para ordenar este array em ordem alfabética.
                    Exiba o array ordenado no console.
                    
                    Exercício 7: Acessando Elementos em um Array Multidimensional (Matriz Simples)
                    Crie um array bidimensional (matriz) chamado grid que represente o seguinte layout:
                    Plain Text
                    [[1, 2, 3],
                     [4, 5, 6],
                     [7, 8, 9]]
                    Acesse e exiba o elemento que está na segunda linha e terceira coluna (neste caso, o número 6).
                    Acesse e exiba o elemento que está na primeira linha e primeira coluna (neste caso, o número 1).
                    
                    Exercício 8: Percorrendo um Array Multidimensional com Loops Aninhados
                    Reutilize o array grid do Exercício 7.
                    Utilize loops aninhados (um loop dentro do outro) para percorrer todos os elementos da matriz grid e exibi-los no console, um por um.Dica: Você pode exibir cada linha em uma nova linha no console para melhor visualização.
                    
                    Exercício 9: Soma de Linhas em um Array Multidimensional
                    Crie um array bidimensional matrizNumerica com os seguintes valores:
                    Plain Text
                    [[10, 20, 30],
                     [5, 15, 25],
                     [40, 50, 60]]


                    Para cada linha da matriz, calcule a soma dos seus elementos.
                    Exiba a soma de cada linha no console (por exemplo: "Soma da Linha 0: X", "Soma da Linha 1: Y", etc.).
                    
                    Exercício 10: Buscando um Elemento em um Array Multidimensional
                    Reutilize o array grid do Exercício 7.
                    Peça ao usuário para digitar um número que ele deseja buscar na matriz (ou defina um número para buscar, por exemplo, o número 5).
                    Utilize loops aninhados para percorrer a matriz e verificar se o número buscado existe.
                    Se o número for encontrado, exiba uma mensagem indicando que o número foi encontrado e sua posição (índice da linha e da coluna). Se não for encontrado, exiba uma mensagem informando isso.*/
        }
    }
}
