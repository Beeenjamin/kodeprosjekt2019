using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HighScoreHandler : MonoBehaviour
{
    public TextMeshProUGUI HIscoreText; //Variabel for HighScoreTeksten.
    public Transform Player; //Variabel for spilleren, kan endres i Unity Editor og i denne konteksten blir den brukt til å sjekke spilleren sin posisjon.
    void Start() //Method/Funksjon som blir kalt når spillet starter.
    {
        HIscoreText = GetComponent<TextMeshProUGUI>(); //Henter TMPro komponentet fra objektet.
        HIscoreText.text = PlayerPrefs.GetFloat("Highscore", 0).ToString("0") + "m; Your HighScore"; //Henter PlayerPrefs variabelen som inneholder informasjon om highscoren din og konverterer det til helt tall og endrer HighScore tekstelementet.
    }

    void Update()
    {
        if (Player.position.z > PlayerPrefs.GetFloat("Highscore", -1)) //Sjekker om spillerposisjonen er større enn Highscore variabelen, om den er endrer den verdien.
        {
            PlayerPrefs.SetFloat("Highscore", Player.position.z); //Endrer verdien til variabelen.
            HIscoreText.text = Player.position.z.ToString("0") + "m"; //Endrer tekstelementet som viser highscore og konverterer det til en string (tekst) samtidig som den runder av tallet.
        }
        
    }
}
