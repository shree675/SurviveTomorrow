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

        // int numCollisionEvents = part.GetCollisionEvents(other, collisionEvents);

        // Rigidbody rb = other.GetComponent<Rigidbody>();
        // int i = 0;

        // while (i < numCollisionEvents)
        // {
        //     if (rb)
        //     {
        //         Vector3 pos = collisionEvents[i].intersection;
        //         Vector3 force = collisionEvents[i].velocity * 10;
        //         rb.AddForce(force);
        //     }
        //     i++;
        // }

        Debug.Log("!!!!!");
    }
}
