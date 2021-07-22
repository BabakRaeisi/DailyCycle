using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public interface Dayandnightinterface
{
    void GetComponent();
    void SetParameter(float time); 

}
[ExecuteInEditMode]
public class Dayandnight : MonoBehaviour
{
    [Range(0, 1)]
    public float time;
    public Dayandnightinterface[] setters;
    public bool day;
   
    public GameObject sun; 

    [Range(10f , -20f)]
    public float sunpos;

    public Vector3 sunposvec; 

    // Start is called before the first frame update
    private  void OnEnable()
    {
        time = 0;
        day = true;
       
        
        GetSetters(); 

    }
   

    // Update is called once per frame
    private void GetSetters()
    {
        setters = GetComponentsInChildren<Dayandnightinterface>();
        foreach (var setter in setters)
        {
            setter.GetComponent(); 
        }
    }
    private void Update()
    {
        if (setters.Length>0)
        {
            foreach (var setter in setters)
            {
                setter.SetParameter(time); 
            }
        }



        if (time > 1f)
            day = false;
        if (time < 0f)
            day = true;


        if (day)
        {
            time = Mathf.Lerp(time, 1.1f, Time.deltaTime * 0.15f);
            sunpos = Mathf.Lerp(sunpos, -20f, Time.deltaTime * 0.17f);
            sunposvec.y = sunpos;
        }
        else if (!day)
        {
            time = Mathf.Lerp(time, -0.1f, Time.deltaTime * 0.15f);
            sunpos = Mathf.Lerp(sunpos, 10f , Time.deltaTime * 0.17f);
            sunposvec.y = sunpos;
        }
    }
}
