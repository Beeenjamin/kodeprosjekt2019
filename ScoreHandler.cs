using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ScoreHandler : MonoBehaviour
{

    public Transform Player; //Variabel
    public TextMeshProUGUI scoreText; //Variabel

    private void Start()
    {
        scoreText = GetComponent<TextMeshProUGUI>(); //Finner TMPro komponent i Gameobject koden er på.
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = Player.position.z.ToString("0")+"m"; //Henter spillerposisjonen og oppdaterer teksten hver frame (bilde) til å vise hvor mange meter/units du har reist på z-aksen.
    }
}
