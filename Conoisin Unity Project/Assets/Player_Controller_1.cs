using UnityEngine;
using System.Collections;

public class Player_Controller_1 : MonoBehaviour {

	public bool jump = false;
	public float speed = 5;
	public float jumpForce = 1000f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void FixedUpdate ()
	{
		Controller ();
		if (jump) {
			GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpForce));




		}
	}
	void Controller () {
		if (Input.GetButtonDown("Jump") == true) {
			jump = true;
		    	
	}
}
}

