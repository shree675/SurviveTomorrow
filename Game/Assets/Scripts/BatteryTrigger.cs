using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BatteryTrigger : MonoBehaviour
{

    [SerializeField] Text text;
    public static bool gameOver;

    private void Awake()
    {
        text = GameObject.Find("CollectedPower").GetComponent<Text>();
        gameOver=false;
    }

    void OnTriggerEnter(Collider collider)
    {
        if(collider.name!="PlayerCube"){
            return;
        }
        Color c=text.color;
        c.a=1f;
        text.color = c;
        Debug.Log("Battery Collected");
        gameOver=true;
        gameObject.SetActive(false);
    }
}
