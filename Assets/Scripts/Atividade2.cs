using UnityEngine;

//criar cena nova, usar aprendizado da semana em situação de jogo
//variaveis e op matematicas no codigo e verificações de condição
//imprimir mensagens no terminal de acordo com verificações
public class Obstacle : MonoBehaviour
{

    void Start()
    {
 
        int numeroDeMoedas = 150;
        int numeroDeJoias = 2;
        int danoSofrido = 50;
    
        //Switchcase
       //avalia joias raras coletadas e dá poderes  
      switch (numeroDeJoias)
        {
            case 1:
                Debug.Log("Você recebeu o poder divino de cura e pode curar 5% do dano recebido");
            break;

            case 2:
                Debug.Log("Você recebeu 50% de buffer em ataque critico");
            break;

            case 3:
                Debug.Log("Você recebeu a armadura épica que te deixa imortal por 5 segundos");
            break;

            default:
                Debug.Log("Você não recebeu nada");
                break;
        }

        //if else-if else
        //avalia moeda e joias coletadas e dá xp
        if(numeroDeMoedas > 100 && numeroDeJoias == 3)
        {
            Debug.Log("Você recebeu um bônus de 1000 pontos de xp");
        }
        else if (numeroDeMoedas > 75 && numeroDeJoias == 2)
        {
            Debug.Log("Você recebeu um bônus de 500 pontos de xp");
        }
        else if (numeroDeMoedas > 50 || numeroDeJoias == 1)
        {
            Debug.Log("Você recebeu um bônus de 200 pontos de xp");
        }
        else
        {
            Debug.Log("Você não recebeu nenhum bônus");
        }


        //if else
        //verifica dano sofrido e dá feedback
        if(danoSofrido < 75){
            Debug.Log("Você venceu a fase e ganha bonus");
        }
        else
        {
            Debug.Log("Você perdeu a fase e precisa recomeçar");
        }
    }

}