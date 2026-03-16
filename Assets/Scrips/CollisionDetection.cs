using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{

    public float blocksFallen = 0f;
    public float Score = 0f;

    void OnTriggerEnter()
    {
        blocksFallen = blocksFallen + 1;
        Invoke("Logic", 0.2f);
    }

    void Update()
    {
        if (blocksFallen > 2)
        {
            FindObjectOfType<GameManagerScript>().EndGame();
        }

    }

    void Logic()
    {
      if (blocksFallen > 1)
        {
         blocksFallen = blocksFallen - 1;
        }
        
    }
}
