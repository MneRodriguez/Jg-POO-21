using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Proyecto26;
using System.Linq;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //private Jugador accesoAlMetodoSumaPuntosSegunModalidad;
    //private ContadorPlayerScore tomarScoreDePartida;

    //public static int scoreDeLaPartida = 0; // SI NO ERA 'static', NO PODIA LLAMARLO DESDE OTROS SCRIPTS, PERO SI ES STATIC, NO PUEDO REFERENCIARLO EN EL INSPECTOR!!!!
    //public static int valorSubestimacionExaminador = 100;

    //public TextMesh txtScoreJgdrEnNumero, txtNivelSubestimacionExaminador;

    
    // EN ESTOS STRINGS QUEDAN DEFINIDAS LAS ORACIONES QUE SE ESPERAN QUE EL USUARIO ESCRIBA PARA ACERTAR

    // PARA 'FCE', EL TOTAL DE PUNTOS ES 25 (porque c/u vale 5), Y EL MINIMO PARA GANAR EL NIVEL SERIA 15 (acertar 3)
    public string        RtaCorrectaFCE1 = "sharpener", 
                         RtaCorrectaFCE2 = "sharply", 
                         RtaCorrectaFCE3 = "sharpened", 
                         RtaCorrectaFCE4 = "suggest you join", 
                         RtaCorrectaFCE5 = "keep",
        
                         RtaCorrectaCAE1 = "understate", 
                         RtaCorrectaCAE2 = "statement", 
                         RtaCorrectaCAE3 = "understatement", 
                         RtaCorrectaCAE4 = "scaled", 
                         RtaCorrectaCAE5 = "block",

                         RtaCorrectaCPE = "work";

    // DEBAJO, CAMBIARLE 'string' por 'InputField' ESTOS DE ABAJO SERIAN LOS STRINGS INGRESADOS POR EL JUGADOR,
    // QUE SE TOMAN DESDE LOS INPUT FIELDS
    public InputField RtaJgdrParaFCE1, RtaJgdrParaFCE2, RtaJgdrParaFCE3, RtaJgdrParaFCE4, RtaJgdrParaFCE5,
                      RtaJgdrParaCAE1, RtaJgdrParaCAE2, RtaJgdrParaCAE3, RtaJgdrParaCAE4, RtaJgdrParaCAE5,
                      RtaJgdrParaCPE;

    
    public GameObject BtnResponderFCE1, 
                      BtnResponderFCE2, 
                      BtnResponderFCE3, 
                      BtnResponderFCE4, 
                      BtnResponderFCE5, 
        
                      BtnResponderCAE1, 
                      BtnResponderCAE2, 
                      BtnResponderCAE3, 
                      BtnResponderCAE4, 
                      BtnResponderCAE5,

                      BtnResponderCPE;

    void Start()
    {
        Jugador jugador = new Jugador(); // AL NUEVO OBJETO LE ASIGNO POR DEFECTO VALORES string E int PARA LAS VARIABLES RESPECTIVAS DE LA CLASE DEFINIDA EN EL SCRIPT "Jugador"

        //accesoAlMetodoSumaPuntosSegunModalidad = GetComponent<Jugador>(); // CON ESTA LINEA ACCEDEMOS O ENVIAMOS UN MENSAJE AL METODO DE LA CLASE "Jugador.cs"


        //RtaJgdrParaFCE1 = GetComponent<InputField>();

        //BtnResponderFCE1 = GetComponent<GameObject>();
        //BtnResponderCPE = GetComponent<Button>();


        //Debug.Log(jugador);


        //txtScoreJgdrEnNumero = GameObject.FindWithTag("TxtScorePlayer").GetComponent<TextMesh>();
        //txtNivelSubestimacionExaminador = GameObject.FindWithTag("TxtSubestimExamndr").GetComponent<TextMesh>();

        //txtScoreJgdrEnNumero = GetComponent<TextMesh>();
        //txtNivelSubestimacionExaminador = GetComponent<TextMesh>();
    }

    
    void Update()
    {

        // ACÁ HACER LAS COMPROBACIONES
        // "if (InputField.text(" ") == RtaCorrectaFCE1.text {
        // LLAMADO A MÉTODO 'SumarPtosFCE()' DE LA CLASE "Jugador.cs"!!!;
        // }"
                

        if (ContadorPlayerScore.scoreDeLaPartida >= 15 && CuentaAtrasFCE.seAcaboElTiempo)
        {
            SceneManager.LoadScene("EscnVictFCE");
        }
        if (ContadorPlayerScore.scoreDeLaPartida < 15 && CuentaAtrasFCE.seAcaboElTiempo)
        {
            SceneManager.LoadScene("EscnDerrFCE");
        }


        if (ContadorPlayerScore.scoreDeLaPartida >= 40 && CuentaAtrasCAE.seAcaboElTiempo)
        {
            SceneManager.LoadScene("EscnVictCAE");
        }
        if (ContadorPlayerScore.scoreDeLaPartida < 40 && CuentaAtrasCAE.seAcaboElTiempo)
        {
            SceneManager.LoadScene("EscnDerrCAE");
        }


        if (ContadorPlayerScore.scoreDeLaPartida == 100 && CuentaAtrasCPE.seAcaboElTiempo)
        {
            SceneManager.LoadScene("EscnVictCPE");
        }
        if (ContadorPlayerScore.scoreDeLaPartida !=100 && CuentaAtrasCPE.seAcaboElTiempo)
        {
            SceneManager.LoadScene("EscnDerrCPE");
        }
    }


    
    //** BOTONES PARA RESPONDER EN 1er NIVEL 'FCE' **//

    public void ResponderFCE1() //CHEQUEA SI EL TEXTO INGRESADO EN EL INPUT FIELD COINCIDE CON EL STRING GUARDADO POR DEFECTO...
    {       
        if (RtaJgdrParaFCE1.text == RtaCorrectaFCE1)
        {
            RtaJgdrParaFCE1.text = "sharpener -CORRECT!";
            Jugador.SumaDePuntosEnFCE(); // ENVIAMOS UN MSJ AL METODO DE LA CLASE "Jugador" CON EL FIN DE LLAMARLA Y QUE ENTRE EN FUNCIONAMIENTO
            RtaJgdrParaFCE1.enabled = false; // BLOQUEAMOS EL INPUTFIELD SI RESPONDIMOS BIEN
            Destroy(BtnResponderFCE1);

        }
        else
        {
            RtaJgdrParaFCE1.text = "try again...";
            RtaJgdrParaFCE1.enabled = true;
        }
                
    }

    public void ResponderFCE2()
    {
        if (RtaJgdrParaFCE2.text == RtaCorrectaFCE2)
        {
            RtaJgdrParaFCE2.text = "sharply -CORRECT!";
            Jugador.SumaDePuntosEnFCE();
            RtaJgdrParaFCE2.enabled = false;
            Destroy(BtnResponderFCE2);
        }
        else
        {
            RtaJgdrParaFCE2.text = "try again...";
            RtaJgdrParaFCE2.enabled = true;
        }
    }

    public void ResponderFCE3()
    {
        if (RtaJgdrParaFCE3.text == RtaCorrectaFCE3)
        {
            RtaJgdrParaFCE3.text = "sharpened -CORRECT!";
            Jugador.SumaDePuntosEnFCE();
            RtaJgdrParaFCE3.enabled = false;
            Destroy(BtnResponderFCE3);
        }
        else
        {
            RtaJgdrParaFCE3.text = "try again...";
            RtaJgdrParaFCE3.enabled = true;
        }
    }

    public void ResponderFCE4()
    {
        if (RtaJgdrParaFCE4.text == RtaCorrectaFCE4 || RtaJgdrParaFCE4.text == "suggest you should join")
        {
            RtaJgdrParaFCE4.text = "suggest you (should) join -CORRECT!";
            Jugador.SumaDePuntosEnFCE();
            RtaJgdrParaFCE4.enabled = false;
            Destroy(BtnResponderFCE4);
        }
        else
        {
            RtaJgdrParaFCE4.text = "try again...";
            RtaJgdrParaFCE4.enabled = true;
        }
    }

    public void ResponderFCE5()
    {
        if (RtaJgdrParaFCE5.text == RtaCorrectaFCE5)
        {
            RtaJgdrParaFCE5.text = "keep -CORRECT!";
            Jugador.SumaDePuntosEnFCE();
            RtaJgdrParaFCE5.enabled = false;
            Destroy(BtnResponderFCE5);
        }
        else
        {
            RtaJgdrParaFCE5.text = "try again...";
            RtaJgdrParaFCE5.enabled = true;
        }
    }


    //** BOTONES PARA RESPONDER EN 2do NIVEL 'CAE' **//

    public void ResponderCAE1()
    {
        if (RtaJgdrParaCAE1.text == RtaCorrectaCAE1)
        {
            RtaJgdrParaCAE1.text = "understate -CORRECT!";
            Jugador.SumaDePuntosEnCAE();
            RtaJgdrParaCAE1.enabled = false;
            Destroy(BtnResponderCAE1);
        }
        else
        {
            RtaJgdrParaCAE1.text = "try again...";
            RtaJgdrParaCAE1.enabled = true;
        }
    }
    public void ResponderCAE2()
    {
        if (RtaJgdrParaCAE2.text == RtaCorrectaCAE2)
        {
            RtaJgdrParaCAE2.text = "statement -CORRECT!";
            Jugador.SumaDePuntosEnCAE();
            RtaJgdrParaCAE2.enabled = false;
            Destroy(BtnResponderCAE2);
        }
        else
        {
            RtaJgdrParaCAE2.text = "try again...";
            RtaJgdrParaCAE2.enabled = true;
        }
    }
    public void ResponderCAE3()
    {
        if (RtaJgdrParaCAE3.text == RtaCorrectaCAE3)
        {
            RtaJgdrParaCAE3.text = "understatement -CORRECT!";
            Jugador.SumaDePuntosEnCAE();
            RtaJgdrParaCAE3.enabled = false;
            Destroy(BtnResponderCAE3);
        }
        else
        {
            RtaJgdrParaCAE3.text = "try again...";
            RtaJgdrParaCAE3.enabled = true;
        }
    }
    public void ResponderCAE4()
    {
        if (RtaJgdrParaCAE4.text == RtaCorrectaCAE4)
        {
            RtaJgdrParaCAE4.text = "scaled -CORRECT!";
            Jugador.SumaDePuntosEnCAE();
            RtaJgdrParaCAE4.enabled = false;
            Destroy(BtnResponderCAE4);
        }
        else
        {
            RtaJgdrParaCAE4.text = "try again...";
            RtaJgdrParaCAE4.enabled = true;
        }
    }
    public void ResponderCAE5()
    {
        if (RtaJgdrParaCAE5.text == RtaCorrectaCAE5)
        {
            RtaJgdrParaCAE5.text = "block -CORRECT!";
            Jugador.SumaDePuntosEnCAE();
            RtaJgdrParaCAE5.enabled = false;
            Destroy(BtnResponderCAE5);
        }
        else
        {
            RtaJgdrParaCAE5.text = "try again...";
            RtaJgdrParaCAE5.enabled = true;
        }
    }


    //** BOTON PARA RESPONDER EN 3er NIVEL 'CPE' **//
    public void ResponderCPE()
    {
        if (RtaJgdrParaCPE.text == RtaCorrectaCPE)
        {
            RtaJgdrParaCPE.text = "work -CORRECT!";
            Jugador.SumaDePuntosEnCPE();
            RtaJgdrParaCPE.enabled = false;
            Destroy(BtnResponderCPE);
        }
        else
        {
            RtaJgdrParaCPE.text = "try again...";
            RtaJgdrParaCPE.enabled = true;
        }
    }
}
