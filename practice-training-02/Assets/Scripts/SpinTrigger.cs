using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinTrigger : MonoBehaviour
{
    [SerializeField] private Transform spiner;
    [SerializeField] private float speed = 0f;
    [SerializeField] private float speedMax = 700f;
    [SerializeField] private float slowDown = 1f;
    [SerializeField] private string stopAt = "3";
    [SerializeField] private bool stop = false;
    [SerializeField] private bool spinning = true;


    private void OnMouseDown()
    {
        Debug.Log("OnMouseDown");
        StartSpin();
    }

    private void StartSpin()
    {
        speed = speedMax;
        spinning = true;
        stop = false;
    }

    private void FixedUpdate()
    {
        Spinning();
    }

    private void Spinning()
    {
        spiner.Rotate(0, Time.deltaTime * speed, 0);

        Stoping();
    }

    private void Stoping()
    {
        if (!stop) return;
        if (stopAt == Marker.instance.number) spinning = false;
        if (spinning) return;
        speed -= slowDown;
        if (speed < 0) speed = 0;
    }
}
