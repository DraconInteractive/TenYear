using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CameraScript : MonoBehaviour {
	public Vector3 desiredPos, currentPos;
	public float rotateSpeed, camDistance;
	public GameObject playerObj;
	public bool isGrounded;
	public Transform thisTransform;
	// Use this for initialization
	void Start () {
		playerObj = GameObject.FindGameObjectWithTag("Player");
		thisTransform = this.gameObject.GetComponent<Transform>();
		currentPos = playerObj.transform.position - Vector3.back * 4 + Vector3.up * 2;

	}
	
	// Update is called once per frame
	void Update () {
		CamMove();
	}

	public void CamMove (){
//
//		if (playerObj.GetComponent<PlayerScript>().isThirdPerson){
//			thisTransform.RotateAround(playerObj.transform.position, Vector3.up, Input.GetAxis("Mouse X") * rotateSpeed * Time.deltaTime);
//			thisTransform.RotateAround(playerObj.transform.position, transform.right, Input.GetAxis("Mouse Y") * -1 * rotateSpeed * Time.deltaTime);
//			
//			thisTransform.LookAt(playerObj.transform.position);
//			
//			transform.position = playerObj.transform.position - transform.forward * camDistance;
//		} else {
//			transform.rotation = Quaternion.LookRotation()
//
//			thisTransform.Rotate(Vector3.up, Input.GetAxis("Mouse X") * rotateSpeed * Time.deltaTime);
//			thisTransform.Rotate(transform.right, Input.GetAxis("Mouse Y") * rotateSpeed * Time.deltaTime);
//
//			transform.position = playerObj.transform.position + Vector3.up;
//		}

		transform.position = (playerObj.transform.position + (transform.up * 2.0f) + (-transform.forward * 4));

		transform.forward = playerObj.transform.forward;

		
		
	}
}
