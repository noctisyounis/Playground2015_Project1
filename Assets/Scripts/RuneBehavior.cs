using UnityEngine;
using System.Collections;

public class RuneBehavior : MonoBehaviour {

    private GameObject m_player;
    private ChangePlayerState m_playerState;

    private SpriteRenderer m_playerSprite;
    public Sprite m_normalState;
    public Sprite m_specterState;

    // Use this for initialization
    void Start () {

        m_player = GameObject.FindGameObjectWithTag("Player");
        m_playerState = m_player.GetComponent<ChangePlayerState>();
        m_playerSprite = m_player.GetComponent<SpriteRenderer>();
    }
	
	void OnTriggerEnter2D()
    {
        if (!m_playerState.m_isNormal)
        {
            m_playerSprite.sprite = m_normalState;
            m_playerState.m_isNormal = true;
        }
    }
}
