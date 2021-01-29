using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkShop : MonoBehaviour
{
    //public GameObject Sword;
    public GameObject Axe;
    public GameObject Hammer;

    public Transform spawnPlace;

        public bool leather;

    //public bool woodenswordhandle;
    //public bool swordblade;
    
    public bool woodenhammerhandle;
    public bool hammerhead;

    public bool woodenaxehandle;
    public bool axehead;


    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "Leather")
        {
            leather = true;
            Debug.Log("LeatherInPlace!");
            Destroy(other.gameObject);
        }
        
        /*if (other.collider.tag == "WoodenSwordHandle")
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
        }*/

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

        
    }

    private void Update()
    {
        /*if ((woodenswordhandle == true) & (swordblade == true) & (leather == true))
        {
            SpawnSword();
            booloff();
        }*/
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
        

    }
    void booloff()
    {
        //woodenswordhandle = false;
        //swordblade = false;
        woodenhammerhandle = false;
        hammerhead = false;
        woodenaxehandle = false;
        axehead = false;
        leather = false;
    }

    /*public void SpawnSword()
    {
        Instantiate(Sword, spawnPlace.position, transform.rotation);
    }*/
    public void SpawnHammer()
    {
        Instantiate(Hammer, spawnPlace.position, transform.rotation);
    }
    public void SpawnAxe()
    {
        Instantiate(Axe, spawnPlace.position, transform.rotation);
    }
    
}