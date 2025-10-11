using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetBank : MonoBehaviour
{
    public int points = 500;

    public GameObject[] targets;

    private void Update()
    {
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
            ScoreManager.AddScore(points);
            foreach (GameObject target in targets)
            {
                target.SetActive(true);
            }

        }

    }

}
