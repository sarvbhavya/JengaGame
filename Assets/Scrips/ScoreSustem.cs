using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSustem : MonoBehaviour
{
    public float Points = 0f;
    public GameManagerScript Gm;

    void OnTriggerExit()
    {
        Points = Points + 10f;
        Debug.Log(Points);
        gameObject.layer = 2;
    }

    public void Update()
    {
        if (Gm.gameHasEnded == true)
        {
            Points = Points - Points;
        }

        if (Gm.gameHasEnded == true)
        {
            Invoke("LayerSwitch", 1f);
        }
    }

    void LayerSwitch()
    {
        gameObject.layer = 2;
    }
}
