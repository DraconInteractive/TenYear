using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {
	public float speed, health, jumpForce;
	public Rigidbody thisRigidbody;
	public Transform thisTransform;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void PlayerInput(){

		if (Input.GetMouseButtonDown(0)){

		}
		if (Input.GetMouseButtonDown(1)){

		}
		thisRigidbody.MovePosition(transform.position + transform.forward * Input.GetAxis("Vertical") * speed * Time.deltaTime);
		thisRigidbody.MovePosition(transform.position + transform.right * Input.GetAxis("Horizontal") * speed * Time.deltaTime);

		if (Input.GetButtonDown("Jump")){
			thisRigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
		}

	}

	public void PlayerFire(){

	}
}
