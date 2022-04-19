using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Proyecto26;
using System.Linq;
using UnityEngine.SceneManagement;

[Serializable]
public class Jugador : MonoBehaviour
{
    // == ANTES QUE NADA, DEJO ESCRITO QUE HABÍA BORRADO EL " : MonoBehaviour"
    // PARA QUE QUEDARA SOLO "class Jugador". ENTONCES CREÉ UN EMPTY OBJECT EN UNITY
    // PARA PODER AGREGAR ESTE SCRIPT Y QUE FUNCIONE, PERO ME TIRÓ
    // UN ERROR QUE DECÍA QUE "Jugador" DEBE HEREDAR DE "Monobehaviour", !!!!!!

    //            //
    /* Atributos */
    //           //    

    public string nombreJugador { get; set; }
    public int scoreLogradoPorJugador { get; set; } = 0;

    //private ContadorPlayerScore accesoAlContadorScore;

    public Jugador() // CONSTRUCTOR; DEFINO ESTAS VARIABLES CON AQUELLAS RESPECTIVAS
                     // DEL SCRIPT "GameManager" PARA QUE LA INFO SE GUARDE EN LA DATABASE
                     
                     // AL FINAL SACAMOS CUALQUIER PARAMETRO PARA VER SI ASÍ EL CODIGO
                     // "GuardadoDeScores" TOMABA A LA CLASE JUGADOR Y EL PUNTAJE OBTENIDO,
                     // GUIANDONOS SEGUN UN PDF QUE VIMOS EN "Simuladores", EN EL TP 1
    {
        //nombreJugador = name;
        //scoreLogradoPorJugador = score;

        nombreJugador = GuardadoDeScores.playerName;
        scoreLogradoPorJugador = GuardadoDeScores.playerScore;     

        //name = GuardadoDeScores.playerName;
        //score = ContadorPlayerScore.scoreDeLaPartida;
        
    }

    
    private void Start()
    {
        
    }

    private void Update()
    {
        
    }

    //            //
    /* Métodos */
    //           //

    public static void SumaDePuntosEnFCE()
    {
        ContadorPlayerScore.scoreDeLaPartida += 5;
        //ContadorDelExamndr.valorSubestimacionExaminador -= 10;
        Examinador.nivelSubestimacionExaminador -= 10;
    }

    public static void SumaDePuntosEnCAE()
    {
        ContadorPlayerScore.scoreDeLaPartida += 10;
        //ContadorDelExamndr.valorSubestimacionExaminador -= 20;
        Examinador.nivelSubestimacionExaminador -= 20;
    }

    public static void SumaDePuntosEnCPE()
    {
        ContadorPlayerScore.scoreDeLaPartida += 100;
        //ContadorDelExamndr.valorSubestimacionExaminador -= 100;
        Examinador.nivelSubestimacionExaminador -= 100;
    }

   

    /* NO SE POR QUÉ ME CERRÓ LA LLAVE DE LA CLASE CUANDO CREE LAS FUNCIONES!!!!! ME DAN ERROR TODOS LOS METODOS!!!!
     * 
     * 
    public void SumarPuntosFCE()
    {
        public int PuntosGanadosEnFCE = 0;

    // ¿ACÁ DEBERÍAMOS HACER LAS COMPROBACIONES? ¿O EN EL 'GameManager.cs'?
    // "if (InputField.text(" ") == RtaCorrectaFCE1.text {
    // LLAMADO A MÉTODO 'SumarPtosFCE()' DE LA CLASE "Jugador.cs"!!!;
    // }"

    }

    public void SumarPuntosCAE()
    {
        public int PuntosGanadosEnCAE = 0;

    // ¿ACÁ DEBERÍAMOS HACER LAS COMPROBACIONES? ¿O EN EL 'GameManager.cs'?
    // "if (InputField.text(" ") == RtaCorrectaFCE1.text {
    // LLAMADO A MÉTODO 'SumarPtosFCE()' DE LA CLASE "Jugador.cs"!!!;
    // }"

    }

    public void SumarPuntosCPE()
    {
        public int PuntosGanadosEnCPE = 0;

    // ¿ACÁ DEBERÍAMOS HACER LAS COMPROBACIONES? ¿O EN EL 'GameManager.cs'?
    // "if (InputField.text(" ") == RtaCorrectaFCE1.text {
    // LLAMADO A MÉTODO 'SumarPtosFCE()' DE LA CLASE "Jugador.cs"!!!;
    // }"

    }
}*/



}

