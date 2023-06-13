using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo : MonoBehaviour
{
    [SerializeField]
    private Transform alvo;// objeto do persongem

    [SerializeField]
    private float velocidademov;

    [SerializeField]
    private Rigidbody2D risgbory;

    [SerializeField]
    private SpriteRenderer spritrender;

    [SerializeField]
    private float distaciamin;

    // Update is called once per frame
    void Update()
    {
        Vector2 posicaoalvo = this.alvo.position;// pega a pisicao do jogador
        Vector2 posicaoatual = this.transform.position;

        float distancia = Vector2.Distance(posicaoatual, posicaoalvo);
        if(distancia>= this.distaciamin)
        {

        

        Vector2 direcao = posicaoalvo - posicaoatual;//calcula a distancia
        direcao = direcao.normalized;// deixa os valores entre -1 e 1

        this.risgbory.velocity = (this.velocidademov * direcao);// mover coforme o inimigo


        if (this.risgbory.velocity.x > 0)//direita, inserir aq a animacao dele para a direita
        {
            this.spritrender.flipX = false;//olhando para a direita

        }else if (this.risgbory.velocity.x < 0)//esquerda
        {
            this.spritrender.flipX = true;
        }

        }
        else
        {
            //parar a movimentacao
            this.risgbory.velocity = Vector2.zero;// zero no eixo x e y

        }

    }
}
