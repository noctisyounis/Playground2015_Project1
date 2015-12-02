using UnityEngine;
using System.Collections;
using UnityEditor;
[RequireComponent (typeof (Stats))]
public class Fight : MonoBehaviour 
{
	public float m_delay = 0.1f;
	public bool m_isTouch = false;
	public GameObject target;

    private SpriteRenderer m_spriteRenderer;

    #region Methods

    void Start()
	{
        //chargement du sprite
        m_spriteRenderer = GetComponent<SpriteRenderer> ();
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
				transform.Translate(Vector2.left);
			}

			else if(transform.position.x >= other.transform.position.x)
			{
				transform.Translate(Vector2.right);
			}

			if (transform.position.y <= other.transform.position.y) 
			{
				transform.Translate(Vector2.down);
			}

			else if (transform.position.y >= other.transform.position.y) 
			{
				transform.Translate(Vector2.up);
			}

			//animation touche
			gameObject.GetComponent<Stats>().m_life -= other.gameObject.GetComponent<Stats>().m_PowerDamage;
			StartCoroutine(Flasher());
			Destroy (transform.FindChild ("Sword(Clone)"));
		}

		if (gameObject.GetComponent<Stats>().m_life <= 0 && gameObject.tag != "Sword") 
		{
			//TODO			
			StopAllCoroutines();
			Destroy(gameObject, 0.2f);
			Application.LoadLevel("GameOver");
		}
	}

	IEnumerator Flasher()
	{
		m_isTouch = true;
		for (int i = 0; i < 5; i++) 
		{
			yield return new WaitForSeconds(m_delay);

            //animation clignote
            m_spriteRenderer.enabled = false;

			yield return new WaitForSeconds(m_delay);

            //animation clignote
            m_spriteRenderer.enabled = true;

			yield return new WaitForSeconds(m_delay);
		}
		m_isTouch = false;
	}

	#endregion
}
