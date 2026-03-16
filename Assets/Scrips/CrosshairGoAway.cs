using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CrosshairGoAway : MonoBehaviour
{

    public GameObject CrosshairOut;
    public GameManagerScript GMS;
    public PauseMenu PAUSEmu;

    void Update()
    {
        if(GMS.gameHasEnded == true)
        {
            CrosshairOut.SetActive(false);
        }
    }

}
