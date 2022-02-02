using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public float delay = 3f;
    private double time;
    public GameObject explosionEffect;
    public GameObject flame;
    public AudioSource audioData;

    float countdown;
    public bool hasExploded = false;

    void Start()
    {
        countdown = delay;
        time = 0;
    }

    void OnTriggerStay(Collider collider)
    {
        if(collider.name=="PlayerCube"){
            countdown -= Time.deltaTime;
            if (countdown <= 0f && !hasExploded)
            {
                audioData.Play(0);
                Explode();
                hasExploded = true;
            }
        }
    }

    void OnTriggerExit()
    {
        countdown = delay;
        hasExploded = false;
    }

    void Explode()
    {
        GameObject exp1 = Instantiate(explosionEffect, transform.position, transform.rotation);
        gameObject.transform.position = new Vector3(gameObject.transform.position.x+100f, gameObject.transform.position.y+100f, gameObject.transform.position.z+100f);
        Destroy(gameObject,1f);
        Destroy(exp1, 1.5f);
        GameObject flameObject = Instantiate(flame, transform.position, transform.rotation);
    }
}
