using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaneSensor : MonoBehaviour
{
    public int points = 250;
    private AudioSource audioSrc;

    void Start()
    {
        audioSrc = GetComponentInChildren<AudioSource>();
    }




    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("PlayerBall"))
        {
            audioSrc.Play();
            ScoreManager.AddScore(points);
        }
    }


}
