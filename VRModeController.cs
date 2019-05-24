using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.SceneManagement;

public class VRModeController : MonoBehaviour {

    bool VrActivated = false; //Variabel. Setter til false til å begynne med.


    public void Start () //når skriptet starter.
    {
        if (VrActivated == false) //Hvis VRActivated er false(noe det er til å begynne med)
        {
            StartCoroutine(VRActivator("Cardboard")); //Starter funksjonen VRActivator
        }


    }

    public void Update()
    {
        if (SceneManager.GetActiveScene().name == "DeathScene") //Når du dør lastes denne scenen inn og da skal man skru av vr før man begynner på selve spillet igjen. Viktig for å forhindre lag og glitching
        {
            if (VrActivated == true) //Hvis vr er på caller han funksjonen VRDisabler
            {
                StartCoroutine(VRDisabler("None")); //Se voidstart.
            }
            
        }
    }

    public IEnumerator VRActivator(string VRon) //Funksjon med en string i seg. Denne variabelen har dataen "VRon". Brukes til å laste inn Cardboard VR
    {
            XRSettings.LoadDeviceByName(VRon); //Laster inne cardboard.
            Debug.Log("VR IS ON BOIIIS"); //log mld
            yield return null; //venter til neste frame før koden går videre
            XRSettings.enabled = true; //Skrur på VR
            VrActivated = true; //Endrer bool til å være true

    }

    public IEnumerator VRDisabler(string VRoff) //Motsatte av VRActivator
    {

        XRSettings.LoadDeviceByName(VRoff);
        Debug.Log("VR IS OFF BOIIIS");
        yield return null;
        XRSettings.enabled = false;
        VrActivated = false;

    }
}
