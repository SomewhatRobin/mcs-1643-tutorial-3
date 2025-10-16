using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BladePiston : MonoBehaviour
{
    public GameObject startPos;
    private Rigidbody rb;
    public float speed = 36.0f;
 
    public KeyCode keyToPress;
    private bool justUsed = false;
   

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        transform.position = new Vector3 (startPos.transform.position.x, startPos.transform.position.y, startPos.transform.position.z);

    }

    // Piston's outward is right

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(keyToPress) && !justUsed)
        {

            rb.AddForce(transform.right * speed, ForceMode.Impulse);
            justUsed = true;
            Invoke(nameof(ResetPos), 1.2f);


            Invoke(nameof(ReadyUp), 2.2f);

        }
    }

    private void ReadyUp()
    {
        if (justUsed)
        {
            justUsed = false;
        }
    }

    private void ResetPos()
    {
        transform.position = startPos.transform.position;
    }
}
