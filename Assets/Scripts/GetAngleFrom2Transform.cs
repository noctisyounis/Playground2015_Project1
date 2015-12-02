using UnityEngine;
using System.Collections;

public class GetAngleFrom2Transform : MonoBehaviour 
{
	public Transform other;

	void Update () 
	{
		Vector3 dir = other.transform.position - transform.position;
		dir = other.transform.InverseTransformDirection(dir);
		angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        angle = angle + 180;
	}




	void OnGUI()
	{
		GUILayout.Button ("angle: " + (angle) );
	}

	float angle;
}
