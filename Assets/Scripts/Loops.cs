using UnityEngine;
//loops são estruturas de controle que permitem que um bloco de código seja executado
//repetidamente, enquanto uma condição for verdadeira.

public class Loops : MonoBehaviour
{
    void Start()
    {
        //for loop incremento de 1
        for(int i = 0; i < 5; i++)
        {
            Debug.Log("O valor de i é: " + i); //imprime o valor de i no console
        }

        //for loop decremento de 1
        for(int j = 10; j > 0; j--)
        {
            Debug.Log("O valor de j é: " + j); //imprime o valor de j no console
        }

        //for loop com incremento de 2
        for(int k = 0; k <= 10; k++)
        {
            Debug.Log(" Valor de K " + k);
        }

        Debug.Log("-----------------------------------------");

        //while loop
        int count = 0;

        while(count <= 10)
        {
            Debug.Log(" O valor de count é: " + count);
            count++;    //incrementa o valor de count
        }   

        Debug.Log("-----------------------------------------");

        // while if-else
        int count2 = 0;

        while(count2 <= 10)
        {
            if(count2 % 2 == 0) //verifica se o numero é par
            {
                Debug.Log("O numero: " + count2 + " é par"); 
            }

            else
            {
                Debug.Log("O numero: " + count2 + " é impar");
            }
            
            count2 ++; 
        }

        Debug.Log("-----------------------------------------");
      
        // Do-while
        int count3 = 0;

        do //executa o bloco de código pelo menos uma vez
        {
            Debug.Log("O valor de count3 é: " + count3);
            count3--;
        }

        while (count3 > 0); //verifica a condição

   

    }
}