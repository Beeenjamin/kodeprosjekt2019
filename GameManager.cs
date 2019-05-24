using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR;

public class GameManager : MonoBehaviour
{
    bool gameOver = false; //Bool er en type variabel med to verdier (false/true).
    public float restartDelay = 5f; //Float er en type variabel som inneholder desimaltall.


    public void EndGame() //Funksjon som blir brukt når spillet er over(du dør).
    {
        if (gameOver == false) //Sjekker om gameOver variabelen er false, om den er gjør den noe.
        {
            gameOver = true; //Setter gameOver til true.
            Debug.Log("Game over"); //Sender log melding.
            Invoke("Restart", restartDelay); //Venter i restartDelay (variabel man kan endre i Editor) så kaller han RestartGame funksjonen.
        }

    }
    void Restart() //Funksjon som starter spillet på nytt.
    {
        SceneManager.LoadScene(4); //Laster inn GameOver scenen.
        Debug.Log("GAME RESTARTED"); //Sender log melding
    }

}
