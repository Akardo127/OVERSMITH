﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IronScraps : MonoBehaviour
{
    public int Hits;
    public Transform MaterialPlace;

    public GameObject scraps;
    public GameObject nails;
    public GameObject hoof;

    public bool HotIron;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "FurnaceHeat")
        {
            Debug.Log("HeatingUp");
            Invoke("Hot", 3f);
        }
        if ((other.gameObject.tag == "Hammer") & (HotIron == true))
        {
            //Debug.Log("SmithingBoi!");
            Hits += 1;
        }
        if (other.gameObject.tag == "Water")
        {
            Cold();
        }
    }

    void Hot()
    {
        Debug.Log("Hot!");
        HotIron = true;
        Invoke("Cold", 30f);
    }
    void Cold()
    {
        HotIron = false;
        Hits = 0;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Anvil")
        {
            this.transform.position = MaterialPlace.position;
        }
    }
    void Nails()
    {
        nails.SetActive(true);
        scraps.SetActive(false);
    }
    void Hoof()
    {
        nails.SetActive(false);
        hoof.SetActive(true);
    }
    void Scraps()
    {
        hoof.SetActive(false);
        scraps.SetActive(true);
    }

    void ZeroHits()
    {
        Hits = 0;
    }

    public void Update()
    {
        if (Hits == 4)
        {
            Nails();
        }
        if (Hits == 7)
        {
            Hoof();
        }
        if (Hits >= 10)
        { 
            Scraps();
            ZeroHits();
        }        
    }
}
