using UnityEngine;
using System.Collections;

public class SwordDamage : MonoBehaviour 
{
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Enemy" && !OnTouch) 
		{
			OnTouch = true;
			if (transform.position.x >= other.transform.position.x) 
			{
				other.transform.Translate(Vector2.left);
			}
			
			else if(transform.position.x <= other.transform.position.x)
			{
				other.transform.Translate(Vector2.right);
			}
			
			if (transform.position.y >= other.transform.position.y) 
			{
				other.transform.Translate(Vector2.down);
			}
			
			else if (transform.position.y <= other.transform.position.y) 
			{
				other.transform.Translate(Vector2.up);
			}

			other.gameObject.GetComponent<Stats>().m_life -= gameObject.GetComponent<Stats>().m_PowerDamage;
			print(other.gameObject.name + other.gameObject.GetComponent<Stats>().m_life);

			if (other.gameObject.GetComponent<Stats>().m_life <= 0) 
			{			
				Destroy(gameObject);
			}
			StartCoroutine(NoDamage());
		}
	}

	IEnumerator NoDamage()
	{
		yield return new WaitForSeconds (0.3f);
		OnTouch = false;
	}

	#region Private Variables
	bool OnTouch = false;
	#endregion
}