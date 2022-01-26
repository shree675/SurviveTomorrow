using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OxygenTrigger : MonoBehaviour
{

    void OnTriggerStay()
    {
        OxygenBarHandler.SetOxygenBarValue(OxygenBarHandler.GetOxygenBarValue() + 0.005f);
    }
}
