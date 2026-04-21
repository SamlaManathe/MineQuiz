using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class FeedbackNivel : MonoBehaviour
{
    public GameObject coracao1;
    public GameObject coracao2;
    public GameObject coracao3;

    public TMP_Text feedback_nivel;
    public TMP_Text texto_acertos;
    public TMP_Text texto_botao;

    void Start()
    {
        Debug.Log("Vidas que chegaram no feedback: " + EstadoQuiz.vidasRestantes);
        Debug.Log("Acertos que chegaram no feedback: " + EstadoQuiz.acertos);

        // SALVAR vidas por nível
        if (EstadoQuiz.nivelAtual == 1)
        {
            EstadoQuiz.vidasNivel1 = EstadoQuiz.vidasRestantes;
        }
        else if (EstadoQuiz.nivelAtual == 2)
        {
            EstadoQuiz.vidasNivel2 = EstadoQuiz.vidasRestantes;
        }
        else if (EstadoQuiz.nivelAtual == 3)
        {
            EstadoQuiz.vidasNivel3 = EstadoQuiz.vidasRestantes;
        }

        // SOMAR acertos
        EstadoQuiz.acertosTotal += EstadoQuiz.acertos;

        AtualizarCoracoes();

        texto_acertos.text = "Acertos: " + EstadoQuiz.acertos + "/5";

        if (EstadoQuiz.vidasRestantes > 0)
        {
            if(EstadoQuiz.nivelAtual < 3)
            {
                feedback_nivel.text = "Você passou de nível!";
                texto_botao.text = "Próximo nível";
            }
            else if (EstadoQuiz.nivelAtual == 3)
            {
                feedback_nivel.text = "Você finalizou todos os níveis!";
                texto_botao.text = "Feedback final";
            }
            
            if (EstadoQuiz.nivelAtual == 1 && EstadoQuiz.nivelDesbloqueado < 2)
            {
                EstadoQuiz.nivelDesbloqueado = 2;
            }
            else if (EstadoQuiz.nivelAtual == 2 && EstadoQuiz.nivelDesbloqueado < 3)
            {
                EstadoQuiz.nivelDesbloqueado = 3;
            }
        }
        else
        {
            feedback_nivel.text = "Você perdeu!";
            texto_botao.text = "Tentar novamente";
        }
    }

    public void AcaoBotao()
{
    if (EstadoQuiz.vidasRestantes > 0)
    {
        if (EstadoQuiz.nivelAtual < 3)
        {
            EstadoQuiz.nivelAtual++;
            SceneManager.LoadScene("SceneJogo");
        }
        else
        {
            SceneManager.LoadScene("SceneFeedbackFinal");
        }
    }
    else
    {
        SceneManager.LoadScene("SceneJogo");
    }
}
        
    void AtualizarCoracoes()
    {
        coracao1.SetActive(EstadoQuiz.vidasRestantes >= 1);
        coracao2.SetActive(EstadoQuiz.vidasRestantes >= 2);
        coracao3.SetActive(EstadoQuiz.vidasRestantes >= 3);
    }
}
