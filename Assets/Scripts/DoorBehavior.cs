using UnityEngine;
using System.Collections;

public class DoorBehavior : MonoBehaviour {

    private GameObject m_player;
    private SpriteRenderer m_spriteRenderer;
    private PlayerInventory m_inventory;
    private BoxCollider2D m_boxcollider;

	// Use this for initialization
	void Start ()
    {
        m_spriteRenderer = GetComponent<SpriteRenderer>();
        m_player = GameObject.FindGameObjectWithTag("Player");
        m_inventory = m_player.GetComponent<PlayerInventory>();
        m_boxcollider = GetComponent<BoxCollider2D>();
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            if(m_inventory.m_keyAmount > 0)
            {
                m_inventory.UseKey();
                m_spriteRenderer.enabled = false;
                m_boxcollider.isTrigger = true;
            }
        }
    }
}
