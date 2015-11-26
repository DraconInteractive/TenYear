using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {
	public float speed, health, jumpForce, rotateSpeed;
	public float speedForward, speedStrafe;
	public Rigidbody thisRigidbody;
	public Transform thisTransform;
	public bool showConsole;
	public bool isThirdPerson;

	// Use this for initialization
	void Start () {
		RetrieveReferences();
		LoadGame ();
	}

	void FixedUpdate(){
		PlayerMovement();
	}
	// Update is called once per frame
	void Update () {
		PlayerInput();
	}

	public void RetrieveReferences(){
		thisRigidbody = GetComponent<Rigidbody>();
		thisTransform = GetComponent<Transform>();
	}

	public void PlayerMovement(){
		speedForward = Input.GetAxis("Vertical") * speed;
		speedStrafe = Input.GetAxis("Horizontal") * speed;

		thisRigidbody.velocity = new Vector3(speedStrafe * Time.deltaTime, thisRigidbody.velocity.y, speedForward * Time.deltaTime);
		transform.Rotate(Vector3.up, Input.GetAxis("Mouse X") * rotateSpeed * Time.deltaTime);
	}

	public void PlayerInput(){

		if (Input.GetMouseButtonDown(0)){
			PlayerFire(0);
		}
		if (Input.GetMouseButtonDown(1)){
			PlayerFire(1);
		}


//
//		if (isThirdPerson){
//			thisRigidbody.velocity = (Vector3.Cross (Camera.main.transform.right, Vector3.up) * speedForward * Time.deltaTime) + (Camera.main.transform.right * speedStrafe * Time.deltaTime);
//			transform.rotation = Quaternion.LookRotation(Vector3.Cross (Camera.main.transform.right, Vector3.up), Vector3.up);
//		} else {
//
//		}




		if (Input.GetButtonDown("Jump")){
			thisRigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
		}

		if (Input.GetButtonDown("Interact")){

		}

		if (Input.GetButtonDown ("Console")){
			ToggleConsole();
		}

		if (Input.GetButtonDown ("Save")){
			SaveGame();
		}

		if (Input.GetButtonDown ("Change POV")){
			isThirdPerson = !isThirdPerson;
		}

	}

	public void PlayerFire(int i){
		if (i == 0){
			//Fire 1
		} else if (i == 1){
			//Fire 2
		}
	}

	public void SaveGame(){
		PlayerPrefs.SetFloat("Health", health);
		PlayerPrefs.SetFloat("PlayerX", transform.position.x);
		PlayerPrefs.SetFloat("PlayerY", transform.position.y);
		PlayerPrefs.SetFloat("PlayerZ", transform.position.z);
	}

	public void LoadGame(){
		health = PlayerPrefs.GetFloat("Health", 100.0f);
		transform.position = new Vector3(PlayerPrefs.GetFloat("PlayerX", 0.0f), PlayerPrefs.GetFloat("PlayerY", 0.0f), PlayerPrefs.GetFloat("PlayerZ", 0.0f));
	}

	public void ToggleConsole(){
		showConsole = !showConsole;
	}

	public void ConsoleInput(){
		if (showConsole){
			//set console active
		} else {
			//set console inactive
		}
	}
}
