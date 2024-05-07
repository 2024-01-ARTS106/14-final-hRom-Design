using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ColliderManager : MonoBehaviour
{
    public Canvas myCanvas;
    public TMP_Text messageText;
    public string currentText;
    public string progressText;
    public bool hasProgress;
    void Start() 
    {
        hasProgress = false;
    }

    private void OnTriggerEnter(Collider player)
    {
        myCanvas.enabled = true;
        if (hasProgress = true)
        {
            messageText.SetText(progressText);
        }
        else if (hasProgress = false)
        {
            messageText.SetText(currentText);
        }
    }

    void OnTriggerExit()
    {
        myCanvas.enabled = false; 
        if (hasProgress = true)
        {
            messageText.SetText(progressText);
        }
        else if (hasProgress = false)
        {
            messageText.SetText(currentText);
        }
    }

}
