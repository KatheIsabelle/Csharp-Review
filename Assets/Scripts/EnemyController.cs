using UnityEngine;
using System.Collections.Generic;
/*Classe para controlar o inimigo, movimentação em waypoints
movimenta o inimigo em pontos determinados, automaticamente
pontos marcados como waypoints usando uma lista para alocar estes pontos.*/
public class EnemyController : MonoBehaviour
{
    private Rigidbody2D rb;
    public List<Transform> waypoints;
    public float velocidade = 5f;
    int proximoPonto = 0;

    void Start()
    {   
        //inicia rigidbody
        rb = GetComponent<Rigidbody2D> ();

    }

    void Update()
    {   
        //verifica tamanho da lista, igual length mas para lista usa count
        if(waypoints.Count > 0) //index 0
        {
            Vector2 direcao = (waypoints[proximoPonto].position - transform.position).normalized;
            rb.velocity = direcao * velocidade;

            if(Vector2.Distance(transform.position, waypoints[proximoPonto].position) < 0.1f)
            {   
                //calcula pontos que ainda serão visitados com base no atual ocupado
                proximoPonto = (proximoPonto + 1) % waypoints.Count;
                Debug.Log(proximoPonto); //verificar proximo ponto 
            }
        }
    }

}