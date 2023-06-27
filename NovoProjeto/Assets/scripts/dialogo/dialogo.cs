using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogo : MonoBehaviour
{

    public FalaNpc[] falas = new FalaNpc[2];
    private bool dialogoconcluido;
    dialogocontrole dialogocontrole;



    // Start is called before the first frame update
    void Start()
    {
        dialogocontrole = FindObjectOfType<dialogocontrole>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<Playercontrol>().speed = 0;
            if (!dialogoconcluido)
            {
                dialogocontrole.proximafala(falas[0]);
                //chamar fotinha do dante

            }
            else
            {
                dialogocontrole.proximafala(falas[1]);
            }
            dialogoconcluido = true;
        }
    }
}
