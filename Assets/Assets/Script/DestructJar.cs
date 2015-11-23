using UnityEngine;
using System.Collections;

public class DestructJar : MonoBehaviour {
	public GameObject ObjetDrop;
	public Vector3 TransformP; 
	public int NbObjetPop = 1;
	// Use this for initialization
	void Start () {
		TransformP	= transform.position;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D other) // Attention RigidBody et BoxCollider2d pour les deux
	{
		Debug.Log ("Je suis passé");
		if (other.gameObject.name == "PlayerTest") {
			Destroy(gameObject);
		}
		if (NbObjetPop > 0) 
		{
			Instantiate (ObjetDrop, TransformP, this.transform.rotation);
			// Donner une animation à la l'objet drop( de haut en bas, pour tous les objets --> facile à gérer )
			NbObjetPop -= 1;
		}

	}
}
