using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventroyControl : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        transform.position += (transform.parent.position - transform.position) * 5 * Time.deltaTime; ;//controla a posicao que o obheto vai ficar
    }
}
