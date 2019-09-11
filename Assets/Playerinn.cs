using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerinn : MonoBehaviour
{
    public Rigidbody rb;
    public float hradi = 50f;
    public float sidewaysForce = 50f;

    //public GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        // Debug.Log("leikur byrjaður");
       // rb.AddForce(0, 0,500);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, -hradi * Time.deltaTime);
        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        /*eða svona
       if (rb.position.y < -1f)
       {
           gameManager.EndGame();
       }
       */

        if (rb.position.y < -1f)
       {
           FindObjectOfType<GameManager>().EndGame();
       }
    }
}
