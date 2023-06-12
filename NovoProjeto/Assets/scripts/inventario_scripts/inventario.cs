using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inventario : MonoBehaviour
{

    public GameObject mouseitem;


    // Start is called before the first frame update
    public void Arrastitem( GameObject button)
    {
        mouseitem = button;
        mouseitem.transform.position = Input.mousePosition;//pega a posicao do maouse
        
    }

    public void dropaitem(GameObject button)
    {
        if(mouseitem != null)
        {
            Transform aux = mouseitem.transform.parent;
            mouseitem.transform.SetParent(button.transform.parent);//setar o componente pai
            button.transform.SetParent(aux);

            

        }
        
    }
}
