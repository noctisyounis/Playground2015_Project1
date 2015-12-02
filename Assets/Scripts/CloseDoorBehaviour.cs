using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CloseDoorBehaviour : MonoBehaviour
{
    //public Sprite m_opendoor;

    private SpriteRenderer m_spriteRendeRer;   
    //private GameObject m_interruptor;
    //private InterruptorBehavior m_interruptorBehavior;
    private BoxCollider2D m_boxCollider;


    public List<InterruptorBehavior> m_switchesNeeded;

    private bool m_canOpen = false;

	// Use this for initialization
	void Start ()
    {
        m_spriteRendeRer = GetComponent<SpriteRenderer>();
        m_boxCollider = GetComponent<BoxCollider2D>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        for (int i = 0; i < m_switchesNeeded.Count; i++)
        {
            if (m_switchesNeeded[i].m_isActive)
            {
                m_canOpen = true;
            }

            else
            {
                m_canOpen = false;
                return;
            }
        }

        if (m_canOpen)
        {
            m_spriteRendeRer.enabled = false;
            m_boxCollider.enabled = false;
        }

        //if (m_interruptorBehavior.m_isActive)
        //{
        //    //m_spriteRendeRer.sprite = m_opendoor;
        //    m_spriteRendeRer.enabled = false;
        //    m_boxCollider.enabled = false;
        //}
	}
}
