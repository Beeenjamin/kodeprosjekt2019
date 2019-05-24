using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashController : MonoBehaviour
{
    public static int SceneNr;

    // Start is called before the first frame update
    void Start()
    {
        if (SceneNr == 0) //Hvis variabelen SceneNr er 0 startes Coroutine (funksjon) SecondSplash
        {
            StartCoroutine( SecondSplash() );
        }
        if (SceneNr == 1) //Hvis variabelen SceneNr er 0 startes Coroutine (funksjon) UIScene
        {
            StartCoroutine( UIScene());
        }
     
    }

    IEnumerator SecondSplash () //Info om hva iEnumerator er i deathscene.cs
    {
        yield return new WaitForSeconds(5.6f); //Venter i 5.6 sekunder før den hopper videre.
        SceneNr = 1; //Endrer variabelen SceneNr til 1.
        SceneManager.LoadScene(1); //Laster inn scenen Splash-Screen 2 (Music)
    }

    IEnumerator UIScene() //Info om hva iEnumerator er i deathscene.cs
    {
        yield return new WaitForSeconds(5.4f);
        SceneNr = 2; //Endrer variabelen SceneNr til 2.
        SceneManager.LoadScene(2); //Laster scene nummer to i listen (UI)
    }

    public void Skip() //Lager en fuksjon som vi senere "caller" til for å bruke koden i den.
    {
        SceneManager.LoadScene(2); //hopper til neste scene i listen, altså selve spillet.

    }
}
