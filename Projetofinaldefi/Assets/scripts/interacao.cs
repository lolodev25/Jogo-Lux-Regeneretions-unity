using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interacao : MonoBehaviour
{
    
     public bool Estainterage { get; set; }

    public void Update()
    {
        if (Input.GetButtonDown("Interage"))
        {
            Estainterage = true;

        }
        else
        {
            Estainterage = false;
        }
    }

}
