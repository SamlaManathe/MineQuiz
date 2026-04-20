// Imports
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Essa classe é static, ou seja:
// - Não precisa ser colocada em nenhum GameObject
// - Seus valores ficam acessíveis em qualquer script pois é "public"

public class EstadoQuiz : MonoBehaviour
{
    public static int acertos = 0;
    public static int vidasRestantes = 3;
}
