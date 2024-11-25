using UnityEngine;
// Condicionais são estruturas de controle que permitem que um bloco de código seja executado 
//ou não, dependendo de uma condição.

// if-else
// if-elseif-else
// Operador Ternário
public class Condicionais : MonoBehaviour
{   
       void Start()
    {   
        // if-else
        // única verificação
         int xp = 18;        
       
        if(xp > 0 && xp < 10)
        {
            Debug.Log("Player pode coletar espada");
        }
        else
        {
            Debug.Log("Player pode coletar espada");
        }

        //if-else EXEMPLO2
        int idade = 20;

        if(idade >= 18)
        {
            Debug.Log("Pode beber");
        }
        else
        {
            Debug.Log("Não pode beber");
        }

        //if-elseif-else EXEMPLO1
        //elseif usado para testar mais de uma condição
        int temperatura = 25;

        if(temperatura > 30)
        {
            Debug.Log("Está muito quente");

        }
        else if (temperatura <10)
        {
            Debug.Log("Está frio");
        }
        else
        {
            Debug.Log("Tá suave");
        }

        //if-elseif-else EXEMPLO2
        //elseif usado para testar mais de uma condição
        string diaDaSemana = "Sábado";

        if(diaDaSemana == "Segunda")
        {
            Debug.Log("Dia de estudar");
        }
        else if (diaDaSemana == "Sábado" || diaDaSemana == "Domingo")
        {
            Debug.Log("Dia de descansar");
        }
        else
        {
            Debug.Log("Dia de trabalhar");
        }
 

        //Operador Ternário 
        //É uma forma mais simplificada de escrever um if-else
        int numeroAlunos = 15;
        string resultado = (numeroAlunos > 10) ? "Turma cheia" : "Turma com vagas"; 
        Debug.Log(resultado);

        //Exemplo2
        bool estaAprovado = true;
        string status = estaAprovado ? "Aprovado" : "Reprovado";
        Debug.Log(status);


        //switch-case
        //É uma estrutura de controle que permite a execução de diferentes blocos de código
        //dependendo do valor de uma variável.

        int nivel = 3;

        switch (nivel)
        {
            case 1:
                Debug.Log("Você ganha 2 de buffer");
            break;

            case 2:
                Debug.Log("Você ganhar 5 de buffer");
            break;

            case 3:
                Debug.Log("Você ganha 8 de buffer");
            break;

            default:
                Debug.Log("Nenhum buffer pode ser dado");
                break;
        }

        //switch-case EXEMPLO2
        string cor = "azul";

        switch (cor)
        {
            case "preto":
                Debug.Log("Cor preta libera espada de fogo");
            break;

            case "branco":
                Debug.Log("Cor branca libera machado de gelo");
            break;

            case "azul":
                Debug.Log("Cor azul libera armadura do trovão");
            break;

            default:
                Debug.Log("Não ganhou nada");
                break;
        }



    }

}
