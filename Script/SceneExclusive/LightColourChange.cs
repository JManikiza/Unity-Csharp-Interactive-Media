using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class LightColourChange : MonoBehaviour
{

    public Material ColourSphere;

    public void ColorChange()
    {

        System.Random random = new System.Random();

        double RGBValue = random.NextDouble();
        double RGBValue1 = random.NextDouble();
        double RGBValue2 = random.NextDouble();

        //RGBValue = Convert.ToSingle(RGBValue);

        ColourSphere.color = new Color((float)RGBValue, (float)RGBValue1, (float)RGBValue2, 1);

        Debug.Log("New colour is " + ColourSphere.color);
        Debug.Log(RGBValue);

    }
}
