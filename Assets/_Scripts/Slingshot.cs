using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slingshot : MonoBehaviour
{
    public float bumpForce = 2.0f;
    public int points = 150;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("PlayerBall"))
        {
            Rigidbody rb = collision.rigidbody;
            rb.AddForce(transform.forward * bumpForce, ForceMode.Impulse);
            ScoreManager.AddScore(points);

        }
    }
}
