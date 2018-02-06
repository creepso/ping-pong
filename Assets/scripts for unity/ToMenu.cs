using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToMenu : MonoBehaviour {

	void OnGUI()
	{
		if(GUI.Button(new Rect(10,140,50,50),"menu"))
		{
			print ("Start game");
			Application.LoadLevel("scene3");
		}
	}
}