using System.Collections;
using System.Collections.Generic;
using UnityEngine; //Bibliotek som er brukt.

public class PlayerMovement : MonoBehaviour  {
    Rigidbody rb; //Variabel for Rigidbody.
    float SpeedM; //Variabel for fart.
    readonly float inputX; //Float (desimaltall, også kalt 32-bit tall) varaibel.
    public float forwardPush = 2000f;
    public float sidePush = 500f;
    public Transform player;
    public PlayerMovement movement;
    // Start is called before the first frame update
    void Start()
    {
       
        //Debug.Log("Player movements initiated..."); //Sender en log melding.


        rb = GetComponent<Rigidbody>(); //Henter rigidbody (Unity fysikk system).
        SpeedM = 4.0f; //Setter verdien til variabelen for fart.
    }
    //Vi lager en ny inndeling med "Fixed" ettersom det er bedre for fysikk, noe vi skal bruke. 
    void FixedUpdate()
    {

        rb.AddForce(0, 0, forwardPush * Time.deltaTime); //Gjør at karakteren blir dyttet frem (Setter en dyttekraft). 
        //Time.Deltatime gjør at hastigheten blir det samme uansett FPS (Bilder per sekund). 


        if (Input.GetKey(KeyCode.LeftArrow)) //Hvis man trykker på høyre museknapp går du til høyre.
        {
            rb.AddForce(-sidePush, 0, 0 * Time.deltaTime);//Setter en kraft mot høyre som flytter spilleren dit.
        }
        if (Input.GetKey(KeyCode.RightArrow)) //Hvis man trykke på venstre museknapp går man til venstre.
        {
            rb.AddForce(sidePush, 0, 0 * Time.deltaTime);//Setter en kraft mot venstre som flytter spilleren dit.
        }

        if (player.position.x < -30) //Hvis x posisjonen din er mer enn -30 skjer dette:
        {
            rb.useGravity = false; //Gravity blir skrudd av.
            rb.constraints = RigidbodyConstraints.FreezeAll; //Du beveger deg ikke mer
            FindObjectOfType<GameManager>().EndGame(); //Finner funksjonen og caller den. Spillet er over.
        }
        else if (player.position.x > 30) //Se if-statement over :P
        {
            rb.useGravity = false;
            rb.constraints = RigidbodyConstraints.FreezeAll;
            FindObjectOfType<GameManager>().EndGame();
        }

        AccelerometerMove(); //Kaller funksjonen AccelerometerMove.
    }
    void AccelerometerMove() //Funksjon som bruker Acellerometer på telefonen din.
    {
        float x = Input.acceleration.x; //setter variabel for x.


        if (x < -0.1f) //Hvis du flytter telefonen -0.1units mot venstre 
        {
            rb.AddForce(-sidePush, 0, 0 * Time.deltaTime); //flytter du deg mot venstre
        }
        else if (x > 0.1f) //Samme som forrige if-statement, bare mot høyre.
        {
            rb.AddForce(sidePush, 0, 0 * Time.deltaTime);
        }
    }



}
