using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    public void OnCollisionEnter(Collision collisionInfo) //Method/funksjon som gjør ting når et objekt treffer et annet objekt. Lager i tillegg en variabel inne i parantes.
    {
        if (collisionInfo.collider.tag == "Obstacle") //Hvis du treffer noe med taggen Obstacle skjer det noe
        {
            //Debug.Log("Du traff " + collisionInfo.collider.tag + "!");
            movement.enabled = false; //Skrur av bevegelse.
            FindObjectOfType<GameManager>().EndGame(); //Finner GameManager objektet og caller funksjonen EndGame som avslutter spillet.

        }
    }

}
