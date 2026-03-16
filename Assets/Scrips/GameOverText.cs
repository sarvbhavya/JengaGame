using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverText : MonoBehaviour
{

    public GameManagerScript GMS;
    public Text Gameovertext;

    void Start()
    {
        Gameovertext.enabled = false;
    }

    void Update()
    {
        if(GMS.gameHasEnded == true)
        {
            Gameovertext.enabled = true;
        }
    }
}
