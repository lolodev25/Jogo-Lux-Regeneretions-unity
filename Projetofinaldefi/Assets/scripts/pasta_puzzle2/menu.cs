using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class menu : MonoBehaviour
{
    public string tela_menu;
    public string tela_poema;
    // Start is called before the first frame update
   public void voltarmuseu()
    {
        SceneManager.LoadScene(tela_menu);
       

    }


}
