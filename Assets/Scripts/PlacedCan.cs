using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.ProBuilder;

public class PlacedCan : MonoBehaviour
{
    private bool inRange;
    public GameObject thisthing;
    public GameObject staticCan;
    public GameObject heldCan;
    public GameObject highlightEffect;
    public Canvas myCanvas;
    public TMP_Text messageText;
    private bool placedDown;
    public GameObject endDoor;
    public GameObject playerObj;

    void Start()
    {
        inRange = false;
        placedDown = false;
        endDoor = GameObject.FindGameObjectWithTag("Finish");
        playerObj = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        if (inRange && placedDown == false)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                placedDown = true;
                highlightEffect.SetActive(false);
                staticCan.SetActive(true);
                heldCan.SetActive(false);
                messageText.SetText("That's everything. Time for bed.");
                endDoor.GetComponent<BedroomDoor>().hasProgress = true;
            }
        }

    }

    private void OnTriggerEnter(Collider player)
    {
        if (playerObj.GetComponent<PlayerScript>().plantsWatered == 4)
        {
            inRange = true;
            messageText.SetText("Press E to place");
            myCanvas.enabled = true;
        }
    }
    private void OnTriggerExit(Collider player)
    {
        inRange = false;
        myCanvas.enabled = false;
    }
}