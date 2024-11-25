using UnityEngine;

//AULA 2: VARIAVEIS EM CSHARP
//Variaveis são espaços de memória que guardam valores

public class Variaveis : MonoBehaviour
{
    //tipos de variaveis
    int life = 100;
    string PlayerName = "Creitin";
    float speed = 5.5f;
    bool isAlive = true;
    char letra = 'a';
    char num = '1';

    void Start()
    {
        Debug.Log("Player Name: " + PlayerName);
        Debug.Log("Player Life: " + life);
        Debug.Log("Player Speed: " + speed);
        Debug.Log("Player is Alive: " + isAlive);
        Debug.Log("Player Letter: " + letra);
        Debug.Log("Player Number: " + num);
            
    }

}
