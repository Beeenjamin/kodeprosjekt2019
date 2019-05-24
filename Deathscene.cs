using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class Deathscene : MonoBehaviour
{
    private TextMeshProUGUI waitText; //Privat variabel for TextMeshPro-elementet
    public int timeLeft = 1; //Int er et helt tall. Dette er en offentlig variabel med verdien 1.

    // Start is called before the first frame update
    void Start()
    {
        waitText = GetComponent<TextMeshProUGUI>(); //Henter TMPro elementet fra objektet.
        StartCoroutine("restartTime"); //Starter funksjonen "RestartTime".
    }

    // Update is called once per frame
    void Update()
    {
        waitText.text = ("Game will restart in... " + timeLeft); //Endrer teksten (som du ikke ser haha).

        if (timeLeft <= 0) //Hvis timeLeft er lik 0 eller mindre enn null stoppes funksjonen og spillet lastes inn
        {
            StopCoroutine("restartTime"); //Stopper funksjonen "restartTime"
            SceneManager.LoadScene(3); //Laster inn Scene nummer 3 i listen(spillet).
        }
    }

    IEnumerator restartTime() //Funksjon som begynne igjen der den sluttet i neste frame selv om den blir stoppet.
    {
        while (true) //Forever loop
        {
            yield return new WaitForSeconds(1); //vent i ett sekund
            timeLeft--; //Trekker fra et tall på inten TimeLeft.
        }
    }
}
