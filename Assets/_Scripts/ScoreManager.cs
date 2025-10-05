using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private static int score;


    // Start is called before the first frame update
    void Start()
    {
        score = 0; 
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString();
    }

    public static void AddScore(int points)
    {
        // score = score + points;
        score += points;
    }



}
