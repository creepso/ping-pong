using System.Collections;
using System.Collections.Generic;

using UnityEngine;
public class level1 : MonoBehaviour {

	void OnGUI()
	{
		if(GUI.Button(new Rect(140,85,50,50),"level 1"))
		{
			print ("Start game");
			Application.LoadLevel("scene1");
		}
	}
}