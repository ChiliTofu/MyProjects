using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Klass för att hålla metoder vi kan köra från en Unity UI knapp
public class TriggerInteraction : MonoBehaviour
{
    //Metoden vi vill köra från vår UI knapp.
    public void TriggerInteractionOnClick()
    {
        //Kolla så att vi har en Entity markerad
        if (Selection.Selected != null)
        {
            //Skriv ett meddelande till konsolen om vilken Entity vi har Triggat
            Debug.Log(Selection.Selected.EntityName + " is sooo triggered!");
        }
        else //Annars
        {
            //Meddela oss att vi inte har någon Entity markerad
            Debug.Log("Nothing is selected, therefore nothing to trigger");
        }
    }
}