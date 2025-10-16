using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int lives = 3;
    public GameObject ballPrefab;
    public Transform ballStart;
    public GameObject gameOverPanel;

        public void Start()
    {

        gameOverPanel.SetActive(false);

    }
    
       // Debug Quick Respawn Button 
       public KeyCode keyToPress;
       public GameObject curBall;

       void Update()
       {
           if (Input.GetKeyDown(keyToPress))
           {
               curBall = GameObject.FindWithTag("PlayerBall");
               Destroy(curBall.gameObject);

               Instantiate(ballPrefab, ballStart.position, Quaternion.identity);
           }
       }
  
    public void EndBall()
    {
        lives--;
        if (lives == 0)
        {
            //show the game over
            gameOverPanel.SetActive(true);
        }
        else
        {
            //instantiate a new ball at proper position
            Instantiate(ballPrefab, ballStart.position, Quaternion.identity);
        }
    }
}
