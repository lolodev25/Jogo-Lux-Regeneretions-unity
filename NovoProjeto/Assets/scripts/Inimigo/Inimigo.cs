using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo : MonoBehaviour
{
   
    
    private Transform alvo;// objeto do persongem

    [SerializeField]
    private float velocidademov;

    [SerializeField]
    private Rigidbody2D risgbory;

    [SerializeField]
    private SpriteRenderer spritrender;

    [SerializeField]
    private float distaciamin;

    [SerializeField]
    private Animator animator;

    [SerializeField]
    private float raiovisao;

    [SerializeField]
    private LayerMask layerarevisao;

    [SerializeField]
    private Color colorcirculo;

    [SerializeField]
    private Color colordirecao;
    // Update is called once per frame

    [SerializeField]
    private float distanciamxataque;

    [SerializeField]
    private float intervaloataque;

    private float tempoespera;

    private void Start()
    {
        this.tempoespera = this.intervaloataque;
    }

    void Update()
    {
        procurarjogador();
        if(this.alvo != null)//tem alvo
        {
          movimenta();
            verificarataque();
        }
        else // sem alvo
        {
            pararmov();
        }
        

    }

    private void verificarataque()
    {
        
        float distancia = Vector3.Distance(this.transform.position, this.alvo.position);
        if(distancia<= this.distanciamxataque)
        {
            this.tempoespera -= Time.deltaTime;
            if (this.tempoespera <= 0)
            {
                this.tempoespera = this.intervaloataque;
                atacar();
            }

            //tavcar jogador

        }
    }

    private void atacar()
    {
        Playercontrol jogador = this.alvo.GetComponent<Playercontrol>();//pegando uma varialvel do tipo player e as propredades
        jogador.receberdano();
    }

    public void movimenta()
    {
        Vector2 posicaoalvo = this.alvo.position;// pega a pisicao do jogador
        Vector2 posicaoatual = this.transform.position;

        float distancia = Vector2.Distance(posicaoatual, posicaoalvo);
        if (distancia >= this.distaciamin)
        {



            Vector2 direcao = posicaoalvo - posicaoatual;//calcula a distancia
            direcao = direcao.normalized;// deixa os valores entre -1 e 1

            this.risgbory.velocity = (this.velocidademov * direcao);// mover coforme o inimigo


            if (this.risgbory.velocity.x > 0)//direita, inserir aq a animacao dele para a direita
            {
                this.spritrender.flipX = false;//olhando para a direita

            }
            else if (this.risgbory.velocity.x < 0)//esquerda
            {
                this.spritrender.flipX = true;
            }
            this.animator.SetBool("movendo", true);

        }
        else
        {
            //parar a movimentacao
            pararmov();

        }
    }

    private void OnDrawGizmos()// metodo para desenhar uma esfera
    {
        Gizmos.color = this.colorcirculo;
        Gizmos.DrawWireSphere(this.transform.position, this.raiovisao);//contruindo o raio
        if(this.alvo != null)
        {
            Gizmos.color = this.colordirecao;
            Gizmos.DrawLine(this.transform.position, this.alvo.position);//desenha uma linha até o alvo
        }
    }

    private void procurarjogador()
    {
      Collider2D colisor =  Physics2D.OverlapCircle(this.transform.position, this.raiovisao,this.layerarevisao);//identifica se tem um colisor dentro dessa area
        

        if (colisor != null)//dento da area
        {
            Vector2 posicaoatual = this.transform.position;//pega a posicao do inimigo
            Vector2 posicaoalvo = colisor.transform.position;// pega a posicao do jogador
            Vector2 direcao = posicaoalvo - posicaoatual;// calculo da direçao dos dois
            direcao = direcao.normalized;//normaliza a direcao em -1 e 1

           RaycastHit2D hit = Physics2D.Raycast(posicaoatual, direcao);
            if(hit.transform != null)//econtrou o objt
            {
                if (hit.transform.CompareTag("Player"))//objeto teg jogador
                {
                    this.alvo = hit.transform;
                }
                else//econtra outro sem ser o jogador
                {
                    this.alvo = null;
                }

            }
            else//nenhum objeto encontrado na direcao do inimigo
            {
                this.alvo = null;
            }
            
        }
        else
        {
            this.alvo = null;
        }
    }

    public void pararmov()
    {
        this.risgbory.velocity = Vector2.zero;// zero no eixo x e y
        this.animator.SetBool("movendo", false);
    }


}
