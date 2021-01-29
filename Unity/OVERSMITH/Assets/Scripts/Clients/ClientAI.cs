using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClientAI : MonoBehaviour
{
    WorkshopMenager workshopMenager;

    //dialogue
    //navmesh agent
    public int orderValue = 20;

    void Start()
    {
        workshopMenager = WorkshopMenager.instance;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "nails")
        {
            workshopMenager.AddOrderValue(orderValue);
            Destroy(collision.gameObject);
        }
    }
}
