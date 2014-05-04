using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Escape)) {
						Application.Quit ();
				}
		else if (Input.GetKey (KeyCode.Mouse0)) {
			Application.LoadLevel("space_void_begin");
				}
	}
}
