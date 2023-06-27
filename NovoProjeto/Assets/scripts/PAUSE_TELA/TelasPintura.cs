using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TelasPintura : MonoBehaviour
{
    [SerializeField] private GameObject tela_ativa;
    [SerializeField] private interacao jginterage;
    private UnityEvent btapert;
    private bool podeexeutar;
    private Playercontrol speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void acessar()
    {
        tela_ativa.SetActive(true);
        FindObjectOfType<Playercontrol>().speed = 0;
    }

    public void sair()
    {
        tela_ativa.SetActive(false);
        FindObjectOfType<Playercontrol>().speed = 5;

    }



    // Update is called once per frame
    void Update()
    {
        if (jginterage.Estainterage == true)
        {
            if (podeexeutar == true)
            {
                acessar();

               
            }
        }
       
    }


    private void OnTriggerEnter2D(Collider2D collision)//dentro do colisor
    {
        podeexeutar = true;

        //colocar aqui o input e validar na outr

    }

    private void OnTriggerExit2D(Collider2D collision)// fora do colisor
    {
        podeexeutar = false;
    }
}
