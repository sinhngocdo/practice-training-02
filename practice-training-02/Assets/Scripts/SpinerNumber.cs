using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SpinerNumber : MonoBehaviour
{
    [SerializeField] private TextMeshPro number;

    private void Start()
    {
        RestNumber();
    }

    private void RestNumber()
    {
        number = GetComponent<TextMeshPro>();
        number.text = transform.name;
    }
}
