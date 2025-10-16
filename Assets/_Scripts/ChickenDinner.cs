using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenDinner : MonoBehaviour
{
    private static int points = 500;

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("PlayerBall"))
        {
            ScoreManager.AddScore(points);
            
        }
    }



    public static void AddStake(int Ante)
    {
        //work plz
        points += Ante;
        

    }


}
