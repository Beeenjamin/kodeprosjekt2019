using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclCreator : MonoBehaviour
{
    public GameObject obstacle; //Variabel for spillobjektet Obstacle.
    public float xPos; //Float er et desimaltall. Lager en float variabel xPos
    public float zPos;//Float er et desimaltall. Lager en float variabel zPos
    public int obstacleCount; //Int (helt tall) for hvor mange hinder det er på banen.
    public GameObject player; //Variabel for spillobjektet spiller. Lar oss definere det i Editor.


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(obstacleDrop()); //Starter funksjonen obstacleDrop
    }

    IEnumerator obstacleDrop() //Info om hva iEnumerator er i deathscene.cs
    {
        while (true) //For alltid loop.
        {
            xPos = Random.Range(-30, 30); //Setter variabelen xPos til noe tilfeldig mellom x-30 og x30
            zPos = Random.Range(player.transform.position.z + 100, player.transform.position.z + 3245); //Setter zPos til noe tilfeldig minst 100 plasser fra spilleren og max 3245 plasser fra spilleren.
            Instantiate(obstacle, new Vector3(xPos, 1, zPos), Quaternion.identity); //Instantiate spawner inn hinder Prefab på en Vector3 (tre tall, som oftest x,y,z). Quaternion.identity sier basically at objektet ikke skal spawne rotert.
            yield return new WaitForSeconds(1.4f); //venter i 1.4 sekunder, gjør at den spawner inn hinder vært 1.4de sekund.
            obstacleCount += 1; //legger til en på obstacleCount variabelen.
        }
    }
}
