using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkshopMenager : MonoBehaviour
{
    #region

    public static WorkshopMenager instance;

    private void Awake()
    {
        instance = this;
    }
    #endregion

    public GameObject workshopMenager;

    public int money;

    public void AddOrderValue(int value)
    {
        money += value;
    }
}
