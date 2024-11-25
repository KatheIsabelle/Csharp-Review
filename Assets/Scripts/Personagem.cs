using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Personagem : MonoBehaviour
{
    int vida = 100;
    int adicional = 50;
    int danoInimigo = 25;
    string nomePersonagem = "Goblin Bolado";

    void Start(){

        vida = vida + adicional;
        Debug.Log( nomePersonagem + " tem " + vida + " e causa " + danoInimigo + " de dano ");
    }

}