using UnityEngine;


public class Atividade : MonoBehaviour
{
    //EXER1
    int moedas = 50;
    int bonus = 20;
    int perdaPorDano = 15;

    //EXER2
    int poderDeAtaqueBase = 10;
    int poderDeAtaqueEspecial = 2 * 10;

    //EXER3
    int xp = 25;
    int nivel = 3;

    void Start()
    {   
        /*exerc1
        jogador 50 moedas, colega +20, perde 15 apos enfrentar boss. 
        Calcular numero final de moedas do jogador e exibir na tela.
        */
        Debug.Log("**************** Exercicio 1: MOEDAS ****************");
        Debug.Log(" Player possui" + moedas + " moedas ");
        Debug.Log(" Player coleta bonus de " + bonus + " moedas ");
        Debug.Log(" layer possui um total de " + (moedas + bonus) + " moedas ");
        Debug.Log(" Player encontra inimigo e perde " + perdaPorDano + " moedas ");
        Debug.Log(" Player possui um total de " + (moedas + bonus - perdaPorDano) + " moedas ");

        /*exerc2
        Poder de ataque base = 10 e pode dobrar valor ao usar habilidade especial.
        Calcular e exibir o poder de ataque final ao usar habilidade especial.
        */
        Debug.Log("**************** Exercicio 2: HABILIDADE ESPECIAL ****************");
        Debug.Log(" Player possui poder base " + poderDeAtaqueBase);
        Debug.Log (" Player usa habilidade especial e seu poder de ataque é " + poderDeAtaqueEspecial);

        
        /*exerc3
        Jogador coleta 25 pontos xp, a cada 7 pontos de experiencia ele sobe 1 nivel. 
        Usando operacao de resto, descobrir quantos pontos de experiencia ainda falta para o jogador
        atingir o proximo nivel.
        */
        Debug.Log("**************** Exercicio 3: XP ****************");
        Debug.Log(" Player possui " + xp + " pontos de experiencia ");
        Debug.Log(" Player está no nivel " + nivel);
        Debug.Log(" Faltam " + (7 - (xp % 7)) + " pontos de experiencia para o proximo nivel ");
    }
}