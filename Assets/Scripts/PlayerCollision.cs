using System;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerCilosion : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            FindObjectOfType<PlayerMovement>().enabled = false;
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}
