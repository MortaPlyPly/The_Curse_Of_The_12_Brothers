using UnityEngine;
using System.Collections;

public class SimpleMover : MonoBehaviour
{
    public float speed;

    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = transform.right * speed;
    }
}

