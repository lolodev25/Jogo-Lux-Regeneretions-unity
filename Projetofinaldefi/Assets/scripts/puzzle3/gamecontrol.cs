using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class gamecontrol : MonoBehaviour
{


    [SerializeField] private Transform[] pics;
    [SerializeField] private GameObject wintext;
    public static bool youwin;
    // Start is called before the first frame update
    void Start()
    {
        wintext.SetActive(false);
        youwin = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(pics[0].rotation.z == 0 &&
           pics[1].rotation.z == 0 &&
           pics[2].rotation.z == 0 &&
           pics[3].rotation.z == 0 &&
           pics[4].rotation.z == 0 &&
           pics[5].rotation.z == 0 &&
           pics[0].rotation.z == 0
            )
        {
            youwin = true;
            wintext.SetActive(true);
        }
    }
}
