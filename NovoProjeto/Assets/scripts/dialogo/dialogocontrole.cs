using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class dialogocontrole : MonoBehaviour
{
    public GameObject paineldialogo;
    public Text falanpc;
    public GameObject resposta;
    private bool falaativa = false;//npc ativa

    FalaNpc falas;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && falaativa)
        {
          //  Debug.Log("funciona");
            if (falas.resposta.Length > 0)
            {
                Debug.Log("funciona");
                mostraresposta();
            }
            else
            {
                falaativa = false;
                paineldialogo.SetActive(false);
                falanpc.gameObject.SetActive(false);
                FindObjectOfType<Playercontrol>().speed = 5;
            }
        }
    }

    void mostraresposta()
    {
        falanpc.gameObject.SetActive(false);
        falaativa = false;

        for(int i = 0; i < falas.resposta.Length; i++)
        {
            GameObject temporesposta = Instantiate(resposta, paineldialogo.transform) as GameObject;
            temporesposta.GetComponent<Text>().text = falas.resposta[i].resposta;
            temporesposta.GetComponent<btresposta>().Setup(falas.resposta[i]);
        }
    }

    public void proximafala(FalaNpc fala)
    {
        falas = fala;

        limparrespostas();
        falaativa = true;
        falanpc.gameObject.SetActive(true);
        paineldialogo.gameObject.SetActive(true);

        falanpc.text = falas.fala;

    }

     void limparrespostas()
    {
        btresposta[] buttons = FindObjectsOfType<btresposta>();
        foreach(btresposta button in buttons)
        {
            Destroy(button.gameObject);
        }
    }
}
