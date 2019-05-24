using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeeperOfMusic : MonoBehaviour
{
    void Awake() //Når nye scene åpner/spillet starter
    {
        DontDestroyOnLoad(transform.gameObject); //Ikke ødelegg musikken når en scene byttes.
    }
}
