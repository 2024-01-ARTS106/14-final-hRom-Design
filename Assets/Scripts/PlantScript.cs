using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlantScript : MonoBehaviour
{
    public GameObject playerObj;
    public bool isWatered;
    private bool inRange;
    public GameObject waterEffect;
    public GameObject highlightEffect;
    public Canvas myCanvas;
    public TMP_Text messageText;
    public AudioSource waterSource;
    public Animator pourAnimator;

    void Start()
    {
        isWatered = false;
        inRange = false;
        playerObj = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update()
        {
            if (inRange && isWatered == false)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    pourAnimator.SetTrigger("isPouring");
                    isWatered = true;
                    highlightEffect.SetActive(false);
                    waterEffect.SetActive(true);
                playerObj.GetComponent<PlayerScript>().plantsWatered ++;
                myCanvas.enabled = false;
                waterSource.Play();
            }
            }

            if (PlayerScript.canWater && isWatered == false)
            {
                highlightEffect.SetActive(true);
            }

        }
        
        private void OnTriggerEnter(Collider player)
        {
            if (PlayerScript.canWater && isWatered == false)
            {
                inRange = true;
                messageText.SetText("Press E to water");
                myCanvas.enabled = true;
        }
        }

        private void OnTriggerExit(Collider player)
        {
                inRange = false;
                myCanvas.enabled = false;
    }

    }
