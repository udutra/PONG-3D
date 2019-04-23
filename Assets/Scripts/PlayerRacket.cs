using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRacket : MonoBehaviour
{
    public float racketSpeed;
    public Rigidbody racketRigidbody;

    public KeyCode playerUp, playerDown;

    private void Update()
    {
        if (Input.GetKey(playerUp))
        {
            racketRigidbody.velocity = new Vector3(0, racketSpeed,0);
        }
        else if (Input.GetKey(playerDown))
        {
            racketRigidbody.velocity = new Vector3(0, -racketSpeed, 0);
        }
        else
        {
            racketRigidbody.velocity = new Vector3(0, 0, 0);
        }
    }
}
