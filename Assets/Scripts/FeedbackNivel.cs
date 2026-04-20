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

    // Start is called before the first frame update
    void Start()
    {
        coracao1.SetActive(false);
        coracao2.SetActive(false);
        coracao3.SetActive(false);
        feedback_nivel.text = "Você não pontuou!";

        if(Questoes.acertos == 1){
            coracao1.SetActive(true);
            feedback_nivel.text = "Você acertou uma!";

        } else if(Questoes.acertos == 2){
            coracao1.SetActive(true);
            coracao2.SetActive(true);
            feedback_nivel.text = "Você acertou duas!";

        } else if(Questoes.acertos == 3){
            coracao1.SetActive(true);
            coracao2.SetActive(true);
            coracao3.SetActive(true);
            feedback_nivel.text = "Você acertou três!";

        } else if(Questoes.acertos == 4){
            coracao1.SetActive(true);
            coracao2.SetActive(true);
            coracao3.SetActive(true);
            feedback_nivel.text = "Você acertou quatro!";
            
        } else if(Questoes.acertos == 5){
            coracao1.SetActive(true);
            coracao2.SetActive(true);
            coracao3.SetActive(true);
            feedback_nivel.text = "Você acertou cinco!";
        }

        Questoes.acertos = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
