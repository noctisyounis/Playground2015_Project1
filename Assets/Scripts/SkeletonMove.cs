using UnityEngine;
using System.Collections;

public class SkeletonMove : MonoBehaviour 
{
	#region Public Variable
	public Transform target;// Cible à définir dans unity (Héros de la scene)
	public float speed = 3f;
	#endregion

//-----------------------------------------------------------

	#region Methods
	//TODO Ne doit pas changer de salle
	void Start()
	{
		target = GameObject.FindWithTag("Player").transform;
		Debug.Log (target);
	}

	void Update()
	{	
		//Déplacement vers le Player
		if (Vector2.Distance(transform.position,target.position)<8.0f)
		{
			transform.position = Vector2.MoveTowards(transform.position,target.position,speed * Time.deltaTime);
		}
	}

	void OnGUI()
	{
		
		GUILayout.Button ( target.transform.position + ""); 
	}
	#endregion
}
