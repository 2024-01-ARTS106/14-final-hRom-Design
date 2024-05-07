using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BathroomDoor : MonoBehaviour
{
    public Canvas myCanvas;
    public TMP_Text messageText;
    void Start() 
    {
        myCanvas.enabled = false;
    }

    private void OnTriggerEnter(Collider player)
    {
        myCanvas.enabled = true;
        messageText.SetText("That's the bathroom door. I don't need anything from in there.");
    }

    void OnTriggerExit()
    {
        myCanvas.enabled = false; 
    }

}
