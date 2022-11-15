using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Marker : MonoBehaviour
{
    public static Marker instance;

    public string number="";
    // Start is called before the first frame update
    void Awake()
    {
        Marker.instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        number = other.name;
        Debug.Log(number);
    }
}
