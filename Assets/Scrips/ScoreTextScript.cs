using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTextScript : MonoBehaviour
{

    public Text ScoreText;
    public ScoreSustem ScoreS;

    void Update()
    {
        ScoreText.text = ScoreS.Points.ToString();
    }
}
