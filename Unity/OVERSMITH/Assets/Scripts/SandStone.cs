using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SandStone : MonoBehaviour
{
    public Transform spawnPlace;

    public GameObject ExcelentGreatSword;
    public GameObject ExcelentGreatWarHammer;
    public GameObject ExcelentGreatAxe;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "GreatSword")
        {
            Debug.Log("Sanding!");
            SpawnExcelentGreatSword();
            Destroy(collision.gameObject);
        }
        if (collision.collider.tag == "GreatWarHammer")
        {
            Debug.Log("Sanding!");
            SpawnExcelentGreatWarHammer();
            Destroy(collision.gameObject);
        }
        if (collision.collider.tag == "GreatAxe")
        {
            Debug.Log("Sanding!");
            SpawnExcelentGreatAxe();
            Destroy(collision.gameObject);
        }
    }

    public void SpawnExcelentGreatSword()
    {
        Instantiate(ExcelentGreatSword, spawnPlace.position, transform.rotation);
    }
    public void SpawnExcelentGreatWarHammer()
    {
        Instantiate(ExcelentGreatWarHammer, spawnPlace.position, transform.rotation);
    }
    public void SpawnExcelentGreatAxe()
    {
        Instantiate(ExcelentGreatAxe, spawnPlace.position, transform.rotation);
    }
}
