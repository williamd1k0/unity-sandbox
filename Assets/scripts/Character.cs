using UnityEngine;
using System.Collections;

public class Character : MonoBehaviour {

	public Rigidbody2D body;
	public float jumpSpeed = 30;
	private bool jumping = false;

	// Use this for initialization
	void Start () {
		print (body);
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.X) && !jumping){
			print("Jump");
			jumping = true;
			body.AddForce(Vector2.up * jumpSpeed, ForceMode2D.Impulse);
		}
	}
}
