using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

	public GameObject laser;
	public GameObject engineFire;
	public InputManager inputManager;
	public float speed;

	private bool isMoving;
	private Rigidbody2D rigidBody;


	void Start () {
		rigidBody = GetComponent<Rigidbody2D>();
		engineFire.SetActive(false);
	}


	void Update () {

		if(TestPauseInGame.Instance.inMenu) return;


		Vector3 directionOfRotation = inputManager.mousePositionInGameWorld - transform.position; // direction de la rotarotation wesh ma gueule
		transform.rotation = Quaternion.LookRotation(Vector3.forward,directionOfRotation);

		 if(isMoving){
		 	rigidBody.AddForce(transform.up*speed);

		 }

		 float limitXLeft = Camera.main.ViewportToWorldPoint(new Vector3(0,0,Camera.main.transform.position.z)).x;
		 float limitYBottom = Camera.main.ViewportToWorldPoint(new Vector3(0,0,Camera.main.transform.position.z)).y;
		 float limitXRight = Camera.main.ViewportToWorldPoint(new Vector3(1,1,Camera.main.transform.position.z)).x;
		 float limitYUp = Camera.main.ViewportToWorldPoint(new Vector3(1,1,Camera.main.transform.position.z)).y;

		 Vector3 tempPosition = new Vector3(transform.position.x, transform.position.y,transform.position.z);
		 float tempX = Mathf.Clamp(tempPosition.x,limitXLeft,limitXRight);
		 float tempY = Mathf.Clamp(tempPosition.y,limitYBottom,limitYUp);

		 tempPosition.x = tempX;
		 tempPosition.y = tempY;

		 transform.position = tempPosition;

	}

	public void StartEngine(){
		print("StartEngine");
		isMoving = true;
		engineFire.SetActive(true);
	}

	public void StopEngine(){
		print("StopEngine");
		isMoving = false;
		engineFire.SetActive(false);
	}

	public void Shoot(){
		print("Shoot laser!!");
		GameObject newLaser = Instantiate(laser,transform.position,transform.rotation) as GameObject;
	}

}
