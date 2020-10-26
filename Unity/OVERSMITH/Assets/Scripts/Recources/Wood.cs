using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wood : MonoBehaviour
{
    public int Hits;
    public Transform LOGPlace;

    public GameObject logobj;
    public GameObject woodenSwordHandle;
    public GameObject woodenAxeHandle;
    public GameObject woodenHammerHandle;

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
            this.transform.position = LOGPlace.position;
        }

    }

    void woodenswordhande()
    {
        woodenSwordHandle.SetActive(true);
        logobj.SetActive(false);
    }
    void woodenaxehande()
    {
        woodenSwordHandle.SetActive(false);
        woodenAxeHandle.SetActive(true);
    }
    void woodenhammerhande()
    {
        woodenAxeHandle.SetActive(false);
        woodenHammerHandle.SetActive(true);
    }
    void log()
    {
        woodenHammerHandle.SetActive(false);
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
            woodenswordhande();
        }
        if (Hits == 7)
        {
            //Debug.Log("You made wooden axe handle!");
            woodenaxehande();
        }
        if (Hits == 10)
        {
            //Debug.Log("You made wooden hammer handle!");
            woodenhammerhande();
        }
        if (Hits >= 13)
        {
            log();
            ZeroHits();
        }
    }

    public void DisablingMesh()
    {
        logobj.SetActive(false);
        woodenSwordHandle.SetActive(false);
        woodenAxeHandle.SetActive(false);
        woodenHammerHandle.SetActive(false);
        Debug.Log("Tools disabled!");
    }
}
