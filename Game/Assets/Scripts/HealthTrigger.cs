using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthTrigger : MonoBehaviour
{

    void OnTriggerStay()
    {
        HealthBarHandler.SetHealthBarValue(HealthBarHandler.GetHealthBarValue() + 0.005f);
    }
}
