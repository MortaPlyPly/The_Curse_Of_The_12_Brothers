using UnityEngine;
using System.Collections;

public class Trigger : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Dont hurt me onichan");
        Debug.Log(Time.time);
        Debug.Log(other.gameObject.name);
        //Destroy(gameObject);
        GetComponent<Rigidbody2D>().velocity = GetComponent<Rigidbody2D>().velocity * 2;
        Vector2 vel = GetComponent<Rigidbody2D>().velocity;
        vel.y = 0;
        GetComponent<Rigidbody2D>().velocity = vel;


        /*Instantiate(explosion, transform.position, transform.rotation);
        gameController.AddScore(scoreValue);
        if (other.tag == "Player 1" || other.tag == "Player 2")
        {
            gameController.UpdateLifes(-1, other);
            return;
        }*/
        //Destroy(other.gameObject);
    }
}