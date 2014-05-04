using UnityEngine;
using System.Collections;

public class Text_rotation : MonoBehaviour {

	public GameObject text;
	public int speed;
	public int stop;
	public int i;
	private GameObject toto;
	
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(0f,4f, 0f);
	}
}
