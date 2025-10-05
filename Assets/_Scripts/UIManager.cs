using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI livesText;

    //For Start script
    private GameManager manager;

    private void Start()
    {
        //Finds and sets up manager for comms with GameManager
       manager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    private void Update()
    {
        
        livesText.text = $"Balls: {manager.lives.ToString()}" ;
    }
}
