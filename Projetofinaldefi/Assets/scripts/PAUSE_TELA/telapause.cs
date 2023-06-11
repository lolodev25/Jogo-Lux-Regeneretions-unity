using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class telapause : MonoBehaviour
{
    public Transform pausetela;

    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)|| Input.GetButtonDown("Start"))// botao esc e bt start
        {
            if (pausetela.gameObject.activeSelf)
            {
                pausetela.gameObject.SetActive(false);
                Time.timeScale = 1;
            }
            else
            {
                pausetela.gameObject.SetActive(true);
                Time.timeScale = 0;
            }
        }
    }
}
