using UnityEngine;
using System.Collections;

public class RetryGame : MonoBehaviour 
{
	#region Public Variables
	#endregion

	#region Methods
	public void LaunchStart()
	{
		Application.LoadLevel("StartScene");
	}

	public void LaunchGame()
	{
		Application.LoadLevel("DemoScene");
	}
	#endregion

	#region Private Variables
	#endregion
}
