using System.Collections;
using System.Collections.Generic;

using UnityEngine;
public class level3 : MonoBehaviour {

	void OnGUI()
	{
		if(GUI.Button(new Rect(250,85,50,50),"level 3"))
		{
			print ("Start game");
			Application.LoadLevel("scene5");
		}
	}
}