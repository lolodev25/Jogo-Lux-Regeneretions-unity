using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class btresposta : MonoBehaviour
{
    RespostaDante respostadata;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void proximafala()
    {
        FindObjectOfType<dialogocontrole>().proximafala(respostadata.proximafala);
      //  FindObjectOfType<dialogocontrole>().proximafala(respostadata);

    }

    public void Setup(RespostaDante resposta)
    {
        respostadata = resposta;
    }
}
