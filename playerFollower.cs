using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerFollower : MonoBehaviour
{
    public Transform player; // Variabel til spilleren. Lar oss endre posisjonen.
    public Vector3 cameraDelay; //Vector3 (tre tall) variabel.
    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + cameraDelay; //Setter kameraposisjonen inne i spilleren (player.position)
        //, men øker den med litt siden vi skal ikke ha first person (cameraDelay) som er en variabel som lar oss
        //endre posisjonen til kameraet.
    }
}
