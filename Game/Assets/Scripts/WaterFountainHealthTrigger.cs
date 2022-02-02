using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WaterFountainHealthTrigger : MonoBehaviour
{
    public GameObject food;
    public Vector3 foodPosition;

    public TextMeshProUGUI objectiveText;
    
    void OnTriggerEnter(Collider collider)
    {
        if (collider.name != "PlayerCube") return;
         HealthBarHandler.SetHealthBarValue(1f);
        // play the sound of drinking water
        
        Instantiate(food, foodPosition, transform.rotation);
        Debug.Log("Food spawned");
        objectiveText.text = "Find Food";
        objectiveText.color = Color.green;
        Destroy(gameObject, 1f);
    }
}
