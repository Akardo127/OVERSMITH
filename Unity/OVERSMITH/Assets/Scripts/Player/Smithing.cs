using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Smithing : MonoBehaviour
{

    public GameObject hammerHead;

    void Hit()
    {
        hammerHead.SetActive(true);
        Invoke("HammerHeadDissmiss", 0.2f);
    }

    void HammerHeadDissmiss()
    {
        hammerHead.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            {
                Invoke("Hit", 0.1f);
            }
        }
    }

}
