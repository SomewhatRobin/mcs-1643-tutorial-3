using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flipper : MonoBehaviour
{

    public KeyCode keyToPress;
    private HingeJoint hinge;
    private AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {
        hinge = GetComponent<HingeJoint>();
        audioSrc = GetComponentInChildren<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(keyToPress))
        {
            audioSrc.Play();
        }

        if (Input.GetKey(keyToPress))
        {
            
            hinge.useSpring = false;
            hinge.useMotor = true;


        } else
        {
            hinge.useSpring = true;
            hinge.useMotor = false;

        }
    }
}
