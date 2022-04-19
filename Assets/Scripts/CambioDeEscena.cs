using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Proyecto26;
using System.Linq;
using UnityEngine.SceneManagement;

public class CambioDeEscena : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void CargaScene(string nombreEscenaDeJuego)
    {
        // CADA VEZ QUE CAMBIEMOS DE ESCENA, ESTEMOS EN UNA ESCENA DE PARTIDA O NO,
        // RESETEAMOS TODAS LAS VARIABLES A SUS VALORES INICIALES.
        // SABEMOS QUE HACERLO ACÁ DE ESTA FORMA PUEDE SER POCO ORTODOXO
                                                             
        SceneManager.LoadScene(nombreEscenaDeJuego);

        ContadorPlayerScore.scoreDeLaPartida = 0;
        Examinador.nivelSubestimacionExaminador = 100;

        CuentaAtrasFCE.tiempoRestante = 85f;
        CuentaAtrasCAE.tiempoRestante = 85f;
        CuentaAtrasCPE.tiempoRestante = 85f;
    }
}
