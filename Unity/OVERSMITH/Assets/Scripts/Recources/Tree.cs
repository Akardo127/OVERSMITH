using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : MonoBehaviour
{
    public int hits;
    public float speed;

    public GameObject growedTree;
    public GameObject chopedTree;

    public Collider treeCollider;

    public Rigidbody log;

    public Transform spawn1;
    public Transform spawn2;
    public Transform spawn3;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Hammer")
        {
            hits += 5;
        }
        if (hits >= 25)
        {
            Spawn();
            Deactive();
        }
    }
    public void Deactive()
    {
        growedTree.SetActive(false);
        treeCollider.enabled = false;

        chopedTree.SetActive(true);
    }
    public void Spawn()
    {
            Rigidbody clone;
            clone = Instantiate(log, spawn1.position, transform.rotation) as Rigidbody;
            clone.AddForce(spawn1.up * speed);

        Rigidbody clone1;
        clone1 = Instantiate(log, spawn2.position, transform.rotation) as Rigidbody;
        clone1.AddForce(spawn2.up * speed);

        Rigidbody clone2;
        clone2 = Instantiate(log, spawn2.position, transform.rotation) as Rigidbody;
        clone2.AddForce(spawn3.up * speed);
        
    }
}
