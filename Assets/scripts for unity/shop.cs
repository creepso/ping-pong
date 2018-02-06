using System.Collections;
using System.Collections.Generic;

using UnityEngine;
public class shop : MonoBehaviour {

	void OnGUI()
	{
		if(GUI.Button(new Rect(10,140,50,50),"shop"))
		{
			print ("Start game");
			Application.LoadLevel("scene4");
		}
	}
}