using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upgrades : MonoBehaviour
{
    public GameObject Tier2_equipment;
    public GameObject Tier3_equipment;
    public GameObject Tier4_equipment;
    public GameObject Tier5_equipment;

    public GameObject upgradesUI;

    public int Tier = 1;

    public int Wood;
    public int Nails;
    public int Iron;
    public int Mithril;
    public int Meteorite;

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            upgradesUI.SetActive(false);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            upgradesUI.SetActive(true);
        }


        if (other.collider.tag == "Wood")
        {
            Wood += 1;
            Destroy(other.gameObject);
        }
        if (other.collider.tag == "Nails")
        {
            Nails += 1;
            Destroy(other.gameObject);
        }
        if (other.collider.tag == "Iron")
        {
            Iron += 1;
            Destroy(other.gameObject);
        }
        if (other.collider.tag == "Mithril")
        {
            Mithril += 1;
            Destroy(other.gameObject);
        }
        if (other.collider.tag == "Meteorite")
        {
            Meteorite += 1;
            Destroy(other.gameObject);
        }
    }

    public void upgradeToTier2()
    {
        Tier2_equipment.SetActive(true);
        //tier2 = true;
        Tier += 1;
        //ARE YOU SURE YOU WANT TO UPGRADE? IT WILL COST XX? CONFIRM!

        Wood = 0;
        Nails = 0;
    }
    public void upgradeToTier3()
    {
        Tier3_equipment.SetActive(true);
        //tier3 = true;
        Tier += 1;

        Wood = 0;
        Nails = 0;
        Iron = 0;
    }
    public void upgradeToTier4()
    {
        Tier4_equipment.SetActive(true);
        //tier4 = true;
        Tier += 1;

        Wood = 0;
        Nails = 0;
        Iron = 0;
        Mithril = 0;
    }
    public void upgradeToTier5()
    {
        Tier5_equipment.SetActive(true);
        //tier5 = true;
    }

    void Update()
    {
        if ((Wood >= 5) & (Nails >= 3))
        {
            if ((Tier != 2)&(Tier <=2))
            {
                Debug.Log("Forge Upgraded to tier2!");
                upgradeToTier2();
            }
        }

        if ((Wood >= 7) & (Nails >= 5) & (Iron >= 4))
        {
            if ((Tier != 3) & (Tier <= 3))
            {
                Debug.Log("Forge Upgraded to tier3!");
                upgradeToTier3();
            }
        }

        if ((Wood >= 9) & (Nails >=6) & (Iron >= 7) & (Mithril >=5))
        {
            if ((Tier != 4) & (Tier <= 4))
            {
                Debug.Log("Forge Upgraded to tier4!");
                upgradeToTier4();
            }
        }

        if ((Wood >= 12) & (Nails >= 10) & (Iron >= 9) & (Mithril >= 8) & (Meteorite >= 3))
        {
            if ((Tier != 5) & (Tier <= 5))
            {
                Debug.Log("Forge Upgradedto tier5!");
                upgradeToTier5();
            }
        }
    }
}
