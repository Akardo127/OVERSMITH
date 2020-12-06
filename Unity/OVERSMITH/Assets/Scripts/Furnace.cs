using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Furnace : MonoBehaviour
{
    public GameObject HeatingPlace;

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKey(KeyCode.Space))
        {
            HeatingPlace.SetActive(true);
        }
        else
        {
            HeatingPlace.SetActive(false);
        }
    }
}
