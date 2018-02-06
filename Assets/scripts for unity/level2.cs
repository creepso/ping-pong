using System.Collections;
using System.Collections.Generic;

using UnityEngine;
public class level2 : MonoBehaviour {

	void OnGUI()
	{
		if(GUI.Button(new Rect(195,85,50,50),"level 2"))
		{
			print ("Start game");
			Application.LoadLevel("scene2");
		}
	}
}