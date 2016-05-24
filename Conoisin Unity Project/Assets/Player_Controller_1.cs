using UnityEngine;
using System.Collections;

public class Player_Controller_1 : MonoBehaviour {

	public bool jump = false;
	public float jump_force = 1000f;
	public float max_speed = 5f;
	public float move_force = 365f;

	void Start () 
	{
	
	}

	void Update ()
	{
		Jump_Detect ();
	}

	void FixedUpdate ()
	{
		Movement ();
		Jump ();	
	}

	void Jump_Detect()
	{
		if (Input.GetButtonDown ("Jump") == true) 
		{
			jump = true;
		}
	}

	void Jump()
	{
		if (jump)
		{
			GetComponent<Rigidbody2D> ().AddForce (new Vector2 (0f, jump_force));
			jump = false;
		}
	}

	void Movement()
	{
		float h = Input.GetAxis ("Horizontal");
		if (h * GetComponent<Rigidbody2D> ().velocity.x < max_speed) {
			GetComponent<Rigidbody2D> ().AddForce (Vector2.right * h * move_force); 
		}
		if (Mathf.Abs(GetComponent<Rigidbody2D>().velocity.x) > max_speed) {
			GetComponent<Rigidbody2D> ().velocity = 
			new Vector2 (Mathf.Sign (GetComponent<Rigidbody2D> ().velocity.x)
			* max_speed, GetComponent<Rigidbody2D> ().velocity.y);
		}
	}
}

