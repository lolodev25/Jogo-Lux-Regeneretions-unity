using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balas : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float tempo;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, tempo);
    }

    void FixedUpdate()
    {
        transform.Translate(transform.up * speed * Time.fixedDeltaTime, Space.World);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
