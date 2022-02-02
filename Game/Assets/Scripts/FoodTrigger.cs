using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FoodTrigger : MonoBehaviour
{
    public GameObject powerSource;
    public Vector3 powerSourcePosition;

    TextMeshProUGUI objectiveText;
    // public GameObject canvas;

    private void Awake()
    {
        objectiveText = GameObject.Find("CurrentObjective").GetComponent<TextMeshProUGUI>();
    }
    void OnTriggerEnter()
    {
        Debug.Log("FoodTrigger");
        HealthBarHandler.SetHealthBarValue(1f);
        OxygenBarHandler.SetOxygenBarValue(1f);
        Debug.Log("Power source spawned");
        objectiveText.text = "Find Power Source";
        objectiveText.color = Color.blue;
        Instantiate(powerSource, powerSourcePosition, transform.rotation);
        Destroy(gameObject, 1f);
    }
}
