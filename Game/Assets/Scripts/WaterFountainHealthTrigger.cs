using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterFountainHealthTrigger : MonoBehaviour
{
    public GameObject food;
    public Vector3 foodPosition;

    void OnTriggerEnter()
    {
        HealthBarHandler.SetHealthBarValue(1f);
        // play the sound of drinking water
        
        Instantiate(food, foodPosition, transform.rotation);
        Debug.Log("Food spawned");
        Destroy(gameObject, 1f);
    }
}
