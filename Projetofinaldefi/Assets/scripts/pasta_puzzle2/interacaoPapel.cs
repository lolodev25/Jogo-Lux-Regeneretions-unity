using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Events;


    [RequireComponent(typeof(Collider2D))]
public class interacaoPapel : MonoBehaviour
{
    [SerializeField]
    private interacao jogadorinter;
    private UnityEvent botapert;
    public string tela_poema;
    private bool podeexecutar;
    [SerializeField] private GameObject menu_opcoes;
    public Button btclikado;

    private void Start()
    {
        // btclikado.onClick.AddListener(acessarpoema);
        btclikado.onClick.AddListener(acessarpoema);

    }

    public void acessarpoema()
    {
        SceneManager.LoadScene(tela_poema);
    }
    // Update is called once per frame
    void Update()
    {
        if (podeexecutar)
        {
            if(jogadorinter.Estainterage == true)
            {
                //acessarpoema();
                opcaopuzzle();
                Debug.Log("acessou");
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        podeexecutar = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        podeexecutar = false;
    }

    public void opcaopuzzle()
    {
        menu_opcoes.SetActive(true);

    }

    public void teste()
    {
        Debug.Log("funcionaou");
    }

}
