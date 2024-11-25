using UnityEngine;

// Operadores de Comparação em C#
// Operadores de comparação são usados para comparar dois valores, retorna bool {true or false}
public class OpDeComparacao : MonoBehaviour 
{
    int num = 10;
    int num2 = 20;

    void Start()
    {   
        Debug.Log("primeiro valor:" + num);
        Debug.Log("segundo valor:" + num2);
        // == comparação valor e tipo
        Debug.Log(" num == num2 ? " + (num == num2) ); //false
        Debug.Log (" num != num2 ? " + (num != num2) ); //true
        Debug.Log (" num > num2 ? " + (num > num2) ); //false
        Debug.Log (" num < num2 ? " + (num < num2) ); //true
        Debug.Log (" num >= num2 ? " + (num >= num2) ); //false 
        Debug.Log (" num <= num2 ? " + (num <= num2) ); //true


    }

}