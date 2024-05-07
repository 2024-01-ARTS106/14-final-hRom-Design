using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerScript : MonoBehaviour
{

    public static bool canWater;
    public int plantsWatered;
    public bool canDone;
    public GameObject spot;

    private void Start()
    {
        canWater = false;
        plantsWatered = 0;
        canDone = false;
    }

    private void Update()
    {
        if (plantsWatered == 4)
        {
            canDone = true;
            spot.SetActive(true);
        }
    }

}
