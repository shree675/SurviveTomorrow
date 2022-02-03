using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FoodTrigger : MonoBehaviour
{
    public GameObject powerSource;
    public Vector3 powerSourcePosition;
    [SerializeField] Text text;
    TextMeshProUGUI objectiveText;
    // public GameObject canvas;

    private void Awake()
    {
        objectiveText = GameObject.Find("CurrentObjective").GetComponent<TextMeshProUGUI>();
        text = GameObject.Find("CollectedFood").GetComponent<Text>();
    }
    void OnTriggerEnter()
    {
        text.enabled=true;
        text.gameObject.SetActive(true);
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
