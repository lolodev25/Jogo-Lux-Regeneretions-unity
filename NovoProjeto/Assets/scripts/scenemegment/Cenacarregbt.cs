using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Cenacarregbt : MonoBehaviour
{
    [SerializeField] private string scenename;

    public void carregargame()
    {

       GerenciScene.instance.loadscena(scenename);
    }

}
