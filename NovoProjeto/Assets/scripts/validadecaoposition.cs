using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class validadecaoposition : MonoBehaviour
{
    private GameObject[] puzzlePieces;
    public GameObject congratsMessage;
    public int valors ;

    // Start is called before the first frame update
    void Start()
    {
        puzzlePieces = GameObject.FindGameObjectsWithTag("Puzzle");
        
    }

    // Update is called once per frame
    void Update()
    {
        bool allPiecesInRightPosition = true;

        foreach (GameObject piece in puzzlePieces)
        {
            PiecesScript pieceScript = piece.GetComponent<PiecesScript>();

            if (!pieceScript.inrihtposition)
            {
                allPiecesInRightPosition = false;
                break;
            }
        }

        if (allPiecesInRightPosition)
        {
            valors = 1;
            PlayerPrefs.SetInt("valorvari", valors);
            PlayerPrefs.Save();
            Debug.Log("Desenvolvido"+valors);
        }
        else
        {
            //congratsMessage.SetActive(false);
        }
        
       
    }
}
