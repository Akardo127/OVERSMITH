using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClockUI : MonoBehaviour
{
    private const float REAL_SECONDS_PER_GAME_DAY = 420f;
    private float day;
    public int calendarDay;

    private Text timeText;
    private Text dayText;

    private Transform hourHandTransform;
    private Transform minuteHandTransform;

    public Transform theSunTransform;

    public GameObject ShopOppener;

    private void Awake()
    {
        ShopOppener.SetActive(false);
        minuteHandTransform = transform.Find("minutehand");
        hourHandTransform = transform.Find("hourHand");
        timeText = transform.Find("timeText").GetComponent<Text>();
        dayText = transform.Find("dayText").GetComponent<Text>();

    }
    private void Update()
    {
        day += Time.deltaTime / REAL_SECONDS_PER_GAME_DAY;

        float dayNormalized = day % 1f;

        float rotationDegreesPerDay = 360f;
        hourHandTransform.eulerAngles = new Vector3(0, 0, -dayNormalized * rotationDegreesPerDay); 

        //theSunTransform.eulerAngles = new Vector3(dayNormalized * rotationDegreesPerDay, 0, 0);

        float hoursPerDay = 24f;
        minuteHandTransform.eulerAngles = new Vector3(0, 0, -dayNormalized * rotationDegreesPerDay*hoursPerDay);

        string hoursString = Mathf.Floor(dayNormalized * hoursPerDay).ToString("00");

        float currenthour = Mathf.Floor(dayNormalized * hoursPerDay);

        float minutesPerHour = 60f;
        string minutesString = Mathf.Floor(((dayNormalized * hoursPerDay) % 1f) * minutesPerHour).ToString("00");
        string dayTextString = calendarDay.ToString("00");

        dayText.text = "Day" + dayTextString;

        timeText.text = hoursString + ":" + minutesString;
        if(timeText.text == "23:59")
        {
            Invoke("NextDay", 1f);
        }

        if (timeText.text == "06:00")
        {
            Debug.Log("It's 6:00 o clock, shop can be opened now.");
            ShopOppener.SetActive(true);
        }
        if ((timeText.text == "14:00") & (ShopOppener == true))
        {
            ShopOppener.SetActive(false);
            Debug.Log("It's 14:00 o clock, shop can not be opened anymore.");
        }
    }

    private void NextDay()
    {
        calendarDay += 1;     
    }


}
