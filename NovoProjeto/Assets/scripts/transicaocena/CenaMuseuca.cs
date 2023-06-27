using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;


   [RequireComponent(typeof(Collider2D))]
public class CenaMuseuca : MonoBehaviour
{
    [SerializeField] private string cena;
    private int valor;
    private int valor2;
   
    //[SerializeField] private inputBotton valida;
    //[SerializeField] private validadecaoposition valida2;
    

    public void Start()
    {
         //int valorInteiro = PlayerPrefs.GetInt("MeuValorBool");
        //int valor1 = PlayerPrefs.GetInt("valorvari");
        //bool meuValorBool = valorInteiro != 0;
        //Debug.Log(valorInteiro);
        //valor = valorInteiro;
        //valor2 = valor1;
        // Obtém o componente Rigidbody do objeto
       

        // Congela todas as rotações e movimentos no Rigidbody
        


    }


    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
      //  if(valor2 == 1)
        //{
           

//        }
         carregarcena();
        
        
        
    }

    public void carregarcena()
    {



        //int valor = PlayerPrefs.GetInt("valorvari");
        // Debug.Log("oi meu chapa");
        // Debug.Log("Funcionou: " + valor);
        //Debug.Log("Funcionou2: " + valor2);


        /*
        if (valida.validation == true && valida2.validacao == true)
        {
            Debug.Log("pode sair");
        }
        
        if(valida.validation == true)
        {
            Debug.Log("Primeiro pronto");
        }

        if(valida2.validacao == true)
        {
            Debug.Log("segundo pronto");
        }



       */
        GerenciScene.instance.loadscena(cena);
       // SceneManager.LoadScene(cena);
    }
}
