using UnityEngine;
using System.Collections;

public class ontouchhero : MonoBehaviour {
	public int life;
	void OnTriggerEnter(Collider other){
		Destroy (other.gameObject);
		SpaceShip.life -= planet.fire_degat;
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(SpaceShip.life < 1)
		{
			Destroy (shipmovementfight.controler);
			Application.LoadLevel("Gameover");
		}
	}
}
