using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameraseguir : MonoBehaviour
{

    private Transform dante;
    public float insert;

    // Start is called before the first frame update
    void Start()
    {
        dante = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 follow = new Vector3(dante.position.x, dante.position.y, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, follow, insert * Time.deltaTime);
    }
}
