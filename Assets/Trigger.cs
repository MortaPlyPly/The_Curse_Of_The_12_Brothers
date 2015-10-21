using UnityEngine;
using System.Collections;

public class Trigger : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Dont hurt me onichan");
        Destroy(gameObject);

        /*Instantiate(explosion, transform.position, transform.rotation);
        gameController.AddScore(scoreValue);
        if (other.tag == "Player 1" || other.tag == "Player 2")
        {
            gameController.UpdateLifes(-1, other);
            return;
        }*/
        Destroy(other.gameObject);
    }
}
