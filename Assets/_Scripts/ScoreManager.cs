using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private int score;


    // Start is called before the first frame update
    void Start()
    {
        score = 0; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore(int points)
    {
        // score = score + points;
        score += points;
    }



}
