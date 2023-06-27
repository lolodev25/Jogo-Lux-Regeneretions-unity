using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gamecontroler : MonoBehaviour
{

    public Text helfthtext;
    public static gamecontroler instance;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void updatelive(int value)
    {
        helfthtext.text ="x " + value.ToString();//converte valor para a string
    }
}
