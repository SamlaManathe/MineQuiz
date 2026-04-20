using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FeedbackNivel : MonoBehaviour
{
    public GameObject coracao1;
    public GameObject coracao2;
    public GameObject coracao3;

    public TMP_Text feedback_nivel;
    public TMP_Text texto_acertos;

    void Start()
    {
        Debug.Log("Vidas que chegaram no feedback: " + EstadoQuiz.vidasRestantes);
        Debug.Log("Acertos que chegaram no feedback: " + EstadoQuiz.acertos);

        AtualizarCoracoes();

        texto_acertos.text = "Acertos: " + EstadoQuiz.acertos + "/5";

        if (EstadoQuiz.vidasRestantes > 0)
        {
            feedback_nivel.text = "Você passou de nível!";
        }
        else
        {
            feedback_nivel.text = "Você perdeu!";
        }
    }
        
    void AtualizarCoracoes()
    {
        coracao1.SetActive(EstadoQuiz.vidasRestantes >= 1);
        coracao2.SetActive(EstadoQuiz.vidasRestantes >= 2);
        coracao3.SetActive(EstadoQuiz.vidasRestantes >= 3);
    }
}
