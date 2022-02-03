using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WaterFountainHealthTrigger : MonoBehaviour
{
    public GameObject food;
    public Vector3 foodPosition;

    public TextMeshProUGUI objectiveText;
    [SerializeField] Text text;

    void OnTriggerEnter(Collider collider)
    {
        food.SetActive(true);
        if (collider.name != "PlayerCube") return;
         HealthBarHandler.SetHealthBarValue(1f);
        text.enabled=true;
        text.gameObject.SetActive(true);
        Instantiate(food, foodPosition, transform.rotation);
        Debug.Log("Food spawned");
        objectiveText.text = "Find Food";
        objectiveText.color = Color.green;
        Destroy(gameObject, 1f);
    }
}
