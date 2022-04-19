using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContadorPlayerScore : MonoBehaviour
{
    public static int scoreDeLaPartida = 0; // LO PONEMOS COMO STATIC PARA QUE PUEDA SER ACCEDIDO DESDE OTROS SCRIPTS
    public static Text txtScoreJgdrEnNumero;

    
    void Start()
    {
        txtScoreJgdrEnNumero = GetComponent<Text>();
        
    }

    
    void Update()
    {
        txtScoreJgdrEnNumero.text = "Your score: " + scoreDeLaPartida;
        
    }
}
