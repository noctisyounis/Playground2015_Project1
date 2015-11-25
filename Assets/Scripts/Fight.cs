using UnityEngine;
using System.Collections;
[RequireComponent (typeof (Stats))]
public class Fight : MonoBehaviour 
{
	#region Public variables
	public float m_delay = 0.1f;
	public bool m_isTouch = false;

	public GameObject target;
	#endregion

//-----------------------------------------------------------

	#region Methods
	void Start()
	{
		//chargement du sprite
		Rend = GetComponent<SpriteRenderer> ();
	}

	void Update()
	{		
		if (gameObject.GetComponent<Stats>().m_life <= 0 && gameObject.tag != "Sword") 
		{		
			Destroy(gameObject);
		}
	}

	void OnCollisionStay2D (Collision2D other)
	{	
		if (other.gameObject.tag == "Enemy" && !m_isTouch) 
		{
			if (transform.position.x <= other.transform.position.x) 
			{
				print("x < E");
				transform.Translate(Vector2.left);
			}

			else if(transform.position.x >= other.transform.position.x)
			{
				print("x > E");
				transform.Translate(Vector2.right);
			}

			if (transform.position.y <= other.transform.position.y) 
			{
				print("y < E");
				transform.Translate(Vector2.down);
			}

			else if (transform.position.y >= other.transform.position.y) 
			{
				print("y > E");
				transform.Translate(Vector2.up);
			}

			//animation touche
			gameObject.GetComponent<Stats>().m_life -= other.gameObject.GetComponent<Stats>().m_PowerDamage;
			Debug.Log ("Il me reste " + gameObject.GetComponent<Stats>().m_life);
			StartCoroutine(Flasher());
			Debug.Log ("Je lance le FLASH");
		}

		if (gameObject.GetComponent<Stats>().m_life <= 0 && gameObject.tag != "Sword") 
		{
			//TODO			
			StopAllCoroutines();			
			Destroy(gameObject,0.2f);
		}
	}

	IEnumerator Flasher()
	{
		m_isTouch = true;
		Debug.Log ("test clignote");
		for (int i = 0; i < 5; i++) 
		{
			yield return new WaitForSeconds(m_delay);

			//animation clignote
			Rend.enabled = false;

			yield return new WaitForSeconds(m_delay);

			//animation clignote
			Rend.enabled = true;

			yield return new WaitForSeconds(m_delay);
		}
		m_isTouch = false;
	}
	#endregion

//-----------------------------------------------------------

	#region Private Variable
	//Material material;
	Rigidbody2D OtherRB;
	SpriteRenderer Rend;
	#endregion
}
