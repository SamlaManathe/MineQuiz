using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GerenciaCena : MonoBehaviour
{
    public void CarregarCena(string nomeDaCena)
    {
        SceneManager.LoadScene(nomeDaCena);
    }

    public void Sair()
    {
        Application.Quit();
    }

    public void JogarNivel(int nivel)
    {
        if (nivel > EstadoQuiz.nivelDesbloqueado)
        {
            Debug.Log("Esse nível ainda não foi desbloqueado!");
            return;
        }

        EstadoQuiz.nivelAtual = nivel;
        SceneManager.LoadScene("SceneJogo");
    }
}
