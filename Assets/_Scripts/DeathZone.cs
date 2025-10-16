using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    public GameManager manager;
    private AudioSource audioSrc;


    private void Start()
    {
        //Finds and sets up manager for comms with GameManager
        manager = FindObjectOfType<GameManager>();
        audioSrc = GetComponentInChildren<AudioSource>();
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("PlayerBall"))
        {

            audioSrc.Play();
            //destroy the ball
            Destroy(other.gameObject);
          
            //Tell game manager that the ball was destroyed
            manager.EndBall();
        }
    }
       
}
