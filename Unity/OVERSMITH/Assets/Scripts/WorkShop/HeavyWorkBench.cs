using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeavyWorkBench : MonoBehaviour
{
    public GameObject GreatSword;
    public GameObject GreatWarHammer;
    public GameObject GreatAxe;

    public Transform spawnPlace;

    public bool hardleather;

    public bool twohandedswordhandle;
    public bool twohandedswordblade;

    public bool twohandedwarhammerhandle;
    public bool twohandedwarhammerhead;

    public bool twohandedaxehandle;
    public bool twohandedaxeblade;



    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "HardLeather")
        {
            hardleather = true;
            Debug.Log("HardLeatherInPlace!");
            Destroy(other.gameObject);
        }

        if (other.collider.tag == "TwoHandedSwordHandle")
        {
            twohandedswordhandle = true;
            Debug.Log("GreatswordHandleInPlace!");
            Destroy(other.gameObject);
        }
        if (other.collider.tag == "TwoHandedSwordBlade")
        {
            twohandedswordblade = true;
            Debug.Log("GreatSwordBladeInPlace!");
            Destroy(other.gameObject);
        }

        if (other.collider.tag == "TwoHandedHammerHandle")
        {
            twohandedwarhammerhandle = true;
            Debug.Log("TwoHandedHammerHandleInPlace!");
            Destroy(other.gameObject);
        }
        if (other.collider.tag == "TwoHandedHammerHead")
        {
            twohandedwarhammerhead = true;
            Debug.Log("TwoHandedHammerHandleInPlace!");
            Destroy(other.gameObject);
        }

        if (other.collider.tag == "TwoHandedAxeHandle")
        {
            twohandedaxehandle = true;
            Debug.Log("TwoHandedAxeHandleInPlace!");
            Destroy(other.gameObject);
        }
        if (other.collider.tag == "TwoHandedAxeBlade")
        {
            twohandedaxeblade = true;
            Debug.Log("TwoHandedAxeBladeInPlace!");
            Destroy(other.gameObject);
        }
    }

    private void Update()
    {
        if ((twohandedswordhandle == true) & (twohandedswordblade == true) & (hardleather == true))
        {
            SpawnGreatSword();
            booloff();
        }
        if ((twohandedwarhammerhandle == true) & (twohandedwarhammerhead == true) & (hardleather == true))
        {
            SpawnGreatWarHammer();
            booloff();
        }
        if ((twohandedaxehandle == true) & (twohandedaxeblade == true) & (hardleather == true))
        {
            SpawnGreatAxe();
            booloff();
        }

    }
    void booloff()
    {
        hardleather = false;
        twohandedswordhandle = false;
        twohandedswordblade = false;
        twohandedwarhammerhandle = false;
        twohandedwarhammerhead = false;
        twohandedaxehandle = false;
        twohandedaxeblade = false;
    }
    public void SpawnGreatSword()
    {
        Instantiate(GreatSword, spawnPlace.position, transform.rotation);
    }
    public void SpawnGreatWarHammer()
    {
        Instantiate(GreatWarHammer, spawnPlace.position, transform.rotation);
    }
    public void SpawnGreatAxe()
    {
        Instantiate(GreatAxe, spawnPlace.position, transform.rotation);
    }
}
