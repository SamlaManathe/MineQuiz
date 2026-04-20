using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Questoes : MonoBehaviour
{
    private List<string[]> perguntas = new List<string[]>();

    public TMP_Text pergunta;
    public TMP_Text alternativa_a;
    public TMP_Text alternativa_b;
    public TMP_Text alternativa_c;
    public TMP_Text alternativa_d;

    private int questao = 0;

    public Button botao_alternativa_a;
    public Button botao_alternativa_b;
    public Button botao_alternativa_c;
    public Button botao_alternativa_d;

    public GameObject coracao1;
    public GameObject coracao2;
    public GameObject coracao3;

    void Start()
    {
        EstadoQuiz.acertos = 0;
        EstadoQuiz.vidasRestantes = 3;

        perguntas.Add(new string[] {
            "Qual nível de experiência é necessário para minerar diamante?",
            "Qualquer nível", // correta
            "Acima do nível 50",
            "Abaixo do nível 16",
            "Apenas no nível 0"
        });

        perguntas.Add(new string[] {
            "Qual ferramenta é necessária para coletar obsidiana?",
            "Qualquer ferramenta",
            "Picareta de ferro",
            "Picareta de diamante", // correta
            "Machado de diamante"
        });

        perguntas.Add(new string[] {
            "Qual a forma de ativar um portal do Nether?",
            "Lava",
            "Água",
            "Isqueiro apenas",
            "Qualquer fonte de fogo" // correta
        });

        perguntas.Add(new string[] {
            "Qual desses mobs dropam pólvora ao morrer?",
            "Zumbi",
            "Creeper", //correta
            "Esqueleto",
            "Blaze"
        });

        perguntas.Add(new string[] {
            "Quantos blocos de obsidiana são necessários (mínimo) para fazer um portal do Nether",
            "8",
            "10", // correta
            "12",
            "14"
        });

        botao_alternativa_a.onClick.RemoveAllListeners();
        botao_alternativa_b.onClick.RemoveAllListeners();
        botao_alternativa_c.onClick.RemoveAllListeners();
        botao_alternativa_d.onClick.RemoveAllListeners();

        botao_alternativa_a.onClick.AddListener(() => VerificarResposta(0));
        botao_alternativa_b.onClick.AddListener(() => VerificarResposta(1));
        botao_alternativa_c.onClick.AddListener(() => VerificarResposta(2));
        botao_alternativa_d.onClick.AddListener(() => VerificarResposta(3));
    
        AtualizarCoracoes();
        MostrarQuestao();
    }

    void MostrarQuestao()
    {
        if (questao < perguntas.Count)
        {
            pergunta.text = perguntas[questao][0];
            alternativa_a.text = perguntas[questao][1];
            alternativa_b.text = perguntas[questao][2];
            alternativa_c.text = perguntas[questao][3];
            alternativa_d.text = perguntas[questao][4];
        }
        else
        {
            SceneManager.LoadScene("SceneFeedbackNivel");
        }
    }

    void VerificarResposta(int alternativaEscolhida)
    {
        int alternativaCorreta = PegarIndiceRespostaCorreta();

        if (alternativaEscolhida == alternativaCorreta)
        {
            EstadoQuiz.acertos++;
            Debug.Log("Acertou!");
        }
        else
        {
            EstadoQuiz.vidasRestantes--;
            AtualizarCoracoes();
            Debug.Log("Errou!");
        }

        if (EstadoQuiz.vidasRestantes <= 0)
        {
            SceneManager.LoadScene("SceneFeedbackNivel");
            return;
        }

        questao++;
        MostrarQuestao();
    }

    void AtualizarCoracoes()
    {
        coracao1.SetActive(EstadoQuiz.vidasRestantes >= 1);
        coracao2.SetActive(EstadoQuiz.vidasRestantes >= 2);
        coracao3.SetActive(EstadoQuiz.vidasRestantes >= 3);
    }

    int PegarIndiceRespostaCorreta()
    {
        if (questao == 0)
        {
            return 0; // letra "a"
        }
        else if (questao == 1)
        {
            return 2; // letra "c"
        }
        else if (questao == 2)
        {
            return 3; // letra "d"
        }
        else if (questao == 3)
        {
            return 1; // letra "b"
        }
        else if (questao == 4)
        {
            return 1; // letra "b"
        }

        return -1; // Retorna -1 se não encontrar uma resposta correta (caso de erro)
    }


}
