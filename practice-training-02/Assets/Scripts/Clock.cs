using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{
    [SerializeField]
    GameObject HandSecond;
    [SerializeField]
    GameObject HandMinute;
    [SerializeField]
    GameObject HandHour;

    // Update is called once per frame
    void Update()
    {
        DateTime currentTime = DateTime.Now;

        float secondsDegree = -(currentTime.Second / 60f) * 360f;
        HandSecond.transform.localRotation = Quaternion.Euler(new Vector3(0, 0, secondsDegree));
        float minutesDegree = -(currentTime.Minute / 60f) * 360f;
        HandMinute.transform.localRotation = Quaternion.Euler(new Vector3(0, 0, minutesDegree));
        float hoursDegree = -(currentTime.Hour / 12f) * 360f;
        HandHour.transform.localRotation = Quaternion.Euler(new Vector3(0, 0, hoursDegree));

    }
}
