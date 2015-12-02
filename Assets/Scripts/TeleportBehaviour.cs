using UnityEngine;
using System.Collections;

public class TeleportBehaviour : MonoBehaviour {

    private GameObject Player;
    private Vector3 Destination = new Vector3(25,-22,0);
	// Use this for initialization
	void Start () {

        Player = GameObject.FindGameObjectWithTag("Player");

	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Player.transform.position = Destination;
        }
    }
    
}
