using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CuentaAtrasCAE : MonoBehaviour
{
    public static float tiempoRestante = 85f; // ESTABLECEMOS UN TIEMPO DE PARTIDA DE 1 MINUTO 25 SEGUNDOS
    public Text TxtTiempoRestante;

    public static bool seAcaboElTiempo = false;

    void Start()
    {
        TxtTiempoRestante = GetComponent<Text>();

    }


    void Update()
    {
        //TxtTiempoRestante.text = "Remaining time: " + tiempoRestante;


        if (tiempoRestante > 0)
        {
            tiempoRestante -= Time.deltaTime;
        }

        else
        {
            tiempoRestante = 0;
            seAcaboElTiempo = true;
            //SceneManager.LoadScene("EscnDerrCAE");
        }

        DisplayTime(tiempoRestante);

    }

    void DisplayTime(float tiempoQueSeMuestra)
    {
        if (tiempoQueSeMuestra < 0)
        {
            tiempoQueSeMuestra = 0;
        }

        float minutos = Mathf.FloorToInt(tiempoQueSeMuestra / 60);
        float segundos = Mathf.FloorToInt(tiempoQueSeMuestra % 60);

        TxtTiempoRestante.text = string.Format("[0:00]:[1:00]", minutos, segundos);

        TxtTiempoRestante.text = ">> Remaining time: [" + minutos + "]:" + "[" + segundos + "]";
    }
}
