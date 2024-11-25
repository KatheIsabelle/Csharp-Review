using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

// Operadores em C# & Conversão de tipos de dados
public class OpAritmeticos : MonoBehaviour
{
    int num = 10;
    int num2 = 5;
    float num3 = 3.5f;

    void Start()
    {   
        Debug.Log("primeiro valor eh: " + num);
        Debug.Log ("segundo valor eh: " + num2);
        Debug.Log("Soma desses valores eh " + (num + num2)); //15
        Debug.Log("Subtração desses valores eh " + (num - num2)); //5
        Debug.Log("Multiplicação desses valores eh " + (num * num2)); //50
        Debug.Log("Divisão desses valores eh " + (num / num2)); //2
        Debug.Log("Resto da divisão desses valores eh " + (num % num2)); //0

    //conversao implicita
    float novo_num = num; //converte int para float
    Debug.Log(novo_num); //10.0

    //conversao explicita
    int novo_num2 = (int)num3; //converte float para int
    Debug.Log(novo_num2); //3

    //conversao strings
    string numeroString = "100"; //string
    int numeroInt = Convert.ToInt32(numeroString); //converte string para int
    int numeroInt2 = int.Parse(numeroString); //outra forma de converter
    Debug.Log(numeroInt); //100
    Debug.Log(numeroInt2); //100

    Debug.Log("Tipo de dado:" + numeroString.GetType()); //System.String

    }
    
   
}