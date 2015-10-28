using UnityEngine;
using System.Collections;

public class BossController : MonoBehaviour {
	
	public GameObject wave;
	public Transform spawn;
	private float nextFire;
	public float fireRate = 0.5f;
	private int count = 0;
	public Animator animator;


	void Start () {
		animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {

		if (Time.time > nextFire) {
			nextFire = Time.time + fireRate;
			Instantiate (wave, spawn.position, spawn.rotation);
			count++;
		}

		if (count >= 10) {
			animator.SetInteger("Shots", 10);
			Destroy (this);
		}
			
	}
}
