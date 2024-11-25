using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/*Codigo voltado para movimentação em plataforma 2D
movimentação do personagem e pulo*/

//Metodos: criar ações especificas no código, são chamados no método Update.

/*Tag ou Layer para identificar o que é o chão dentro da cena.
Layer possibilita mexer em entrada e saída dos objetos
Tag é mais usado para separar objetos, como inimigos, player, etc.

Layer usado para verificar se o boneco está no chao e compoe a movimentação
em plataforma*/

public class PlayerControl : MonoBehaviour
{   
    //variaveis
    public float velocidade;
    public float forcaPulo;
    private Rigidbody2D rb; 
    public Transform verificaChao; //verifica se o player está no chao, impede duplo pulo 
    public LayerMask camadaDoChao; //identifica chão na cena
    private bool estaNochao; //verifica se o player está no chão
    private bool viradoParaDireita = true; //direção do personagem, usado para flipar direção do sprite


    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); //iniciando o rigidbody
        
    }
    
    void Update()
    {
        Mover(); 
        Pular();
        Virar(); 
    }

    void Mover()
    {   
        //movimento só acontece no eixo X por ser plataforma
        float entradaMovimento = Input.GetAxisRaw("Horizontal"); 
        rb.velocity = new Vector2 (entradaMovimento * velocidade, rb.velocity.y); //y se mantém padrão, não alterado

    }

    void Pular()
    {   
        //cria circulo no pé do personagem e verifica intercessão com o chão. 0.2f é o raio do circulo
        //Circle usado para 2D
        estaNochao = Physics2D.OverlapCircle(verificaChao.position, 0.2f, camadaDoChao); 

        //se estiver no chão e apertar o botão de pulo = espaço
        if(estaNochao == true && Input.GetKeyDown(KeyCode.Space)) 
        {
            rb.velocity = new Vector2(rb.velocity.x, forcaPulo); //adc velocidade e o pulo acontece no eixo Y
        } 

    }

    void Virar()
    {
        float entradaMovimento = Input.GetAxis("Horizontal"); //pega a entrada do movimento [teclado]

        if(entradaMovimento > 0 && !viradoParaDireita)
        {
            Flipar();

        }
        else if (entradaMovimento < 0 && viradoParaDireita)
        {
            Flipar();
        }
    }

    void Flipar()
    {
        viradoParaDireita = !viradoParaDireita; //inverte o valor da variavel
        Vector3 escalaLocal = transform.localScale; //pega a escala local do objeto
        escalaLocal.x *= -1; //inverte a escala local
        transform.localScale = escalaLocal; //aplica a escala local invertida
    }

}
