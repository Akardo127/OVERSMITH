using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public Transform theDest;
    PlayerController playerController;

    public void Start()
    {
        theDest = PlayerController.instance.holdObjectTransform.transform;
    }

    void OnMouseDown()
    {
        GetComponentInChildren<BoxCollider>().enabled = false;
        GetComponent<Rigidbody>().useGravity = false;
        GetComponent<Rigidbody>().isKinematic = true;
        this.transform.position = theDest.position;
        this.transform.parent = GameObject.Find("HoldObjectTransform").transform;
    }
    void OnMouseUp()
    {
        this.transform.parent = null;
        GetComponent<Rigidbody>().useGravity = true;
        GetComponentInChildren<BoxCollider>().enabled = true;
        GetComponent<Rigidbody>().isKinematic = false;
    }

}
