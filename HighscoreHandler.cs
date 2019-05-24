using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

//brukes ikke, burde bare slette

public class HighscoreHandler : MonoBehaviour
{
    public TextMeshProUGUI HIscoreText;

    // Start is called before the first frame update
    void Start()
    {
        HIscoreText = GetComponent<TextMeshProUGUI>();
    }
    private void Update()
    {
        HIscoreText.text = PlayerPrefs.GetFloat("Highscore", 0).ToString("0") + "m";
    }
}
