using UnityEngine;
/* Array é uma estrutura de dados que armazena uma coleção de elementos
do mesmo tipo. Em C#, os arrays são objetos que possuem um tamanho
fixo e são indexados a partir de zero. Isso significa que o primeiro
elemento de um array tem índice 0, o segundo tem índice 1, e assim
por diante. Para criar um array em C#, você deve especificar o tipo
dos elementos que ele irá armazenar e o número de elementos que ele
irá conter. O número de elementos é conhecido como o tamanho do array.
O tamanho de um array é fixo e não pode ser alterado depois que o
array é criado. Para acessar um elemento de um array, você deve
especificar o índice do elemento entre colchetes. */
public class Array : MonoBehaviour 
{   
    void Start()
    {
        //index          0 1 2 3 4
        int[] numeros = {1,2,3,4,5};        
        Debug.Log(" Primeiro elemento do array " + numeros[0] + " é o numero ");
        Debug.Log(" Ultimo elemento do array " + numeros[numeros.Length-1] + " é o numero ");

        //index é o indice do array, posição onde os elementos estão armazenados

        Debug.Log("----------------------------------------------");

        //Modificando elementos
        Debug.Log("O numero na posição 2 do array antes era " + numeros[2]); 
        numeros[2] = 10; 
        Debug.Log(" O numero modificado agora é " + numeros[2]);

        Debug.Log("----------------------------------------------");

        //Percorrer Array, inicio ao fim.
        for (int i = 0; i < numeros.Length; i++)
        {
            Debug.Log(" Elementos " + i + " Do array é o numero " + numeros[i]);
        }
    }
   
}