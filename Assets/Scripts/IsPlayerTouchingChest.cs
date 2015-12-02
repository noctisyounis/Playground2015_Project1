using UnityEngine;
using System.Collections;

public class IsPlayerTouchingChest : MonoBehaviour {

    private GameObject _player;
    private OpenChest OpenedChest;

	// Use this for initialization
	void Start () {
        _player = GameObject.FindGameObjectWithTag("Player");
        OpenedChest = GetComponent<OpenChest>();
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    void OnTriggerStay2D(Collider2D other)
    {

            OpenedChest.IsTouchingChest = true;
    }

    void OnTriggerExit2D()
    {
        OpenedChest.IsTouchingChest = false;
    }
    

}
