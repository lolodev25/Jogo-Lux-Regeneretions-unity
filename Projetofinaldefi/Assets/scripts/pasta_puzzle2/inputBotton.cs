using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class inputBotton : MonoBehaviour
{

    public Button btclik;

    public InputField input, input3, input4,input5,input6,input7,input8,input9,input10,input11,input12,input13,input14,input15,input16,input17;
    public InputField input2;

    public InputField inputcabe1, inputcap2;
    [SerializeField] private GameObject certo;
    [SerializeField] private GameObject errado;
    public bool validation { get; set; }

    public int valor ;
    



    // Start is called before the first frame update
    void Start()
    {
        btclik.onClick.AddListener(getbtclick);// chama a funcao quando aperta o bt
        certo.SetActive(false);

    }

    

    public void getbtclick()
    {
        Debug.Log("input 10" + input.text);

    
        if(inputcabe1.text == "morresse")
        {
            certoinput1();
        }

        if(inputcabe1.text == "morresse" && inputcap2.text == "amanhã" && input.text == "triste" && 
            input2.text =="mãe" && input3.text =="saudades" && input4.text == "morresse" && 
            input5.text == "glória" && input6.text =="futuro" && input7.text == "aurora" && 
            input8.text =="chorando" && input9.text =="acorda" && input10.text =="amor" && 
            input11.text == "peito" && input12.text =="dor" && input13.text =="vida" && 
            input14.text =="se" && input15.text =="eu" && input16.text == "morresse" && 
            input17.text == "amanhã")
        {
            Debug.Log("correto");
            valor = 1;
            certoinput1();
            
        }
            valor ++;
            PlayerPrefs.SetInt("MeuValorBool", valor);
            PlayerPrefs.Save();
            Debug.Log("valor: " + valor);





        
        Debug.Log("valorantes:" + valor);


    }

        public void certoinput1()
    {
        certo.SetActive(true);
        
    }

    public void sair()
    {

    }


   
}
