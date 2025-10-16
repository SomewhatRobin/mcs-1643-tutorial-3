using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BladeStake : MonoBehaviour
{

    public int anteSize = 250;

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("PlayerBall"))
        {
            ChickenDinner.AddStake(anteSize);

            Invoke(nameof(ResetStake),4.5f);
        }
    }

    private void ResetStake()
    {
        ChickenDinner.AddStake(anteSize * -1);
    }
}
