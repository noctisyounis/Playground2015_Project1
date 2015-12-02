using UnityEngine;
using System.Collections;

public class IsPlayerTouchingTotem : MonoBehaviour {

    private GameObject m_player;
    private ChangePlayerState m_changePlayerState;
	// Use this for initialization
	void Start () {

        m_player = GameObject.FindGameObjectWithTag("Player");
        m_changePlayerState = m_player.GetComponent<ChangePlayerState>();
    }
	
	void OnTriggerEnter2D()
    {
        m_changePlayerState.m_isTouchingTotem = true;
    }

    void OnTriggerExit2D()
    {
        m_changePlayerState.m_isTouchingTotem = false;
    }
}
