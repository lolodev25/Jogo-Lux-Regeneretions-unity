using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PincelControl : MonoBehaviour
{

    Vector2 mousepoint;
    Vector2 dirarma;
    float angle;
 [SerializeField]   SpriteRenderer gun;
 [SerializeField]   float tempotiro;
   bool podeatira = true;
   [SerializeField] Transform pontodefogo;
   [SerializeField] GameObject tiro;
   
    private Rigidbody2D pincelrisg;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        pincelrisg = GetComponent<Rigidbody2D>();
       // Destroy(gameObject, 2f);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // pincelrisg.velocity = Vector2.up * speed;
        //colocor um if aqui para ver validadar quando apertar la no controle
        dirarma = mousepoint - new Vector2(transform.position.x, transform.position.y);
        angle = Mathf.Atan2(dirarma.y, dirarma.x) * Mathf.Rad2Deg - 90f;
        transform.rotation = Quaternion.Euler(0, 0, angle);
    }

   void Update()
    {

        mousepoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if(Input.GetButtonDown("Atirar") && podeatira==true)
        {
            podeatira = false;
            Instantiate(tiro, pontodefogo.position, pontodefogo.rotation);
            Invoke("CDtiro", tempotiro);
        }
    }

    void CDtiro()
    {
        podeatira = true;
    }
}
