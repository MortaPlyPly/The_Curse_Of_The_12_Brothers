using UnityEngine;
using System.Collections;

public class RandomGen : MonoBehaviour {


	public GameObject g1;
	public GameObject g2;
	public GameObject g3;
	public Vector2 spawnValues;

	void Start ()
	{
		SpawnObject (g1);
		SpawnObject (g2);
		SpawnObject (g3);
	}

	void SpawnObject (GameObject o)
	{
		//Vector2 spawnPosition = new Vector2 (Random.Range(-spawnValues.x,));
	}
}
