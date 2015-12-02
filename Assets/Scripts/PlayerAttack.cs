using UnityEngine;
using System.Collections;

public class PlayerAttack : MonoBehaviour 
{
	#region Public Variables
	public GameObject m_swordPrefab;
	public GameObject m_swordPrefabUp;
	public GameObject m_swordPrefabDown;
	public GameObject m_swordPrefabLeft;
	public GameObject m_swordPrefabRight;
	public GameObject m_arrowPrefab;
	public float m_shootSpeed;
	public string m_direction;
	#endregion

	#region Methods
	void Start()
	{
		PlayerTransform = GetComponent<Transform> ();
		RB = GetComponent<Rigidbody2D> ();
		AttackDirection = PlayerTransform.position;
		Rotation = PlayerTransform.rotation;

		//-------------------------------------------------------------
		// Initialization of direction ( sword && arrow ) 
		Vector3 V = new Vector3 (0, -2, -1);
		AttackDirection = PlayerTransform.position + V;
		Rotation = Quaternion.Euler(new Vector3(0,0,90));
		m_direction = "Down";
	}


	void FixedUpdate()
	{
		if (Input.GetKey(KeyCode.LeftArrow))
		{
			Vector3 V = new Vector3 (-2, 0, -1);
			AttackDirection = PlayerTransform.position + V;
			m_direction = "Left";
		}

		if (Input.GetKey(KeyCode.RightArrow)) 
		{			
			Vector3 V = new Vector3 (2, 0, -1);
			AttackDirection = PlayerTransform.position + V;
			m_direction = "Right";
		}

		if (Input.GetKey(KeyCode.UpArrow)) 
		{	
			Vector3 V = new Vector3 (0, 2, -1);
			AttackDirection = PlayerTransform.position + V;
			m_direction = "Up";
		}

		if (Input.GetKey(KeyCode.DownArrow)) 
		{	
			Vector3 V = new Vector3 (0, -2, -1);
			AttackDirection = PlayerTransform.position + V;
			m_direction = "Down";
		}

		SwordAttack();
		ArrowAttack();
	}

	void ArrowAttack()
	{
		if (Input.GetKeyDown(KeyCode.X) && CanShoot)
		{
			CanShoot = false;
			RB.constraints = RigidbodyConstraints2D.FreezeAll;
			
			ArrowClone = Instantiate (m_arrowPrefab, AttackDirection, Rotation) as GameObject;
			Rigidbody2D ArrowRB = ArrowClone.GetComponent<Rigidbody2D>();
			if (m_direction == "Right")
			{
				ArrowRB.velocity = Vector2.right*m_shootSpeed;
				print (GetComponent<Stats>().m_speedVelocity);
			}
			if (m_direction == "Left")
			{
				ArrowRB.velocity = Vector2.left*m_shootSpeed;
			}
			if (m_direction == "Up")
			{
				ArrowRB.velocity = Vector2.up*m_shootSpeed;
			}
			if (m_direction == "Down")
			{
				ArrowRB.velocity = Vector2.down*m_shootSpeed;
			}

			StartCoroutine(NoMove());
		}
	}

	void SwordAttack()
	{
		if (Input.GetKeyDown(KeyCode.Space) && CanShoot) 
		{

			if (m_direction == "Right")
			{
				print ("RightAttack");
				SwordClone = Instantiate(m_swordPrefabRight, transform.position, m_swordPrefabRight.transform.rotation) as GameObject;
			}
			if (m_direction == "Left")
			{
				print ("LeftAttack");
				SwordClone = Instantiate(m_swordPrefabLeft, transform.position, m_swordPrefabLeft.transform.rotation) as GameObject;
			}
			if (m_direction == "Up")
			{
				print ("UptAttack");
				SwordClone = Instantiate(m_swordPrefabUp, transform.position, m_swordPrefabUp.transform.rotation) as GameObject;
			}
			if (m_direction == "Down")
			{
				print ("DownAttack");
				SwordClone = Instantiate(m_swordPrefabDown, transform.position, m_swordPrefabDown.transform.rotation) as GameObject;
			}


			RB.constraints = RigidbodyConstraints2D.FreezeAll;
			
			//SwordClone = Instantiate (m_swordPrefab, AttackDirection, Rotation) as GameObject;
			//SwordClone.transform.parent = transform;
			Destroy(SwordClone,0.3f);
			StartCoroutine(NoMove());
		}
	}

	IEnumerator NoMove()
	{
		//print ("Don't Move !");
		yield return new WaitForSeconds (0.3f);
		RB.constraints = RigidbodyConstraints2D.FreezeRotation;
		CanShoot = true;
	}
	#endregion

	#region Private Variables
	Transform PlayerTransform;
	GameObject SwordClone;
	GameObject ArrowClone;
	Rigidbody2D RB;
	Vector3 AttackDirection;
	Quaternion Rotation;
	bool CanShoot = true;
	#endregion
}
