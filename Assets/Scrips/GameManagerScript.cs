using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour
{
    public bool gameHasEnded = false;

    public GameObject PannelText;
    public GameObject GameOverText;

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("GAME OVER");
            Invoke("Restart", 5f);
            //UI Based Changes
            PannelText.SetActive(true);
            GameOverText.SetActive(true);
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene("GameScene");
    }
}
