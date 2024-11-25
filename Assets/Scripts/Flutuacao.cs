using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Flutuacao : MonoBehaviour
{   
    public Transform pontoA;
    public Transform pontoB;
    public float velocidade = 1.0f;
    public float alturaSalto = 1.0f;
    private Vector3 direcao; //bolinha
    private float tempo = 0f;

    void Start()
    {   
        //pontob - pontoa = vetor direcao
        direcao = (pontoB.position - pontoA.position).normalized;
        
    }

    void Update()
    {
        //movimenta a bolinha, taxa de frames por segundo. Time.deltaTime = 1/60 fps = 0.01666667
        transform.position += direcao * velocidade * Time.deltaTime;  
        float flutuacao = Mathf.Sin(tempo) * alturaSalto; //seno de 0 a 1

        //o seno só é somado no eixo y para que a bolinha flutue, eixo x e z são mantidos. pontoA usado como referencia de movimento.
        transform.position = new Vector3(transform.position.x, pontoA.position.y + flutuacao, transform.position.z);


        //tempo de execução constante, 2f define altura da flutuação
        tempo += Time.deltaTime * 2f; 


        //se a distancia entre a bolinha e o pontoB for menor que 1f, inverte a direção para voltar para o pontoA
        if (Vector3.Distance(transform.position, pontoB.position) < 1f)
        {
            //inverte a direção
            transform.position = pontoA.position;
            tempo = 0f;
        }
        
        
    }
}
