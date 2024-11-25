using UnityEngine;
using System.Collections.Generic;
/*Listas sao uma estrutura de dados que armazena uma colecao de elementos
do mesmo tipo. Em C#, as listas sao objetos que possuem um tamanho
dinamico e sao indexados a partir de zero. Isso significa que o primeiro
elemento de uma lista tem indice 0, o segundo tem indice 1, e assim
por diante. Para criar uma lista em C#, voce deve especificar o tipo
dos elementos que ela ira armazenar. Uma lista pode armazenar qualquer
numero de elementos e voce pode adicionar ou remover elementos dela
durante a execucao do programa. */
public class List : MonoBehaviour 
{
    void Start()
    {
        //<> aspas francesas                 index  0       1          2
        List<string> nomes = new List<string> { "Kathe", "Louise", "Thereza" };
        Debug.Log("Primeiro elemento:" + nomes[0]);     //Primeiro elemento
        Debug.Log("Ultimo elemento:" + nomes[nomes.Count - 1]); //Ultimo elemento
        
        Debug.Log("----------------------------------------------");

        //Adicionando elementos, final da lista
        nomes.Add(" Maria ");
        Debug.Log(" Nome adicionado " + nomes[nomes.Count - 1]);

        Debug.Log("----------------------------------------------");

        //Inserindo elemento na posicao 1, exemplo1
        Debug.Log("Nome na posição 1 antes " + nomes[1]); //Louise
        nomes.Insert(1, " Ana ");
        Debug.Log(" Elemento inserido na posição 1: " + nomes[1]); //Ana

        Debug.Log("----------------------------------------------");

        //Trocando nome posicao 2, exemplo2
        Debug.Log("Nome na posição 2 antes " + nomes[2]); //Louise
        nomes[2] = " Joana ";
        Debug.Log(" Elemento trocado: " + nomes[2]); //Joana

        Debug.Log("----------------------------------------------");

        //Removendo elemento
        nomes.Remove(" Maria ");
        Debug.Log(" Elemento removido: " + nomes[nomes.Count - 1]);

        Debug.Log("----------------------------------------------");

        //percorrer lista, usando for
        for(int i = 0; i < nomes.Count; i++)
        {
            Debug.Log(" Elemento " + i + " da lista " + nomes[i]);
        }

        Debug.Log("----------------------------------------------");

        //percorrer lista, usando foreach (tipo de dado, nome do foreach in [nome da lista]) 
        foreach(string nome in nomes)
        {
            Debug.Log(" Nome " + nome);
        }
     
    }

}