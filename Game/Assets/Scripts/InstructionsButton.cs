using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InstructionsButton : MonoBehaviour
{
    public static bool enabled=false;
    public Image instructions;
    public Text t;
    public RawImage inst;

    void Start()
    {
        instructions.enabled = enabled;
        inst.enabled=false;
    }

    public void OnClick()
    {
        enabled = !enabled;
        if (enabled)
        {
            t.text="CLOSE";
            this.gameObject.GetComponent<Image>().color = Color.red;
            instructions.enabled=true;
            inst.enabled=true;
        }
        else
        {
            t.text="Instructions";
            this.gameObject.GetComponent<Image>().color = Color.white;
            instructions.enabled=false;
            inst.enabled=false;
        }
    }
}
