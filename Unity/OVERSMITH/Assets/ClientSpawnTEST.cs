using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClientSpawnTEST : MonoBehaviour
{
    public GameObject[] Clients1;
    public GameObject[] Clients2;
    public GameObject[] Clients3;
    public GameObject[] Clients4;
    public GameObject[] Clients5;

    public Upgrades upgrades;
    public bool shopIsOpen;
    public bool ClientIsSpawned;

    public Transform ClientSpawner;

    public void Update()
    {
        SpawnClients();
    }

    public void SpawnClients()
    {
        if ((shopIsOpen == true) && (ClientIsSpawned == false) )
        {
            int randomClient1 = Random.Range(0, Clients1.Length);
            Debug.Log(randomClient1);
            GameObject instantiatedObject = Instantiate(Clients1[randomClient1], ClientSpawner.position, Quaternion.identity) as GameObject;
            ClientIsSpawned = true;
        }
    }
        
}
