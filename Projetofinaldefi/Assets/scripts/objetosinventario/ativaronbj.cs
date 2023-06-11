using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ativaronbj : MonoBehaviour
{
    private Pegarobjt ative;
    [SerializeField] private GameObject objeto;
    // Start is called before the first frame update
    void Start()
    {
        objeto.SetActive(false);
        Debug.Log(ative);
    }

    // Update is called once per frame
    void Update()
    {
        if(objeto == true)
        {
            ativar();

        }
      
    }

    public void ativar()
    {
        objeto.SetActive(true);
    }


}
