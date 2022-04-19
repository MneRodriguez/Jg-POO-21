using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Proyecto26;
using System.Linq;
using UnityEngine.SceneManagement;

public class GuardadoDeScores : MonoBehaviour
{
    [SerializeField] Text textoScore; // NUM DEL SCORE QUE SE VA A GUARDAR EN LA DATABASE
    public InputField nombreDelJugador; // ESPACIO DONDE EL JUGADOR ESCRIBE SU NOMBRE PARA SER GUARDADO EN LA DATABASE
    //public string URLdeDatabase = "https://jgprogavnzda21empedrodgz-default-rtdb.firebaseio.com/";
    public string URLdeDatabase2 = "https://jgpoo21empedoclerodriguez-default-rtdb.firebaseio.com/";
    public Button btnSubmit;

    private System.Random random = new System.Random();

    Jugador jugador = new Jugador(); // CONSTRUIMOS LA CLASE "Jugador"
    Examinador examinador = new Examinador(Examinador.nivelSubestimacionExaminador); // CONSTRUIMOS LA CLASE "Examinador"
    public static int playerScore;
    public static string playerName;


    //private ContadorPlayerScore accesoAlScorePartida;

    void Start()
    {
        playerScore = ContadorPlayerScore.scoreDeLaPartida;
        textoScore.text = "SCORE FINAL: <" + playerScore + ">, DERROTASTE A TU EXAMINADOR DEJANDOLO CON <" + Examinador.nivelSubestimacionExaminador + "> PUNTOS DE SUBESTIMACION";
    }

    private void UpdateScore() // EN LA PANTALLA DE "Ver score" MOSTRAMOS EL NOMBRE Y PUNTAJE DE 'x' JUGADOR PREVIO QUE FUE GUARDADO EN LA DATABASE
    {
        textoScore.text = "El jugador " + jugador.nombreJugador + " logró " + jugador.scoreLogradoPorJugador + " puntos, y dejó a su examinador con " + Examinador.nivelSubestimacionExaminador + " puntos de subestimacion";
    }
    private void PostToDataBase()
    {
        Jugador jugador = new Jugador(); // NO SE SI CORRESPONDE CREARLO RECIEN ACA O AL PRINCIPIO, COMO EN LA LINEA 20
        // VI QUE SI NO DECLARO EL NEW USER ACA, EN LA DATABASE AL SUBMITTEAR CADA NUEVA PARTIDA JUGADA
        // EL JUGADOR APARECE SIN NOMBRE Y CON SCORE 0!!!!
        Examinador examinador = new Examinador(Examinador.nivelSubestimacionExaminador);
        RestClient.Put(URLdeDatabase2 + playerName + ".json", jugador);
    }
    public void OnSubmit()
    {
        playerName = nombreDelJugador.text;
        PostToDataBase();
    }

    private void RetrieveFromDataBase()
    {
        RestClient.Get<Jugador>(URLdeDatabase2 + nombreDelJugador.text + ".json").Then(response =>
        {
            jugador = response; // LEO DE MANERA INDIVIDUAL CADA USUARIO GUARDADO; ESTO PERMITE QUE EL BOTON "GET SCORE" ANDE
            UpdateScore();
        });
    }
    public void OnGetScore()
    {
        RetrieveFromDataBase();
    }
}
