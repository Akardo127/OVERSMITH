using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Equipment : MonoBehaviour
{
    //equiped tool/weapon
    public GameObject equipedWeapon;

    public GameObject hammer;
    public GameObject clams;
    public GameObject sword;

    public bool Hammer;
    public bool Clams;
    public bool Sword;

    //tools prefabs

    // Start is called before the first frame update
    void Start()
    {
        equipedWeapon = null;
    }

    public void EquipHammer()
    {
        //Debug.Log("HammerEquiped");
        hammer.SetActive(true);
    }
    public void EquipClams()
    {
        Debug.Log("ClamsEquiped");
        clams.SetActive(true);
    }

    public void EquipSword()
    {
        Debug.Log("SwordEquiped");
        sword.SetActive(true);
    }


    // Update is called once per frame
    void Update()
    {
        //Changing to different tools
        if (Input.GetKeyDown(KeyCode.E))
        {
            DisablingMesh();
            Invoke("EquipHammer", 0.1f);
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            DisablingMesh();
            Invoke("EquipClams",0.1f);
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            DisablingMesh();
            Invoke("EquipSword", 0.1f);
        }
        //E_Hammer
        //Q_Clams
        //F_Weapon
    }

    public void DisablingMesh()
    {
        hammer.SetActive(false);
        Hammer = false;
        clams.SetActive(false);
        Clams = false;
        sword.SetActive(false);
        Sword = false;
        //Debug.Log("Tools disabled!");
    }
}
