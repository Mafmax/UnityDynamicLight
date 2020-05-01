using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNightCamera : MonoBehaviour
{
    private float deviation = 20f;
    private float angle;
    public GameObject center;
    public GameObject sun;
    public GameObject moon;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GetAdditive.InRange(angle , (float)Math.PI,2* (float)Math.PI))
        {
            sun.GetComponent<Light>().intensity = GetAdditive.SquareFunc(5,(float)Math.PI,angle- (float)Math.PI);
            moon.GetComponent<Light>().intensity = 0f;

        }
        else
        {
            sun.GetComponent<Light>().intensity = 0f;
            moon.GetComponent<Light>().intensity = GetAdditive.SquareFunc(1, (float)Math.PI, angle);
        }
        angle += (Time.deltaTime * (float)Math.PI/4f);
        angle%=2*(float)Math.PI;
        sun.transform.position = center.transform.position + GetAdditive.SunVector(angle, deviation);
        moon.transform.position = center.transform.position + GetAdditive.SunVector(angle+(float)Math.PI, deviation);
       

    }
}
