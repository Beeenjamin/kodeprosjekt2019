using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonhandle : MonoBehaviour
{
    public void PlayGame() //Lager en fuksjon som vi senere "caller" til for å bruke koden i den.
    {
        SceneManager.LoadScene("UI"); //hopper til neste scene i listen, altså selve spillet.

    }
}
