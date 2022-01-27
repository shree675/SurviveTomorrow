using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainDetectionScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnParticleCollision(GameObject other){

        HealthBarHandler.SetHealthBarValue(HealthBarHandler.GetHealthBarValue() - 0.02f);
    
    }
}
