using UnityEngine;
using System.Collections;

public class LaunchGame : MonoBehaviour 
{
	void FixedUpdate()
	{
		if (Input.GetKeyDown(KeyCode.Space)) 
		{
			Application.LoadLevel("DemoScene");
		}
	}
}
