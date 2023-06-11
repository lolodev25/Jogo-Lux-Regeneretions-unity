using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pegarobjt : MonoBehaviour
{
    // Start is called before the first frame update
    public float disappearanceDistance = 5f;
    private GameObject player;
    public bool Pegou { get; set; }

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update()
    {
        float distanceToPlayer = Vector3.Distance(transform.position, player.transform.position);

        if (distanceToPlayer <= disappearanceDistance)
        {
            Disappear();
        }
    }

    private void Disappear()
    {
        // Desativa o objeto para torná-lo invisível
        if (Input.GetKeyDown(KeyCode.G)){
            gameObject.SetActive(false);
            Pegou = true;
            Debug.Log(Pegou);


        }

           
        
        
    }
}
