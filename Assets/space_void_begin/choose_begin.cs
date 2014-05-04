using UnityEngine;
using System.Collections;

public class choose_begin : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		RaycastHit myhit = new RaycastHit ();
		Ray myray = new Ray ();

		if (Input.GetKey (KeyCode.Escape)) {
			Application.LoadLevel("exit");		
		}
		if (Input.GetKey(KeyCode.Mouse0)){
			myray = Camera.main.ScreenPointToRay (Input.mousePosition);
			if (Physics.Raycast (myray,out myhit,100)) {
				if(myhit.collider.gameObject.name == "Jouer")
				{
					Application.LoadLevel("menu");
				}
				else if (myhit.collider.gameObject.name == "Credits"){
					Application.LoadLevel("credits");
				}
			}
		}
	}
}
