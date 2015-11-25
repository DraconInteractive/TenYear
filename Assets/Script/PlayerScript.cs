using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {
	public float speed, health, jumpForce;
	public float speedForward, speedStrafe;
	public Rigidbody thisRigidbody;
	public Transform thisTransform;
	public bool showConsole;

	// Use this for initialization
	void Start () {
		RetrieveReferences();
		LoadGame ();
	}
	
	// Update is called once per frame
	void Update () {
		PlayerInput();
	}

	public void RetrieveReferences(){
		thisRigidbody = GetComponent<Rigidbody>();
		thisTransform = GetComponent<Transform>();
	}

	public void PlayerInput(){

		if (Input.GetMouseButtonDown(0)){
			PlayerFire(0);
		}
		if (Input.GetMouseButtonDown(1)){
			PlayerFire(1);
		}



		Vector3 _Direction = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
		thisRigidbody.MovePosition (transform.position + _Direction * speed * Time.deltaTime);


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
