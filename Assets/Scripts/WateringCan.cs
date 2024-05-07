using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WateringCan : MonoBehaviour
{
    [SerializeField]
    public bool pickupCan;
    public GameObject canObject; // held can
    public Canvas myCanvas;
    public TMP_Text messageText;

    private void Update()
    {
        if (pickupCan == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                pickupCan = false;
                canObject.SetActive(true);
                PlayerScript.canWater = true;
                gameObject.SetActive(false);
                myCanvas.enabled = false;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (PlayerScript.canWater == false)
        {
            pickupCan = true;
            messageText.SetText("Press E to pick up");
            myCanvas.enabled = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
            pickupCan = false;
            myCanvas.enabled = false;
    }


}
