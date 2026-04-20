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

    private int questao = 1;

    public static int acertos = 0;

    public Button botao_alternativa_a;
    public Button botao_alternativa_b;
    public Button botao_alternativa_c;
    public Button botao_alternativa_d;

    public void MudarQuestao()
    {
        questao++;
    }

    void Start()
    {
        
        perguntas.Add(new string[] {
            "Qual n�vel de experi�ncia � necess�rio para minerar diamante?",
            "Qualquer n�vel", // correta
            "Acima do n�vel 50",
            "Abaixo do n�vel 16",
            "Apenas no n�vel 0"
        });

        perguntas.Add(new string[] {
            "Qual ferramenta � necess�ria para coletar obsidiana?",
            "Qualquer ferramenta",
            "Picareta de ferro",
            "Picareta de diamante", // correta
            "Machado de diamante"
        });

        perguntas.Add(new string[] {
            "Qual a forma de ativar um portal do Nether?",
            "Lava",
            "�gua",
            "Isqueiro apenas",
            "Qualquer fonte de fogo" // correta
        });

        perguntas.Add(new string[] {
            "Qual desses mobs dropam p�lvora ao morrer?",
            "Zumbi",
            "Creeper", //correta
            "Esqueleto",
            "Blaze"
        });

        perguntas.Add(new string[] {
            "Quantos blocos de obsidiana s�o necess�rios (m�nimo) para fazer um portal do Nether",
            "8",
            "10", // correta
            "12",
            "14"
        });

        if(questao == 1){
            botao_alternativa_a.onClick.AddListener(AlternativaCorreta);

        } else if(questao == 2){
            botao_alternativa_c.onClick.AddListener(AlternativaCorreta);

        } else if(questao == 3){
            botao_alternativa_d.onClick.AddListener(AlternativaCorreta);

        } else if(questao == 4){
            botao_alternativa_b.onClick.AddListener(AlternativaCorreta);

        } else if(questao == 5){
            botao_alternativa_b.onClick.AddListener(AlternativaCorreta);
        }
    }

    void AlternativaCorreta()
    {
        acertos = acertos + 1;
        Debug.Log("Acertou!");
        Debug.Log(acertos);
    }

    void Update()
    {
        if (questao == 1)
        {
            pergunta.text = perguntas[0][0];
            alternativa_a.text = perguntas[0][1];
            alternativa_b.text = perguntas[0][2];
            alternativa_c.text = perguntas[0][3];
            alternativa_d.text = perguntas[0][4];
        }

        if (questao == 2)
        {
            pergunta.text = perguntas[1][0];
            alternativa_a.text = perguntas[1][1];
            alternativa_b.text = perguntas[1][2];
            alternativa_c.text = perguntas[1][3];
            alternativa_d.text = perguntas[1][4];
        }

        if (questao == 3)
        {
            pergunta.text = perguntas[2][0];
            alternativa_a.text = perguntas[2][1];
            alternativa_b.text = perguntas[2][2];
            alternativa_c.text = perguntas[2][3];
            alternativa_d.text = perguntas[2][4];
        }

        if (questao == 4)
        {
            pergunta.text = perguntas[3][0];
            alternativa_a.text = perguntas[3][1];
            alternativa_b.text = perguntas[3][2];
            alternativa_c.text = perguntas[3][3];
            alternativa_d.text = perguntas[3][4];
        }

        if (questao == 5)
        {
            pergunta.text = perguntas[4][0];
            alternativa_a.text = perguntas[4][1];
            alternativa_b.text = perguntas[4][2];
            alternativa_c.text = perguntas[4][3];
            alternativa_d.text = perguntas[4][4];
        }

        else if (questao > 5)
        {
            SceneManager.LoadScene("SceneFeedbackNivel");
        }
    }
}
