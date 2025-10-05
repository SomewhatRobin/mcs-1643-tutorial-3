using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{

    public float launchForce = 1.0f;
    public float targetTimeHeld = 2.8f;

    private Rigidbody rb;
    public float secondsHeld = 0f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            secondsHeld += Time.deltaTime;
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            float timePct = secondsHeld / targetTimeHeld;
            if ( timePct > 1.0f)
            {
                timePct = 1.0f;
            }

            if (rb != null)
            {
                rb.AddForce(transform.up * launchForce * timePct);
            }
            
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("PlayerBall"))
        {
            rb = collision.rigidbody;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        rb = null;
        secondsHeld = 0f;
    }

}
