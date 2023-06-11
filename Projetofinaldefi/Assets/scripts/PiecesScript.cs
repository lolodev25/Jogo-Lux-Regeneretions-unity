using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PiecesScript : MonoBehaviour
{

    private Vector3 rigthposition;
    public bool inrihtposition;
    public bool selecio;
  



    // Start is called before the first frame update
    void Start()
    {
        rigthposition = transform.position;
        transform.position = new Vector3(Random.Range(7f, 9.5f), Random.Range(-5.5f, -8f));

    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, rigthposition)< 0.5f)
        {
            if(!selecio)
            {
                 transform.position = rigthposition;
                 inrihtposition = true;
                  
               
                
              
            }
            
        }


        

    
    }


}
