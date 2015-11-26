using UnityEngine;
using System.Collections;

public class PlayerAttack : MonoBehaviour 
{
	#region Public Variables
	public GameObject m_swordPrefab;
	public GameObject m_arrowPrefab;
	public float m_speed = 3f;
	public string m_direction;
	#endregion

	#region Methods
	void Start()
	{
		PlayerTransform = GetComponent<Transform> ();
		RB = GetComponent<Rigidbody2D> ();
		SwordDirection = PlayerTransform.position;
		Rotation = PlayerTransform.rotation;
	}

	void FixedUpdate()
	{
		if (Input.GetKey(KeyCode.LeftArrow))
		{
			Vector3 V = new Vector3 (-2, 0, 1);
			SwordDirection = PlayerTransform.position + V;
			Rotation = Quaternion.Euler(new Vector3(0,0,0));
			m_direction = "Left";
		}

		if (Input.GetKey(KeyCode.RightArrow)) 
		{			
			Vector3 V = new Vector3 (2, 0, 1);
			SwordDirection = PlayerTransform.position + V;
			Rotation = Quaternion.Euler(new Vector3(0,0,0));
			m_direction = "Right";
		}

		if (Input.GetKey(KeyCode.UpArrow)) 
		{	
			Vector3 V = new Vector3 (0, 2, 1);
			SwordDirection = PlayerTransform.position + V;
			Rotation = Quaternion.Euler(new Vector3(0,0,90));
			m_direction = "Up";
		}

		if (Input.GetKey(KeyCode.DownArrow)) 
		{	
			Vector3 V = new Vector3 (0, -2, 1);
			SwordDirection = PlayerTransform.position + V;
			Rotation = Quaternion.Euler(new Vector3(0,0,90));
			m_direction = "Down";
		}

		SwordAttack();
		ArrowAttack();
	}

	void ArrowAttack()
	{
		if (Input.GetKeyDown(KeyCode.X))
		{
			RB.constraints = RigidbodyConstraints2D.FreezeAll;
			
			ArrowClone = Instantiate (m_arrowPrefab, SwordDirection, Rotation) as GameObject;
			Rigidbody2D ArrowRB = ArrowClone.GetComponent<Rigidbody2D>();
			if (m_direction == "Right")
			{
				ArrowRB.velocity = Vector2.right*m_speed;
			}
			if (m_direction == "Left")
			{
				ArrowRB.velocity = Vector2.left*m_speed;
			}
			if (m_direction == "Up")
			{
				ArrowRB.velocity = Vector2.up*m_speed;
			}
			if (m_direction == "Down")
			{
				ArrowRB.velocity = Vector2.down*m_speed;
			}
			
			StartCoroutine(NoMove());
		}
	}

	void SwordAttack()
	{
		if (Input.GetKeyDown(KeyCode.Space)) 
		{
			RB.constraints = RigidbodyConstraints2D.FreezeAll;
			
			SwordClone = Instantiate (m_swordPrefab, SwordDirection, Rotation) as GameObject;
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
	GameObject ArrowClone;
	Rigidbody2D RB;
	Vector3 SwordDirection;
	Quaternion Rotation;
	#endregion
}
