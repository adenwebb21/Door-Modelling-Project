using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flicker : MonoBehaviour
{
    private Light light;

    private float lightInterval;
    private float flickerAmount;
    private float flickerStartTime;


    private void Start()
    {
        light = gameObject.GetComponent<Light>();

        flickerStartTime = Time.time;
        
        flickerAmount = Random.Range(1.1f, 1.7f);
        lightInterval = Random.Range(0.01f, 0.2f);
    }

    private void Update()
    {
        if(Time.time - flickerStartTime >= lightInterval)
        {
            light.intensity = Mathf.Lerp(light.intensity, flickerAmount, 0.5f);
            flickerAmount = Random.Range(1.1f, 1.7f);
            lightInterval = Random.Range(0.01f, 0.2f);
            flickerStartTime = Time.time;
        }
    }
}
