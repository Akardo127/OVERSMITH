using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenShop : MonoBehaviour
{
    public ShopMenager shopMenager;
    public GameObject shopIsActiveTimer;
    public GameObject openShopInfo;


    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKey(KeyCode.O))
        {
            shopMenager.shopIsOpen = true;
            shopIsActiveTimer.SetActive(true);
            gameObject.SetActive(false);
            openShopInfo.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            openShopInfo.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            openShopInfo.SetActive(false);
        }
    }
}
