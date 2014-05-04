using UnityEngine;
using System.Collections;

public class life : MonoBehaviour {

	public GUIText ship_life;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		ship_life.text = SpaceShip.life + "pdv";
		}
}
