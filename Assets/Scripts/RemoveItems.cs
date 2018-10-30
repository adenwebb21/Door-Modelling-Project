using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveItems : MonoBehaviour
{
    private Transform itemTransform;
    private float startingZ;

    //private float minDissolve = 0;
    //private float maxDissolve = 1;

    //private float t = 0.0f;

    //private Renderer rend;
    //private float dissolveValue;

    private void Start()
    {
        itemTransform = transform;
        startingZ = itemTransform.position.z;
        //rend = gameObject.GetComponent<Renderer>();
        //dissolveValue = rend.material.GetFloat("Amount");
    }

    void Update()
    {
        if (itemTransform.position.z - startingZ >= 0.2)
        {
            //rend.material.SetFloat("Amount", 0.5f);
            gameObject.SetActive(false);
        }

        //rend.material.SetFloat("Amount", Mathf.Lerp(minDissolve, maxDissolve, t));
        //t += 0.5f * Time.deltaTime;
    }
}
