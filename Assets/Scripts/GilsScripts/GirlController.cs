using UnityEngine;
using System.Collections;

public class GirlController : MonoBehaviour {

    public int speed = 10000;
    public int jumpForce = 35000;
    public bool isOnGround = false;
    public int lifes = 100;
    public int dealDemage = 1;

    public GameObject shot;
    public GameObject shotSpawn;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.A))
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(-speed, 0));
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(speed, 0));
        }
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            isOnGround = false;
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpForce));
        }

        if (Input.GetKeyDown(KeyCode.Z))
            Instantiate(shot, shotSpawn.transform.position, shotSpawn.transform.rotation);



    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if(coll.gameObject.tag == "Ground")
            isOnGround = true;
    }
}
