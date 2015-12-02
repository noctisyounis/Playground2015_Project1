using UnityEngine;
using System.Collections;

public class RetryGame : MonoBehaviour 
{
	#region Public Variables
	#endregion

	#region Methods
	public void LaunchStart() // quit
	{
		Application.LoadLevel("StartScene");
	}

	public void LaunchGame() //retry
	{
		Application.LoadLevel("1");
	}
	#endregion

	#region Private Variables
	#endregion
}
