using System.Collections;
using System.Collections.Generic;

using UnityEngine;
public class MainMenu : MonoBehaviour {

	void OnGUI()
	{
		if(GUI.Button(new Rect(10,30,50,50),"starts"))
		{
			print ("Start game");
			Application.LoadLevel("scene1");
		}
	}
}