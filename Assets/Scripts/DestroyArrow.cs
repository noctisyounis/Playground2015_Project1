using UnityEngine;
using System.Collections;

public class DestroyArrow : MonoBehaviour
{
    private GameObject m_player;
    private ArrowBehavior m_arrowBehavior;
    private ChangePlayerState m_playerState;
    private Stats m_stats;

	void Start ()
    {
        m_player = GameObject.FindGameObjectWithTag("Player");
        m_stats = m_player.GetComponent<Stats>();
        m_arrowBehavior = this.GetComponentInParent<ArrowBehavior>();
        m_playerState = m_player.GetComponent<ChangePlayerState>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
       // m_arrowBehavior.m_canMove = false;
        if (other.tag == "Player" && m_playerState.m_isNormal)
        {
            m_stats.isDamage(1);
            Destroy(this.gameObject);
        }

        if (other.tag == "Wall")
        {
            Destroy(this.gameObject);
        }

    }
}
