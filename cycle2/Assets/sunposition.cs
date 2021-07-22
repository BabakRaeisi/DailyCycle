using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sunposition : MonoBehaviour
{
    private Dayandnight DayToNight; 
   

    void Start()
    {
        DayToNight = GameObject.Find("Lights").GetComponent<Dayandnight>(); 
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = DayToNight.sunposvec ; 
    }
}
