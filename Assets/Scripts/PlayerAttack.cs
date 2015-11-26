using UnityEngine;
using System.Collections;

public class PlayerAttack : MonoBehaviour 
{
	#region Public Variables
	public GameObject m_swordPrefab;
	#endregion

	#region Methods
	void Start()
	{
		PlayerTransform = GetComponent<Transform> ();
		RB = GetComponent<Rigidbody2D> ();
		SwordDirection = PlayerTransform.position;
		SwordRotation = PlayerTransform.rotation;
	}

	void Update()
	{
		if (Input.GetKey(KeyCode.LeftArrow)) 
		{			
			Vector3 V = new Vector3 (-2, 0, 1);
			SwordDirection = PlayerTransform.position + V;
			SwordRotation = Quaternion.Euler(new Vector3(0,0,0));
		}

		if (Input.GetKey(KeyCode.RightArrow)) 
		{			
			Vector3 V = new Vector3 (2, 0, 1);
			SwordDirection = PlayerTransform.position + V;
			SwordRotation = Quaternion.Euler(new Vector3(0,0,0));
		}

		if (Input.GetKey(KeyCode.UpArrow)) 
		{	
			Vector3 V = new Vector3 (0, 2, 1);
			SwordDirection = PlayerTransform.position + V;
			SwordRotation = Quaternion.Euler(new Vector3(0,0,90));
		}

		if (Input.GetKey(KeyCode.DownArrow)) 
		{	
			Vector3 V = new Vector3 (0, -2, 1);
			SwordDirection = PlayerTransform.position + V;
			SwordRotation = Quaternion.Euler(new Vector3(0,0,90));
		}

		if (Input.GetKeyDown(KeyCode.Space)) 
		{
			RB.constraints = RigidbodyConstraints2D.FreezeAll;

			SwordClone = Instantiate (m_swordPrefab, SwordDirection, SwordRotation) as GameObject;
			Destroy(SwordClone,0.3f);
			StartCoroutine(NoMove());
		}
	}

	IEnumerator NoMove()
	{
		print ("Don't Move !");
		yield return new WaitForSeconds (0.3f);
		RB.constraints = RigidbodyConstraints2D.FreezeRotation;
	}
	#endregion

	#region Private Variables
	Transform PlayerTransform;
	GameObject SwordClone;
	Rigidbody2D RB;
	Vector3 SwordDirection;
	Quaternion SwordRotation;
	#endregion
}
