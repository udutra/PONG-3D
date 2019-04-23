using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float ballSpeed;
    public Rigidbody ballRigidbody;
    public Vector3 movementDirection;
    public GameManager gameManager;

    private void Start()
    {
        ballRigidbody.velocity = new Vector3(ballSpeed, 0.0f, 0.0f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player1GateTag")
        {
            gameManager.UpdatePlayerScore(2);
        }
        else if (other.tag == "Player2GateTag")
        {
            gameManager.UpdatePlayerScore(1);
        }
    }
}
