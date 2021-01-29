using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReciepiesUI : MonoBehaviour
{
    public bool reciepiesCanvasIsActive = false;
    public GameObject reciepiesUI;

    public GameObject tier1;
    public GameObject tier2;
    public GameObject tier3;
    public GameObject tier4;
    public GameObject tier5;

    public Upgrades upgrades;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (reciepiesCanvasIsActive)
            {
                reciepiesUI.SetActive(false);
                reciepiesCanvasIsActive = false;

            }
            else
            {
                reciepiesUI.SetActive(true);
                reciepiesCanvasIsActive = true;
            }
            
        }
        if (upgrades.Tier == 1)
        {
            tier1.SetActive(true);
        }
        if (upgrades.Tier == 2)
        {
            tier2.SetActive(true);
        }
        if (upgrades.Tier == 3)
        {
            tier3.SetActive(true);
        }
        if (upgrades.Tier == 4)
        {
            tier4.SetActive(true);
        }
        if (upgrades.Tier == 5)
        {
            tier5.SetActive(true);
        }

    }
}
