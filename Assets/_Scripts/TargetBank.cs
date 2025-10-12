using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetBank : MonoBehaviour
{
    public int points = 500;

    public GameObject[] targets;
    public float timeToReset = 0.1f;


    private bool waitingToReset = false;

    private void Update()
    {
        if (waitingToReset)
        {
            return;
        }

        bool allDown = true;
        foreach (GameObject target in targets)
        {
            if ( target.activeInHierarchy)
            {
                allDown = false;
                break;
            }
        }

        if (allDown)
        {

            waitingToReset = true;
            ScoreManager.AddScore(points);
            Invoke("ResetTargets", timeToReset);
            
        }

    }

    private void ResetTargets()
    {
        foreach (GameObject target in targets)
        {
            target.SetActive(true);
            waitingToReset = false;
        }
    }
}
