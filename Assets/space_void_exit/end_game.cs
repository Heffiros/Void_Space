using UnityEngine;
using System.Collections;

public class end_game : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		RaycastHit myhit = new RaycastHit ();
		Ray myray = new Ray ();

		if (Input.GetKey(KeyCode.Mouse0)){
			myray = Camera.main.ScreenPointToRay (Input.mousePosition);
			if (Physics.Raycast (myray,out myhit,100)) {
				if(myhit.collider.gameObject.name == "End")
				{
					Application.Quit();
				}
	}
}
	}
}
