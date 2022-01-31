using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryTrigger : MonoBehaviour
{
    void OnTriggerEnter()
    {
        Debug.Log("Battery Collected");
        Destroy(gameObject);
    }
}
