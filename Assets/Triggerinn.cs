using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triggerinn : MonoBehaviour
{
    public GameManager gameManager;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("hitti triggerinn");
        gameManager.EndGame();
    }
}
