using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


    [RequireComponent(typeof(Collider2D))]
public class InteragirCombt : MonoBehaviour
{
    
    [SerializeField]
    private interacao joginterage;
    private UnityEvent botaoapert;
    [SerializeField] private GameObject tela_remail;
    

    private bool podeExecutar;

    public void acessaremail()
    {
            tela_remail.SetActive(true);

        

    }

    public void sairemail()
    {
        tela_remail.SetActive(false);
    }

    public void Update()
    {
        if (podeExecutar)
        {
            if(joginterage.Estainterage == true && podeExecutar==true)
            {
                
                Debug.Log("está interaginfo");
               acessaremail();

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
