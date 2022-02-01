using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireDamage : MonoBehaviour
{

    void OnTriggerStay()
    {
        HealthBarHandler.SetHealthBarValue(HealthBarHandler.GetHealthBarValue() - 0.005f);
    }
}
