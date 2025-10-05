using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    public GameManager manager;

    private void Start()
    {
        //Finds and sets up manager for comms with GameManager
        manager = FindObjectOfType<GameManager>();
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("PlayerBall"))
        {


            //destroy the ball
            Destroy(other.gameObject);

            //Tell game manager that the ball was destroyed
            manager.EndBall();
        }
    }
       
}
