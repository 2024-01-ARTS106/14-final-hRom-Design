using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SocialPlatforms;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class BedroomDoor : MonoBehaviour
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

    public void loadEnding()
    {
        SceneManager.LoadScene("endScreen");
    }

    private void OnTriggerEnter(Collider player)
    {
        myCanvas.enabled = true;

        if (hasProgress == true)
        {
            messageText.SetText(progressText);

                if (Input.GetKeyDown(KeyCode.E))
                {
                    loadEnding();
                }
        }
        else if (hasProgress == false)
        {
            messageText.SetText(currentText);
        }
    }

    private void OnTriggerStay(Collider player)
    {
            if (Input.GetKeyDown(KeyCode.E) && hasProgress == true)
            {
                loadEnding();
            }
    }

    void OnTriggerExit()
    {
        myCanvas.enabled = false; 
        if (hasProgress == true)
        {
            messageText.SetText(progressText);
        }
        else if (hasProgress == false)
        {
            messageText.SetText(currentText);
        }
    }

}
