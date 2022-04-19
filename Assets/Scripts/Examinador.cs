using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Proyecto26;
using System.Linq;
using UnityEngine.SceneManagement;

public class Examinador : MonoBehaviour
{
    public static int nivelSubestimacionExaminador { get; set; } = 100;
    public Text txtNivelSubestimacionExaminador;

    public Examinador(int cantSubestimacion)
    {
        nivelSubestimacionExaminador = cantSubestimacion;
    }

    void Start()
    {
        txtNivelSubestimacionExaminador = GetComponent<Text>();
    }

    
    void Update()
    {
        txtNivelSubestimacionExaminador.text = "Examiner's underestimation level: " + nivelSubestimacionExaminador;
    }
}
