using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InstructionsButton : MonoBehaviour
{
    public bool enabled=false;
    public Image instructions;
    public Text t;

    void Start()
    {
        instructions.enabled = enabled;
    }

    public void OnClick()
    {
        enabled = !enabled;
        if (enabled)
        {
            t.text="CLOSE";
            this.gameObject.GetComponent<Image>().color = Color.red;
            instructions.enabled=true;
            
        }
        else
        {
            t.text="Instructions";
            this.gameObject.GetComponent<Image>().color = Color.white;
            instructions.enabled=false;
        }
    }
}
