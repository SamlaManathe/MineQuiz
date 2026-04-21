using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class FeedbackFinal : MonoBehaviour
{
    public TMP_Text texto_acertos;
    public TMP_Text texto_desempenho;

    public GameObject[] coracoes; // array com 9 corações

    public void ReiniciarJogo()
    {
        EstadoQuiz.acertosTotal = 0;

        EstadoQuiz.vidasNivel1 = 0;
        EstadoQuiz.vidasNivel2 = 0;
        EstadoQuiz.vidasNivel3 = 0;

        EstadoQuiz.nivelAtual = 1;
        EstadoQuiz.nivelDesbloqueado = 1;

        SceneManager.LoadScene("SceneDificuldade");
    }

    void Start()
    {
        int totalCoracoes = 
            EstadoQuiz.vidasNivel1 +
            EstadoQuiz.vidasNivel2 +
            EstadoQuiz.vidasNivel3;

        // Mostrar acertos
        texto_acertos.text = "Acertos totais: " + EstadoQuiz.acertosTotal + "/15";

        // Ativar corações
        for (int i = 0; i < coracoes.Length; i++)
        {
            coracoes[i].SetActive(i < totalCoracoes);
        }

        // Definir desempenho
        if (totalCoracoes <= 3)
        {
            texto_desempenho.text = "Desempenho: Ruim";
        }
        else if (totalCoracoes <= 5)
        {
            texto_desempenho.text = "Desempenho: Razoável";
        }
        else if (totalCoracoes <= 7)
        {
            texto_desempenho.text = "Desempenho: Bom";
        }
        else
        {
            texto_desempenho.text = "Desempenho: Ótimo";
        }
    }
}