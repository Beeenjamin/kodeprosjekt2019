using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR;


public class ButtonHandler : MonoBehaviour
{

    public void PlayGame() //Lager en fuksjon som vi senere "caller" til for å bruke koden i den.
    {
        SceneManager.LoadScene(3); //hopper til neste scene i listen, altså selve spillet.


    }

    public void ExitGame() //funksjon som brukes på knapp
    {
        Application.Quit(); //lukker appen
        //Debug.Log("Game Terminated"); //sender en melding til loggen om at spillet lukker seg.
    }
    public void ResetHighscore() //Funksjon for å resette highscore. Brukes på knapp
    {
        PlayerPrefs.SetFloat("Highscore", 0); //Setter PlayerPrefs (info som lagres på datamaskinen) variabelen til 0
        Debug.Log("Highscore reset"); //log melding
    }

}
