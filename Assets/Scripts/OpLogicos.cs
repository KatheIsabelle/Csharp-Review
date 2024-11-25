using UnityEngine;
// Operadores Lógicos em C#
// Operadores lógicos são usados para combinar duas ou mais expressões condicionais
public class OpLogicos : MonoBehaviour
{
    int num = 10;
    int num2 = 20;
        
    void Start()
    {
        bool resultado1 = (num < num2) && (num > 5); //and
        bool resultado2 = (num == 20) || (num == 5); //or
        bool resultado3 = !((num < num2) && num > 5); //not
        
        // todas as verificações precisam ser true
        Debug.Log("Resultado 1: " + resultado1); // true

        // pelo menos 1 verificação dando true dá true na saída
        Debug.Log("Resultado 2: " + resultado2); // false

        // inverte o resultado da saída
        Debug.Log("Resultado 3: " + resultado3); // false

    }
}