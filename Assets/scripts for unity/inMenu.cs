using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inMenu : MonoBehaviour {

	void OnGUI()
	{
		if(GUI.Button(new Rect(10,195,50,50),"menu"))
		{
			print ("Start game");
			Application.LoadLevel("scene3");
		}
	}
}