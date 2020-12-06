using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skin : MonoBehaviour
{
    public int Hits;
    public Transform SkinPlace;

    public GameObject logobj;
    public GameObject leather;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "FurnaceHeat")
        {
            Debug.Log("Burning");
            //InvokeDestroy
        }
        if (other.gameObject.tag == "Hammer")
        {
            Hits += 1;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {  
        if (collision.gameObject.tag == "WorkBench")
        {
            this.transform.position = SkinPlace.position;
        }
    }

    void Leather()
    {
        leather.SetActive(true);
        logobj.SetActive(false);
    }
    
    void log()
    {
        leather.SetActive(false);
        logobj.SetActive(true);
    }
    void ZeroHits()
    {
        Hits = 0;
    }

    public void Update()
    {
        if (Hits == 4)
        {
            //Debug.Log("You made wooden sword handle!");
            Leather();
        }
        if (Hits >= 6)
        {
            log();
            ZeroHits();
        }
    }

    /*public void DisablingMesh()
    {
        logobj.SetActive(false);
        woodenSwordHandle.SetActive(false);
        woodenAxeHandle.SetActive(false);
        woodenHammerHandle.SetActive(false);
        Debug.Log("Tools disabled!");
    }*/
}
