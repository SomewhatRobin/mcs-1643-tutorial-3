using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slingshot : MonoBehaviour
{
    public float bumpForce = 2.0f;
    public int points = 150;

    private AudioSource audioSrc;

    void Start()
    {
        audioSrc = GetComponentInChildren<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        audioSrc.Play();

        if (collision.transform.CompareTag("PlayerBall"))
        {
            Rigidbody rb = collision.rigidbody;
            rb.AddForce(transform.right * bumpForce, ForceMode.Impulse);
            ScoreManager.AddScore(points);

        }
    }
}
