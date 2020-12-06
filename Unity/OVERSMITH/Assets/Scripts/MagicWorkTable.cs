using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicWorkTable : MonoBehaviour
{

    public GameObject MagicSword;
    public GameObject MagicWarHammer;
    public GameObject MagicAxe;

    public Transform spawnPlace;

    public bool meteorite;

    public bool excelentGreatSword;
    public bool excelentGreatWarHammer;
    public bool excelentGreatAxe;

    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "Meteorite")
        {
            meteorite = true;
            Debug.Log("MetoriteInPlace!");
            Destroy(other.gameObject);
        }

        if (other.collider.tag == "ExcelentGreatSword")
        {
            excelentGreatSword = true;
            Debug.Log("ExcelentGreatSwordInPlace!");
            Destroy(other.gameObject);
        }
        if (other.collider.tag == "ExcelentGreatWarHammer")
        {
            excelentGreatWarHammer = true;
            Debug.Log("ExcelentGreatWarHammerInPlace!");
            Destroy(other.gameObject);
        }
        if (other.collider.tag == "ExcelentGreatAxe")
        {
            excelentGreatAxe = true;
            Debug.Log("ExcelentGreatAxeInPlace!");
            Destroy(other.gameObject);
        }
    }

    private void Update()
    {
        if ((excelentGreatSword == true) & (meteorite == true))
        {
            SpawnMagicSword();
            booloff();
        }
        if ((excelentGreatWarHammer == true) & (meteorite == true))
        {
            SpawnMagicWarHammer();
            booloff();
        }
        if ((excelentGreatAxe == true) & (meteorite == true))
        {
            SpawnMagicAxe();
            booloff();
        }
    }
    void booloff()
    {
        excelentGreatSword = false;
        excelentGreatWarHammer = false;
        excelentGreatAxe = false;
    }

    public void SpawnMagicSword()
    {
        Instantiate(MagicSword, spawnPlace.position, transform.rotation);
    }
    public void SpawnMagicWarHammer()
    {
        Instantiate(MagicWarHammer, spawnPlace.position, transform.rotation);
    }
    public void SpawnMagicAxe()
    {
        Instantiate(MagicAxe, spawnPlace.position, transform.rotation);
    }
}
