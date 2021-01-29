using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopMenager : MonoBehaviour
{
    #region

    public static ShopMenager instance;

    private void Awake()
    {
        instance = this;
    }
    #endregion

    public bool shopIsOpen;

    public GameObject[] Clients1;
    public GameObject[] Clients2;
    public GameObject[] Clients3;
    public GameObject[] Clients4;
    public GameObject[] Clients5;

    public Upgrades upgrades;

    public Transform shopTransform;
    public Transform goAwayTransform;

    public bool ClientIsSpawned;
    public Transform ClientSpawner;

    //Gdy sklep jest otwarty aktywuj spawnery
    //Gdy sklep przestaje być aktywny deactywuj spawnery
    //Docelowo tier1Spawner jest aktywny
    public void CloseShop()
    {
        Debug.Log("Shop Closed!");
        shopIsOpen = false;
        
    }

    public void Update()
    {
        SpawnClients();
        
    }
    public void SpawnClients()
    {
        if ((shopIsOpen == true) && (ClientIsSpawned == false)) {
            if (upgrades.Tier == 1)
            {
                int randomClient1 = Random.Range(0, Clients1.Length);
                Debug.Log(randomClient1);
                GameObject instantiatedObject1 = Instantiate(Clients1[randomClient1], ClientSpawner.position, Quaternion.identity) as GameObject;
                ClientIsSpawned = true;
            }
            if (upgrades.Tier == 2)
            {
                int randomClient2 = Random.Range(0, Clients2.Length);
                Debug.Log(randomClient2);
                GameObject instantiatedObject2 = Instantiate(Clients2[randomClient2], ClientSpawner.position, Quaternion.identity) as GameObject;
                ClientIsSpawned = true;
            }
            if (upgrades.Tier == 3)
            {
                int randomClient3 = Random.Range(0, Clients3.Length);
                Debug.Log(randomClient3);
                GameObject instantiatedObject3 = Instantiate(Clients3[randomClient3], ClientSpawner.position, Quaternion.identity) as GameObject;
                ClientIsSpawned = true;
            }
            if (upgrades.Tier == 4)
            {
                int randomClient4 = Random.Range(0, Clients4.Length);
                Debug.Log(randomClient4);
                GameObject instantiatedObject4 = Instantiate(Clients2[randomClient4], ClientSpawner.position, Quaternion.identity) as GameObject;
                ClientIsSpawned = true;
            }
            if (upgrades.Tier == 5)
            {
                int randomClient5 = Random.Range(0, Clients5.Length);
                Debug.Log(randomClient5);
                GameObject instantiatedObject5 = Instantiate(Clients2[randomClient5], ClientSpawner.position, Quaternion.identity) as GameObject;
                ClientIsSpawned = true;
            }
        }
    }

}
