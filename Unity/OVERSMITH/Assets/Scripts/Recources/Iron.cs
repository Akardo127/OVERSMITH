using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Iron : MonoBehaviour
{
    public int Hits;
    public Transform MaterialPlace;
    public Transform IronPlace;

    public GameObject ironBlock;
    public GameObject swordBlade;
    public GameObject axeHead;
    public GameObject hammerHead;

    public Material coldMaterial;
    public Material hotMaterial;

    public bool HotIron;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "FurnaceHeat")
        {
            Debug.Log("HeatingUp");
            Invoke("Hot", 3f);
        }
        if ((other.gameObject.tag == "Hammer") & (HotIron == true))
        {
            //Debug.Log("SmithingBoi!");
            Hits += 1;
        }
        if(other.gameObject.tag == "Water")
        {
            Cold();
        }
    }

    void Hot()
    {
        Debug.Log("Hot!");
        HotIron = true;
        Invoke("Cold", 30f);
        transform.GetComponentInChildren<Renderer>().material = hotMaterial;
    }
    void Cold()
    {
        HotIron = false;
        Hits = 0;
        transform.GetComponentInChildren<Renderer>().material = coldMaterial;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Anvil")
        {
            this.transform.position = MaterialPlace.position;
        }
        if (collision.gameObject.tag == "WorkBench")
        {
            this.transform.position = IronPlace.position;
        }

    }
    void swordblade()
    {
        swordBlade.SetActive(true);
        ironBlock.SetActive(false);
    }
    void axehead()
    {
        swordBlade.SetActive(false);
        axeHead.SetActive(true);
    }
    void hammerhead()
    {
        axeHead.SetActive(false);
        hammerHead.SetActive(true);
    }
    void ironblock()
    {
        hammerHead.SetActive(false);
        ironBlock.SetActive(true);
    }


    void ZeroHits()
    {
        Hits = 0;
    }

    public void Update()
    {
            if (Hits == 4)
            {
                //Debug.Log("You forged a sword blade!");
                //Hits += 1;
                swordblade();
            }
            if (Hits == 7)
            {
                //Debug.Log("You forged a axe blade!");
                //Hits += 1;
                axehead();
            }
            if (Hits == 10)
            {
                //Debug.Log("You forged a hammer head!");
                //Hits += 13;
                hammerhead();
            }
            if (Hits >= 13)
            {
                ironblock();
                ZeroHits();
            }
    }
}
