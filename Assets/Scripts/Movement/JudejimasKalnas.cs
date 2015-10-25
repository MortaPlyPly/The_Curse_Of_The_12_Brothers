using UnityEngine;
using System.Collections;

public class JudejimasKalnas : MonoBehaviour
{
	public float speed;
	public float stop;
	
	void Start()
	{
		GetComponent<Rigidbody2D>().velocity = Vector2.left * speed;
	}
	
	void FixedUpdate()
	{
		if (GetComponent<Transform> ().position.x < stop)
		{
			GetComponent<Rigidbody2D>().velocity = Vector2.left * 0;
		}
	}
}
