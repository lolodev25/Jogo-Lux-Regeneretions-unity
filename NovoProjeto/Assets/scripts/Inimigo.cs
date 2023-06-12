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


    // Update is called once per frame
    void Update()
    {
        Vector2 posicaoalvo = this.alvo.position;// pega a pisicao do jogador
        Vector2 posicaoatual = this.transform.position;
        Vector2 direcao = posicaoalvo - posicaoatual;//calcula a distancia
        direcao = direcao.normalized;// deixa os valores entre -1 e 1

        this.risgbory.velocity = (this.velocidademov * direcao);// mover coforme o inimigo
        

        


    }
}
