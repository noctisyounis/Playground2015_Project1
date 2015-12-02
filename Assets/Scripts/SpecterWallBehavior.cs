using UnityEngine;
using System.Collections;

public class SpecterWallBehavior : MonoBehaviour {

    private GameObject m_player;
    private ChangePlayerState m_playerState;
    private BoxCollider2D m_boxCollider;

    // Use this for initialization
    void Start () {

        m_player = GameObject.FindGameObjectWithTag("Player");
        m_playerState = m_player.GetComponent<ChangePlayerState>();
        m_boxCollider = GetComponent<BoxCollider2D>();
    }
	
	// Update is called once per frame
	void Update () {

        //Activer ou désactiver le trigger du box collider pour que le joueur puisse traverser ce mur en etant spectre.
        if (!m_playerState.m_isNormal)
        {
            m_boxCollider.isTrigger = true;
        }
        else
        {
            m_boxCollider.isTrigger = false;
        }
	}
}
