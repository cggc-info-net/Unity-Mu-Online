using System;
using UnityEngine;

public class MathHelper
{
    public static float Lerp(float value1, float value2, float amount)
    {
        return value1 + (value2 - value1) * amount;
    }

    public static float Clamp(float value, float min, float max)
    {
        value = ((value > max) ? max : value);
        value = ((value < min) ? min : value);
        return value;
    }

    public static float ToRadians(float degrees)
    {
        return (float)((float)(double)degrees * (Math.PI / 180.0));
    }
}
