using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropTarget : MonoBehaviour
{
    public int points = 50;
    private AudioSource audioSrc;


    void Start()
    {
        audioSrc = GetComponentInChildren<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    { 
        if (collision.transform.CompareTag("PlayerBall"))
        {
            //This seems to deactivate before the SFX becomes audible :<
            audioSrc.Play();
            ScoreManager.AddScore(points);
            gameObject.SetActive(false);
        }
    }
}
