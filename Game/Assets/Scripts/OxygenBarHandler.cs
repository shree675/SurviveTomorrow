using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class OxygenBarHandler : MonoBehaviour
{
    private static Image OxygenBarImage;

    private void Start()
    {
        OxygenBarImage = GetComponent<Image>();
    }

    public static void SetOxygenBarValue(float value)
    {
        OxygenBarImage.fillAmount = Math.Max(0,value);
        SetOxygenBarColor(Color.blue);
    }
 
    public static float GetOxygenBarValue()
    {
        return OxygenBarImage.fillAmount;
    }
 
    public static void SetOxygenBarColor(Color oxylevelColor)
    {
        OxygenBarImage.color = oxylevelColor;
    }
}
