using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Events;

    [RequireComponent(typeof(Collider2D))]
public class anjoPuzzelControl : MonoBehaviour
{
    [SerializeField]
    private interacao joginterage;
    private UnityEvent botaoapert;
    //public string tela_museu;
    public string tela_puzzle;
    private bool podeExecutar;
    
    


    public void acessarpuzzle()
    {
        SceneManager.LoadScene(tela_puzzle);
    }

    


    // Update is called once per frame
    void Update()
    {
        if (podeExecutar)
        {
            if(joginterage.Estainterage == true)
            {
                acessarpuzzle();
            }
        }

        
        
    }

    private void OnTriggerEnter2D(Collider2D collision)//dentro do colisor
    {
        podeExecutar = true;

        //colocar aqui o input e validar na outr

    }

    private void OnTriggerExit2D(Collider2D collision)// fora do colisor
    {
        podeExecutar = false;
    }
}
