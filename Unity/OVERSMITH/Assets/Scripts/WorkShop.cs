using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkShop : MonoBehaviour
{
    public GameObject Sword;
    public GameObject Axe;
    public GameObject Hammer;
    public GameObject GreatSword;
    public GameObject GreatWarHammer;
    public GameObject GreatAxe;

    public Transform spawnPlace;

        public bool leather;

    public bool woodenswordhandle;
    public bool swordblade;
    
    public bool woodenhammerhandle;
    public bool hammerhead;

    public bool woodenaxehandle;
    public bool axehead;

        public bool hardleather;

    public bool twohandedswordhandle;
    public bool twohandedswordblade;

    public bool twohandedwarhammerhandle;
    public bool twohandedwarhammerhead;

    public bool twohandedaxehandle;
    public bool twohandedaxeblade;



    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "Leather")
        {
            leather = true;
            Debug.Log("LeatherInPlace!");
            Destroy(other.gameObject);
        }
        if (other.collider.tag == "HardLeather")
        {
            hardleather = true;
            Debug.Log("HardLeatherInPlace!");
            Destroy(other.gameObject);
        }

        if (other.collider.tag == "WoodenSwordHandle")
        {
            woodenswordhandle = true;
            Debug.Log("SwordHandleInPlace!");
            Destroy(other.gameObject);
        }
        if (other.collider.tag == "SwordBlade")
        {
            swordblade = true;
            Debug.Log("SwordBladeInPlace!");
            Destroy(other.gameObject);
        }

        if (other.collider.tag == "WoodenHammerHandle")
        {
            woodenhammerhandle = true;
            Debug.Log("HammerHandleInPlace!");
            Destroy(other.gameObject);
        }
        if (other.collider.tag == "HammerHead")
        {
            hammerhead = true;
            Debug.Log("HammerHeadInPlace!");
            Destroy(other.gameObject);
        }

        if (other.collider.tag == "WoodenAxeHandle")
        {
            woodenaxehandle = true;
            Debug.Log("AxeHandleInPlace!");
            Destroy(other.gameObject);
        }
        if (other.collider.tag == "AxeHead")
        {
            axehead = true;
            Debug.Log("AxeBladeInPlace!");
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
        if ((woodenswordhandle == true) & (swordblade == true) & (leather == true))
        {
            SpawnSword();
            booloff();
        }
        if ((woodenhammerhandle == true) & (hammerhead == true) & (leather == true))
        {
            SpawnHammer();
            booloff();
        }
        if ((woodenaxehandle == true) & (axehead == true) & (leather == true))
        {
            SpawnAxe();
            booloff();
        }
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
        woodenswordhandle = false;
        swordblade = false;
        woodenhammerhandle = false;
        hammerhead = false;
        woodenaxehandle = false;
        axehead = false;
        twohandedswordhandle = false;
        twohandedswordblade = false;
        twohandedwarhammerhandle = false;
        twohandedwarhammerhead = false;
        twohandedaxehandle = false;
        twohandedaxeblade = false;
    }

    public void SpawnSword()
    {
        Instantiate(Sword, spawnPlace.position, transform.rotation);
    }
    public void SpawnHammer()
    {
        Instantiate(Hammer, spawnPlace.position, transform.rotation);
    }
    public void SpawnAxe()
    {
        Instantiate(Axe, spawnPlace.position, transform.rotation);
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