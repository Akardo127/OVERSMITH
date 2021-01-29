using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopActiveTimer : MonoBehaviour
{
    public int countDownTime;
    public Text countDownDisplay;

    public ShopMenager shopMenager;

    public void Awake()
    {
        StartCoroutine(CountDownToShopClosed());
    }

    IEnumerator CountDownToShopClosed()
    {
        while(countDownTime > 0)
        {
            countDownDisplay.text = countDownTime.ToString();

            yield return new WaitForSeconds(1f);

            countDownTime--;
        }

        
        shopMenager.CloseShop();

        yield return new WaitForSeconds(1f);

    }
}
