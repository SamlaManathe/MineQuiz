using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuConfiguracoes : MonoBehaviour
{
    public GameObject painel;

    public void Abrir()
    {
        painel.SetActive(true);
    }

    public void Fechar()
    {
        painel.SetActive(false);
    }
}