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

    private void Awake()
    {
        objectiveText = GameObject.Find("CurrentObjective").GetComponent<TextMeshProUGUI>();
        text = GameObject.Find("CollectedFood").GetComponent<Text>();
    }
    void OnTriggerEnter(Collider collider)
    {
        if(collider.name!="PlayerCube"){
            return;
        }
        Color c=text.color;
        c.a=1f;
        text.color = c;
        Debug.Log("FoodTrigger");
        HealthBarHandler.SetHealthBarValue(1f);
        OxygenBarHandler.SetOxygenBarValue(1f);
        Debug.Log("Power source spawned");
        objectiveText.text = "Find Power Source";
        objectiveText.color = Color.blue;
        Instantiate(powerSource, new Vector3(262.28f,67.95f,464.4f), Quaternion.Euler(-90,0,0));
        Destroy(gameObject, 1f);
    }
}
