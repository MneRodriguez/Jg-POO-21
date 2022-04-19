using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContadorDelExamndr : MonoBehaviour
{
    public static int valorSubestimacionExaminador = 100;
    public Text txtNivelSubestimacionExaminador;

    void Start()
    {
        txtNivelSubestimacionExaminador = GetComponent<Text>();
    }

    
    void Update()
    {
        txtNivelSubestimacionExaminador.text = "Examiner's underestimation level: " + valorSubestimacionExaminador;
    }
}
