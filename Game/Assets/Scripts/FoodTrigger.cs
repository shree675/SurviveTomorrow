using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodTrigger : MonoBehaviour
{
    public GameObject powerSource;
    public Vector3 powerSourcePosition;
    void OnTriggerEnter()
    {
        Debug.Log("FoodTrigger");
        HealthBarHandler.SetHealthBarValue(1f);
        OxygenBarHandler.SetOxygenBarValue(1f);
        // play the sound of eating

        Debug.Log("Power source spawned");
        
        Instantiate(powerSource, powerSourcePosition, transform.rotation);
        Destroy(gameObject, 1f);
    }
}
