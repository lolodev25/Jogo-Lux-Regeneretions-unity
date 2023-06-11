using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class DrangandDang : MonoBehaviour
{
    public string cenamuseu;

    public GameObject selectadepice;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

            if (hit.transform.CompareTag("Puzzle"))
            {
                if (!hit.transform.GetComponent<PiecesScript>().inrihtposition)
                {
                    selectadepice = hit.transform.gameObject;
                    selectadepice.GetComponent<PiecesScript>().selecio = true;
                }


            }
           
        }

        if (Input.GetMouseButtonUp(0))
        {
            if(selectadepice != null)
            {
                selectadepice.GetComponent<PiecesScript>().selecio = false; 
                selectadepice = null;// a peça não ofi selecionada mais

            }
            
            
        }

        if (selectadepice != null)
        {
            Vector3 MousePoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            selectadepice.transform.position = new Vector3(MousePoint.x, MousePoint.y, 0);
            
            //Debug.Log("atualizando:"+control);
        }

        if (Input.GetKeyDown(KeyCode.Space)) // Ou qualquer outro botão desejado
        {
            museu();
        }

    }


    public void museu()
    {
        SceneManager.LoadScene(cenamuseu);
    }
  
   
}
