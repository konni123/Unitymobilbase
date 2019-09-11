using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 2f;
   // public GameObject completeLevelUI;
    public void CompleteLeval()
    {
        Debug.Log("level Won!!");
        //completeLevelUI.SetActive(true);
    }
    public void EndGame()
    {

        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Leik lokið");
            Invoke("Restart", restartDelay);
            //restart
            //Thread.Sleep(1000);
            Restart();
        }

    }
    void Restart()
    {
        //SceneManager.LoadScene("Leval_01");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
