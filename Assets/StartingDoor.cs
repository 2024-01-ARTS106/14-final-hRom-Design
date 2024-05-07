using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StartingDoor : MonoBehaviour
{
    public Canvas myCanvas;
    public TMP_Text messageText;
    public string startingText;
    public string progressText;
    void Start()
    {
        messageText.SetText(startingText);
    }

    private void OnTriggerExit(Collider Player)
    {
        myCanvas.enabled = false;
        messageText.SetText(progressText);
    }

    void OnTriggerEnter(Collider Player)
    {
        myCanvas.enabled = true;
    }
}
