using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{


   public string tela_casa;
   [SerializeField] private GameObject menu_inicial;
   [SerializeField] private GameObject tela_criarcad;
    

    public void Jogar()
    {

        SceneManager.LoadScene(tela_casa);
    }

    public void criarcad()
    {
        menu_inicial.SetActive(false);
        tela_criarcad.SetActive(true);

    }

    public void saircriar()
    {
        menu_inicial.SetActive(true);
        tela_criarcad.SetActive(false);
    }

    public void extras()
    {
        Debug.Log("Sair do jogo");
        Application.Quit();
    }
}
