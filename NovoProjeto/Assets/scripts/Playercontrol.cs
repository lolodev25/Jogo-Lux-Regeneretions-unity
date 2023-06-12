using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Playercontrol : MonoBehaviour
{

    public GameObject bow;
    public Transform firepoint;
    private Vector3 movement;
   

    public Animator anima;
    public float speed;
    public Rigidbody2D rg;
    public int sla;
    private bool isfire;
    private void Start()
    {
        rg = GetComponent<Rigidbody2D>();
        anima = GetComponent<Animator>();
    }


    public void travarRotacao()
    {
        float rotationZ = transform.rotation.z;
        if (rotationZ > 0 || rotationZ < 0)
        {
            transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, transform.localEulerAngles.y, -rotationZ);
        }
    }

    public void Update()
    {
        /*
        Vector3 movimento = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0f);
        
        anima.SetFloat("Horizontal", movimento.x);
        anima.SetFloat("Vertical", movimento.y);
        anima.SetFloat("speed", movimento.magnitude);
        

        transform.position = transform.position + movimento * speed * Time.deltaTime;

        /*

        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Verifica se o personagem est� se movendo
            if (rg.isKinematic)
            {
                // Se o personagem est� parado, torna-o m�vel
                rg.isKinematic = false;
                Debug.Log("Personagem pode se mover novamente.");
            }
            else
            {
                // Se o personagem est� em movimento, torna-o im�vel
                rg.isKinematic = true;
                Debug.Log("Personagem parado.");
            }
        }

    */





        andar();
        atirar();
        // Verifique uma condi��o para parar o movimento do personagem.

        /*
        bool pararMovimento = true; // Altere esta condi��o conforme necess�rio.

        if (pararMovimento)
        {
            rg.isKinematic = true;
            rg.velocity = Vector3.zero;
        }
        else
        {
            rg.isKinematic = false;
        }
        esse funcionou
        */

    }

    public void atirar()
    {
        

        if (Input.GetKeyDown(KeyCode.R) || Input.GetButtonDown("Atirar")) // Altere "Space" para o bot�o desejado
        {
           // Instantiate(bow, firepoint.position, firepoint.rotation);
           // PlayAnimation();

         

            if (Input.GetKeyUp(KeyCode.R) || Input.GetButtonUp("Atirar")) // Altere "Space" para o bot�o desejado
            {
               //s StopAnimation();
            }
        }
    }

    public void andar()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");

         movement = new Vector3(horizontalInput, verticalInput, 0f).normalized;

        // Atualize os par�metros do animator
        anima.SetFloat("Horizontal", movement.x);
        anima.SetFloat("Vertical", movement.y);
        anima.SetFloat("speed", movement.magnitude);

        // Mova o personagem usando o Rigidbody
        rg.velocity = movement * speed;
    }

    private void PlayAnimation()
    {
        // Defina o nome da anima��o que deseja reproduzir
        // Certifique-se de que a anima��o est� configurada corretamente no Animator
        anima.SetBool("anima", true);
    }

    private void StopAnimation()
    {
        anima.SetBool("anima", false);
    }

}
