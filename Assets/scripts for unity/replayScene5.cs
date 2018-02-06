using System.Collections;
using System.Collections.Generic;

using UnityEngine;
public class replayScene5 : MonoBehaviour {

	void OnGUI()
	{
		if(GUI.Button(new Rect(10,85,50,50),"replay"))
		{
			print ("Start game");
			Application.LoadLevel("scene5");
		}
	}
}