using UnityEngine;
//classe para controlar o player, movimentação em 8 direções
//codigo voltado para movimentação de personagem topdown

public class PlayerController : MonoBehaviour
{
    public float velocidade  = 5f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    void Update()
    {
        //eixo x movimento horizontal pegando input do usuario 
        float eixoX = Input.GetAxisRaw("Horizontal") * velocidade;

        //eixo x movimento horizontal pegando input do usuario 
        float eixoY = Input.GetAxisRaw("Vertical") * velocidade;
          
        //move o rigidbody do player, move até 8 direções
        rb.velocity = new Vector2(eixoX, eixoY);

    }

}