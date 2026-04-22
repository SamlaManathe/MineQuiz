using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleAudio : MonoBehaviour
{
    public AudioSource musicaFundo;
    private bool mutado = false;

    public void AlternarMusica()
    {
        mutado = !mutado;
        musicaFundo.mute = mutado;
    }

}
