using UnityEngine;
using System.Collections;

public class DestructJar : MonoBehaviour
{
	public GameObject m_objectToDrop;
	private Vector3 m_vasePosition;
    //private bool m_hasDropped = false;

	void Start ()
    {
        m_vasePosition = transform.position;
	}

	void OnCollisionEnter2D(Collision2D other) // Attention RigidBody et BoxCollider2d pour les deux
	{
		if (other.gameObject.name == "Sword")
        {
            Instantiate(m_objectToDrop, m_vasePosition, transform.rotation);
            Destroy(gameObject);
		}

		//if (!m_hasDropped) 
		//{
		//	Instantiate (m_objectToDrop, m_vasePosition, transform.rotation);
  //          // Donner une animation à la l'objet drop( de haut en bas, pour tous les objets --> facile à gérer )
  //          m_hasDropped = true;
  //      }

	}
}
