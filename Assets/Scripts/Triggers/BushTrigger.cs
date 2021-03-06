﻿using UnityEngine;
using System.Collections;

public class BushTrigger : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Game information: " + gameObject.name + "collided with " + other.name);
        //Destroy(gameObject);
        GetComponent<Rigidbody2D>().velocity = GetComponent<Rigidbody2D>().velocity * 2;
        Vector2 vel = GetComponent<Rigidbody2D>().velocity;
        vel.y = 0;
        GetComponent<Rigidbody2D>().velocity = vel;
        GetComponent<AudioSource>().Play();

        /*Instantiate(explosion, transform.position, transform.rotation);
        gameController.AddScore(scoreValue);
        if (other.tag == "Player 1" || other.tag == "Player 2")
        {
            gameController.UpdateLifes(-1, other);
            return;
        }*/
        //Destroy(other.gameObject);

        //Camera.main.GetComponent<PerlinShake>().PlayShake();
    }
}