using UnityEngine;
using System.Collections;

public class MovePlayerTest : MonoBehaviour {

	public float speed = 0.2f; // vitesse de déplacement
	private Vector3 NewPosition; 

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		NewPosition.x = Mathf.Clamp(Input.GetAxis ("Horizontal") * speed + this.gameObject.transform.position.x,-8.03f,+8.03f);
		NewPosition.y = Mathf.Clamp(Input.GetAxis ("Vertical") * speed + this.gameObject.transform.position.y,- 5.0f,5.0f);
		NewPosition.z = this.gameObject.transform.position.z;
		
		this.gameObject.transform.position = NewPosition; 

	}
}
