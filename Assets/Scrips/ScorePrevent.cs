using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScorePrevent : MonoBehaviour
{
    public bool GoneThough = false;

    void OnTriggerExit()
    {
        GoneThough = true;

        if (GoneThough == true)
        {
            Invoke("ColliderDetect", 0.5f);
        }
    }

    void ColliderDetect()
    {
        gameObject.GetComponent<BoxCollider>().enabled = false;
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
