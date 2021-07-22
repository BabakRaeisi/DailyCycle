using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal; 


public class LightColorSettings : MonoBehaviour,Dayandnightinterface
{
    public Gradient gradient;
    public Light2D[] lights; 
    // Start is called before the first frame update
    public void GetComponent()
    {
        lights = GetComponentsInChildren<Light2D>(); 
        
    }

    // Update is called once per frame
    public void SetParameter(float time)
    {
        foreach (var light in lights)
        {
            light.color = gradient.Evaluate(time); 
        }
    }
}
