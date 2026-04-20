using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControleBloqueioNivel : MonoBehaviour
{
    public int nivelDoBotao;

    public Button botaoNivel;
    public GameObject imagemCadeado;

    void Start()
    {
        bool desbloqueado = nivelDoBotao <= EstadoQuiz.nivelDesbloqueado;

        botaoNivel.interactable = desbloqueado;
        imagemCadeado.SetActive(!desbloqueado);
    }
}
