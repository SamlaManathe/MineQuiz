using UnityEngine;
using UnityEngine.UI;

public class ControleFundo : MonoBehaviour
{
    public Image ImageBackground; 

    public Sprite fundoOverworld;
    public Sprite fundoNether;
    public Sprite fundoEnd;

    void Start()
    {
        if (EstadoQuiz.nivelAtual == 1)
        {
            ImageBackground.sprite = fundoOverworld;
        }
        else if (EstadoQuiz.nivelAtual == 2)
        {
            ImageBackground.sprite = fundoNether;
        }
        else if (EstadoQuiz.nivelAtual == 3)
        {
            ImageBackground.sprite = fundoEnd;
        }
    }
}
