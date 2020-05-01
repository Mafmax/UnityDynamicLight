using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GetAdditive
{
    public static Vector3 SunVector(float angle, float deviation)
    {

        return deviation * (new Vector3((float)Math.Cos(angle),0f, (float)Math.Sin(angle)));

    }

    public static bool InRange(float x, float x1, float x2)
    {
        return (x <= x2 && x >= x1);
    }

    public static float SquareFunc(float y,float pi, float x)
    {
        float a = -4 * y / (float)Math.Pow(pi,2);
        float b = 4 * y / pi;
        
        return a * (float)Math.Pow(x, 2) + b * (float)x;

    }
}
