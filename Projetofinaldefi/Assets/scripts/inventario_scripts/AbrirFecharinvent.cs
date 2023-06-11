using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbrirFecharinvent : MonoBehaviour
{

    [SerializeField] private GameObject inventario_lateral;
    [SerializeField] private GameObject inventario_completo;
    private bool ativado = false;

    // Start is called before the first frame update
    void Start()
    {
        inventario_completo.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    public void abrir_completo()
    {
        inventario_completo.SetActive(true);
        inventario_lateral.SetActive(false);
        ativado = true;
    }

    public void fechar_completo()
    {
        inventario_lateral.SetActive(true);
        inventario_completo.SetActive(false);
        ativado = false;
    }
}
