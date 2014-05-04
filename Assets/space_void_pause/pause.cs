using System;
using UnityEngine;

public class pause : MonoBehaviour
{
	bool paused = false;
	
	void Update()
	{
		if(Input.GetKeyDown("escape"))
			paused = togglePause();
	}
	
	void OnGUI()
	{
		if(paused)
		{
			GUILayout.BeginArea(new Rect(370, 200, 130, 150));
			GUILayout.Label("Void Space is paused");
			if(GUILayout.Button("Return to Game "))
				paused = togglePause();
			GUILayout.EndArea();
		}
	}
	
	bool togglePause()
	{
		if(Time.timeScale == 0f)
		{
			Time.timeScale = 1f;
			return(false);
		}
		else
		{
			Time.timeScale = 0f;
			return(true);    
		}
	}
}