using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class InputManager : MonoBehaviour {

    public GameObject target;
	public Player player;
	public Vector3 mousePositionInGameWorld;

	void Start () {
		Cursor.visible = false;
	}


	void Update () {
		if(TestPauseInGame.Instance.inMenu) return;
		TrackMousePosition();
		TrackKeyboard();
		TrackMouseClick();

	}

	private void TrackMousePosition(){
		Vector3 mousePositionOnScreen = Input.mousePosition;

		mousePositionInGameWorld = new Vector3(mousePositionOnScreen.x,mousePositionOnScreen.y,Camera.main.transform.position.z*-1);
		mousePositionInGameWorld = Camera.main.ScreenToWorldPoint(mousePositionInGameWorld); // convertit la position de la souris en unité de mesure du jeu

		target.transform.position = Input.mousePosition;

	}

    private void TrackKeyboard(){
		if(Input.GetKey(KeyCode.Z)){

			player.StartEngine();
		}
		if(Input.GetKeyUp(KeyCode.Z)){
			player.StopEngine();
		}
	}

	private void TrackMouseClick(){
		if(Input.GetMouseButtonDown(0)){

			player.Shoot();
		}
	}
	}